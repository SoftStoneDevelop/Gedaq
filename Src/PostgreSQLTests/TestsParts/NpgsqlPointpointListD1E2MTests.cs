

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8155405708389419d, y: 0.5598203387270624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5240461443676202d, y: 0.09814855614123597d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9282636386118993d, y: 0.923787326779034d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15867698958876975d, y: 0.9628929492899353d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09437548764193315d, y: 0.5647460035060692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43785778039648515d, y: 0.7423625210920657d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16541667160521578d, y: 0.4757129104334862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03369728122603022d, y: 0.7549171356925728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03588462000468795d, y: 0.5231873726912487d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5899376077301451d, y: 0.007266552084759903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020778744504982294d, y: 0.80974385808613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.341604897353346d, y: 0.399080845994215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8268145895402067d, y: 0.9336890091473874d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.805476702688275d, y: 0.47007324185897936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6582110226637826d, y: 0.708936862621117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7698066566292436d, y: 0.6765484434233401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.286617579632255d, y: 0.22141812890914414d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8015845106809989d, y: 0.8182864318729224d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9350433480054079d, y: 0.5484988162381774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9456703680389069d, y: 0.8829126873053237d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8238323549184317d, y: 0.15581083175321675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7854810853222913d, y: 0.5379465825860916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7834931926603607d, y: 0.920815657193391d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23992698924779166d, y: 0.8794084743772628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13681476567557938d, y: 0.24788643647568676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9876659117115033d, y: 0.5713462921319751d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4046332305501711d, y: 0.3006789980518183d),

new NpgsqlTypes.NpgsqlPoint(x: 0.163449103483711d, y: 0.27646715915837794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6012674640304447d, y: 0.6514900960591841d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.791194860170044d, y: 0.06943570533014498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08910485651026745d, y: 0.10820677344776419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9035557708704629d, y: 0.23467711579280826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32704696328951355d, y: 0.8641435000116914d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4204941989844634d, y: 0.143567325282266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3268742157923923d, y: 0.9683461361733688d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7725187027272269d, y: 0.28493958797190544d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4186056684036167d, y: 0.405850151152793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7562957282864109d, y: 0.5031244441733306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7860165951599672d, y: 0.8992143921004176d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6863285293552309d, y: 0.1124302961680993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02738389316935408d, y: 0.3689257754345451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6496282311208549d, y: 0.01772281349626037d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49070511087066426d, y: 0.5259027738082096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3681065328434614d, y: 0.7288004934285414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41084440728384486d, y: 0.24714858700945797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.889120980540245d, y: 0.5779774811554226d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9338239355626345d, y: 0.34508461342997376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49529484731497875d, y: 0.6651318919284158d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1689854062554016d, y: 0.6851761632552897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5109727371920716d, y: 0.26973112222959306d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4762093655933046d, y: 0.8897709776666456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.011058473474008457d, y: 0.43287676765927885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3917160032988619d, y: 0.3565825632088889d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49560676659717784d, y: 0.9591044840248047d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5660205821780343d, y: 0.9649483347924223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9889711830585751d, y: 0.043332106423696004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3144424042183468d, y: 0.9018561655193155d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8191158096884704d, y: 0.01334656276227697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17207077232290358d, y: 0.23462608975908494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21170986652196067d, y: 0.6836408254801226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8411113249695061d, y: 0.5915068293003648d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19160206129972024d, y: 0.5788879674201758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4308780464450752d, y: 0.35064101833379924d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26264481154353925d, y: 0.39197505092084384d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2138614346382791d, y: 0.47473458027589155d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0028672451819131695d, y: 0.7124152902252614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09335990735115873d, y: 0.2338148993372795d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25687725375172954d, y: 0.7776260317561057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4291701448103541d, y: 0.5633572041310699d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8172021821917018d, y: 0.28458626707792767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7231499028497999d, y: 0.4405698287964275d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1581093434199835d, y: 0.9233416318061451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8886941943647929d, y: 0.22734122010934843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6764388018522784d, y: 0.01739668050348331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7388437382462172d, y: 0.38680251393431464d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9169279886656957d, y: 0.3478165906947981d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16438104337724968d, y: 0.9036057140379724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16299539031109045d, y: 0.45521567394628826d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7942356713065359d, y: 0.7849012339042541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8402020158094768d, y: 0.2674724541081086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6039140825643147d, y: 0.9565663965889344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7655691048077675d, y: 0.12591481296862517d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.051247916047178044d, y: 0.476854418754863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.276902449922523d, y: 0.46201739933015384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5084386213558588d, y: 0.7922348176461617d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04479533564947613d, y: 0.0004701288777181345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4526320563383136d, y: 0.671733707485176d),

new NpgsqlTypes.NpgsqlPoint(x: 0.827527362972763d, y: 0.8616907842661048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41045226376810284d, y: 0.1162025156835419d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5023303261805696d, y: 0.4208278015307706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.612784676347557d, y: 0.6362602552723282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5009839136738004d, y: 0.95511689566703d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07999803401246652d, y: 0.42838341895993093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07589361636404024d, y: 0.5156968687139654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5760455269257826d, y: 0.17008536493482185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33116641103492084d, y: 0.40899713508994595d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1288704114287953d, y: 0.8863890132509711d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4367479586798114d, y: 0.25862727623149895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2965365629725176d, y: 0.7975125573371651d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07114394270467972d, y: 0.6433136700722606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33061487069340556d, y: 0.25285183335035366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9516130398711353d, y: 0.8358441765223728d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8981501688533268d, y: 0.15521711690583928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6175599061422106d, y: 0.8442109008142274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5969669862331591d, y: 0.883546101572182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.908398616003723d, y: 0.6941275636181151d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7119990412287425d, y: 0.7622733846555507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5224388948359862d, y: 0.19921059879196656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6516076989768207d, y: 0.761818227774824d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18882579874854277d, y: 0.4618256421342465d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5332007276028342d, y: 0.5824550476263761d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06065962798262059d, y: 0.16590638406064007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08256143563073604d, y: 0.1722380656614394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3525844374593372d, y: 0.7140849494431695d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3673186761346878d, y: 0.3425433261763814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.757366971702003d, y: 0.8588205024462476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3296788543380723d, y: 0.7142879156315044d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21843421019749076d, y: 0.7138640857732386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7472509782465565d, y: 0.3392220312176071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9103109880614638d, y: 0.1419817419084094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19179099285016132d, y: 0.7935616730823997d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30183329199775955d, y: 0.9742669023980519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6345124627772799d, y: 0.37527243114583775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6975203482018772d, y: 0.005559616061234451d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4681203969609665d, y: 0.14637110381624296d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07743570967592472d, y: 0.7264677135568485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47878639826840264d, y: 0.3694630455057647d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1846347267437728d, y: 0.8858408220997807d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8107943621619333d, y: 0.922296003291235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021205950798163786d, y: 0.4239177762213858d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8419362621532904d, y: 0.7369604235755157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5746520881021978d, y: 0.261997548377667d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28664787883213183d, y: 0.8703800976013976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1387766520277104d, y: 0.5503873053870612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.062416873412046936d, y: 0.4651126052875829d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7266072364337764d, y: 0.2515594783450046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7066276835577822d, y: 0.9756012890459753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6783930478312838d, y: 0.9697878308577025d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9471065950183783d, y: 0.21066271817086146d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8805496106901158d, y: 0.16598467318931265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7763913273634959d, y: 0.8308726993357621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5813568604577515d, y: 0.10998408781043356d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17099056044966232d, y: 0.8428378446496154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9634427562693143d, y: 0.5968572014477747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17419960845134608d, y: 0.17343903180838915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6094102716834066d, y: 0.46470227518478524d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.052567374227799446d, y: 0.21758484469252426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08558867895895506d, y: 0.22429795160421118d),

new NpgsqlTypes.NpgsqlPoint(x: 0.918023926784619d, y: 0.6299753642467284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33222178615587794d, y: 0.5624093548799797d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49959917965610423d, y: 0.09215061567608063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4127528521537933d, y: 0.898043326837437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4303548529986254d, y: 0.1678741195946346d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06040838707720886d, y: 0.43035590966274884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9577967447613353d, y: 0.5659163296571593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8239236289949311d, y: 0.6043735084708924d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35871032670902925d, y: 0.808682405783284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.80531440807653d, y: 0.5545424707731867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32306015091645646d, y: 0.3501864365746199d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6525922409872777d, y: 0.690905860571584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0849710060966814d, y: 0.8755209779525555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9432668495357663d, y: 0.21990782694937105d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8016772441754698d, y: 0.12547160978285454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13467518038024928d, y: 0.8132317082398482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5932497839660598d, y: 0.9760776537552468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9862808072750223d, y: 0.5103990328674312d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5116715507629171d, y: 0.011544439304248755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013438866990409193d, y: 0.2660966686123287d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23837732178196314d, y: 0.12104403060253321d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2812171865301939d, y: 0.8586475736225088d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7121408482226661d, y: 0.23307045256194592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.860597435776147d, y: 0.33306687828008863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7514860681076416d, y: 0.37713276439030186d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28770230353745263d, y: 0.17934922700152667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.056470133377280685d, y: 0.5275949006229486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02809971914187903d, y: 0.26960183191129483d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34996582438771684d, y: 0.9098882729231311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46920515495340165d, y: 0.8796126435499653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9381151660490642d, y: 0.041613972460635584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.005785608804393494d, y: 0.08802049233605325d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36902693178808044d, y: 0.27396950388828767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14679765998461536d, y: 0.6705449429076893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41835076235027724d, y: 0.7970458181857887d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2852916474198054d, y: 0.43022337435117775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29708043366644965d, y: 0.1400373122143712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09878842153657696d, y: 0.13440093286091737d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6838673168320819d, y: 0.19573543174751706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.743853997810273d, y: 0.015907512323678263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7948931255890821d, y: 0.8790078603343369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38931811667579785d, y: 0.4882497397685819d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5399722368488125d, y: 0.10564241689038634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9476160643112518d, y: 0.5392401476244186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1358283508627398d, y: 0.7674412341380926d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.067976247793892d, y: 0.4538841852667389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8135869625464957d, y: 0.7204181368913128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9953293292082291d, y: 0.8485908963342099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10964929011815894d, y: 0.10457938468638062d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.024188238751187474d, y: 0.1557822410716566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12367709277203809d, y: 0.354662519562127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028878259946311657d, y: 0.6667611692726009d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5708441717965148d, y: 0.6774821546945442d),

new NpgsqlTypes.NpgsqlPoint(x: 0.51764367848238d, y: 0.269112222318836d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8072444590154203d, y: 0.728746363307806d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08694714207875376d, y: 0.18173249361606036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5929102563660263d, y: 0.6260863217093875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7111506247190983d, y: 0.367469572454896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4277546515636105d, y: 0.502159141942708d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4810473975728373d, y: 0.1392656840830605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5528049150073666d, y: 0.12222658071455261d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7727601545757274d, y: 0.7411763673634564d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11429484831073211d, y: 0.12457950501194925d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3865546331061763d, y: 0.4634844718987968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5040072815968535d, y: 0.6743517953511456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07814541671356334d, y: 0.21472368909168382d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8871885706456646d, y: 0.09200981921578777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8694505037013699d, y: 0.43222347245397663d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17838897244968321d, y: 0.2813026872619937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7962236521563892d, y: 0.6316994028448109d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06451931269396871d, y: 0.02563232013823835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26186591886694566d, y: 0.5011541180070447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4173572089639591d, y: 0.35131954492724005d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2817769757279115d, y: 0.15515139554109536d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.321260138796031d, y: 0.5717552984039983d),

new NpgsqlTypes.NpgsqlPoint(x: 0.456469062527034d, y: 0.8500661495039854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.703756581557218d, y: 0.6063034303874187d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9474393733559485d, y: 0.899997661091982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20651250358219753d, y: 0.5603479769145254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14231344703348991d, y: 0.7085001616766439d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1765474411166399d, y: 0.31152648367553815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9936749815592657d, y: 0.4675872099219718d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2447778524521047d, y: 0.12398414875011154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.962377805141457d, y: 0.24958555756556344d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12109578678122057d, y: 0.11904604137865982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.92704024337481d, y: 0.9585034441605771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018112495103351556d, y: 0.2993907778747118d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12534222721994104d, y: 0.6573219607729089d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8160761330343012d, y: 0.8614131207810508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1319568146065061d, y: 0.2680203664166477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2512880481838524d, y: 0.5727122577246865d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44023250518134915d, y: 0.9254591564772607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16410925381314057d, y: 0.651065327274858d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2973318818257562d, y: 0.502037080800436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3981178541510122d, y: 0.7290121367984899d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6552851022477363d, y: 0.23596983977829877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8532907987286413d, y: 0.9771716595707152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2535196674519319d, y: 0.5049257585324609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6528236982908676d, y: 0.9050107411105577d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06775374209040663d, y: 0.8930726879255778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1814217319712037d, y: 0.23574453817724872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3382601875810176d, y: 0.6681411172985414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33376249880270237d, y: 0.8756541136422773d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.87881471529159d, y: 0.6776573711881764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19034596223543365d, y: 0.15405739421257436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6518457372898178d, y: 0.4482130543643593d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8551797593390067d, y: 0.9376012907909941d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7996491027310708d, y: 0.18600659861424051d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5780914871362763d, y: 0.24268314334993202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8564268177543558d, y: 0.9849871316357337d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42803462119438096d, y: 0.073776071951561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5342866286504603d, y: 0.5133757442969966d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4000735950306872d, y: 0.9810306909161682d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9345274635456887d, y: 0.21652700456114715d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 152;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 85, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 6, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 79, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

