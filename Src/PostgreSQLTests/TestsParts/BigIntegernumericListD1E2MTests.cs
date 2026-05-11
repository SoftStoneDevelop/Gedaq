

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4065984935207619340L),

new System.Numerics.BigInteger(7584602487771366868L),

new System.Numerics.BigInteger(559989328505929569L),

new System.Numerics.BigInteger(946262322953997878L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8286722943930407940L),

new System.Numerics.BigInteger(261929605915263717L),

new System.Numerics.BigInteger(4230804850937818200L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5356109135930076856L),

new System.Numerics.BigInteger(7947305613296537882L),

new System.Numerics.BigInteger(9141246405810452622L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1329558566248424322L),

new System.Numerics.BigInteger(5034217913778944993L),

new System.Numerics.BigInteger(7995339898389100327L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2769333176914462830L),

new System.Numerics.BigInteger(7324616115225499209L),

new System.Numerics.BigInteger(786688683253458515L),

new System.Numerics.BigInteger(1264200692730071671L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7851692244714932691L),

new System.Numerics.BigInteger(7672385717627814593L),

new System.Numerics.BigInteger(6851676944062888766L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4756048303812398477L),

new System.Numerics.BigInteger(4507768534103933337L),

new System.Numerics.BigInteger(2417850480124287873L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1357178323615534966L),

new System.Numerics.BigInteger(6071959321278302184L),

new System.Numerics.BigInteger(4987523592863136196L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3743635936262673362L),

new System.Numerics.BigInteger(5554380351973037409L),

new System.Numerics.BigInteger(7341306018355447994L),

new System.Numerics.BigInteger(8462065072412694724L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(75885430217214052L),

new System.Numerics.BigInteger(426111025322844003L),

new System.Numerics.BigInteger(7189645788230032574L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5586258097378134630L),

new System.Numerics.BigInteger(8736537133248842960L),

new System.Numerics.BigInteger(3982881393333650919L),

new System.Numerics.BigInteger(6481856487910823469L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(610048437751440213L),

new System.Numerics.BigInteger(5931953163518530159L),

new System.Numerics.BigInteger(2493867733952807558L),

new System.Numerics.BigInteger(2765570798098422512L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6774118081109045759L),

new System.Numerics.BigInteger(862614021002948688L),

new System.Numerics.BigInteger(2646784344281741253L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6414351760674537411L),

new System.Numerics.BigInteger(782274282940221756L),

new System.Numerics.BigInteger(2848271853740156589L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(546649153605626811L),

new System.Numerics.BigInteger(4284338737211804167L),

new System.Numerics.BigInteger(5764292355969174827L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1799641292998664358L),

new System.Numerics.BigInteger(5672948708385132123L),

new System.Numerics.BigInteger(3133896248193542570L),

new System.Numerics.BigInteger(1926059253506690733L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1688136989710122912L),

new System.Numerics.BigInteger(544966231701535357L),

new System.Numerics.BigInteger(8838648640122549466L),

new System.Numerics.BigInteger(241291293916112527L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2032436470009781796L),

new System.Numerics.BigInteger(979983079176357876L),

new System.Numerics.BigInteger(9139193745922498497L),

new System.Numerics.BigInteger(4411828304548975199L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4411337669621647293L),

new System.Numerics.BigInteger(6635325916776616775L),

new System.Numerics.BigInteger(4057709722773618359L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2981724346442298012L),

new System.Numerics.BigInteger(4023167916478156853L),

new System.Numerics.BigInteger(8981544199641819050L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7839621411453882189L),

new System.Numerics.BigInteger(4640781909305256523L),

new System.Numerics.BigInteger(5718876916032902410L),

new System.Numerics.BigInteger(9060841386145390762L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1395368592246792742L),

new System.Numerics.BigInteger(479682438108203830L),

new System.Numerics.BigInteger(6350087785970076568L),

new System.Numerics.BigInteger(3097569720241178525L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2880094993776506452L),

new System.Numerics.BigInteger(7194604012389813994L),

new System.Numerics.BigInteger(1974132163234152406L),

new System.Numerics.BigInteger(6485455769412572465L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3550469436341926828L),

new System.Numerics.BigInteger(1990819970476002999L),

new System.Numerics.BigInteger(8473857471728877424L),

new System.Numerics.BigInteger(4467594270598893801L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3479584332154646299L),

new System.Numerics.BigInteger(507201115702460228L),

new System.Numerics.BigInteger(6700025321575057223L),

new System.Numerics.BigInteger(7126985883334705386L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1830864967051207874L),

new System.Numerics.BigInteger(2143075833847976635L),

new System.Numerics.BigInteger(7640606970219490995L),

new System.Numerics.BigInteger(2776868980931056852L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4327828730365212349L),

new System.Numerics.BigInteger(3891223318810867019L),

new System.Numerics.BigInteger(3097649880323762040L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3789355854024665522L),

new System.Numerics.BigInteger(6938175882390724364L),

new System.Numerics.BigInteger(236943591410898720L),

new System.Numerics.BigInteger(7823373057378442416L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3936064935269993010L),

new System.Numerics.BigInteger(2149205351919316624L),

new System.Numerics.BigInteger(6320435817201882034L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7147018817631916536L),

new System.Numerics.BigInteger(4098103946548542982L),

new System.Numerics.BigInteger(6712991032818203755L),

new System.Numerics.BigInteger(6548524559634140294L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(569353252464250353L),

new System.Numerics.BigInteger(2263552623551753431L),

new System.Numerics.BigInteger(5410348920867293095L),

new System.Numerics.BigInteger(3511070236345364763L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3650102740001172640L),

new System.Numerics.BigInteger(322214145944445576L),

new System.Numerics.BigInteger(4282712179030427502L),

new System.Numerics.BigInteger(5952218222802932578L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(438666746254975710L),

new System.Numerics.BigInteger(2571940159963345350L),

new System.Numerics.BigInteger(5098693392519870115L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7481256423131289855L),

new System.Numerics.BigInteger(2987658880663909602L),

new System.Numerics.BigInteger(4165981409004496661L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8791088529316978164L),

new System.Numerics.BigInteger(116683062101208248L),

new System.Numerics.BigInteger(5458638975743881787L),

new System.Numerics.BigInteger(1380593572871369894L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1138410262013763388L),

new System.Numerics.BigInteger(8851849586069218298L),

new System.Numerics.BigInteger(3796163494626864193L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3841299428576246544L),

new System.Numerics.BigInteger(7029515447001014463L),

new System.Numerics.BigInteger(6072449215341162080L),

new System.Numerics.BigInteger(7953636918047688349L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(60582294193166447L),

new System.Numerics.BigInteger(4227219902240235294L),

new System.Numerics.BigInteger(6977904795814489082L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4511888268563498778L),

new System.Numerics.BigInteger(1303280782333460572L),

new System.Numerics.BigInteger(2649643015532592285L),

new System.Numerics.BigInteger(8355014889306222417L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4897464017636384334L),

new System.Numerics.BigInteger(5915107996387742459L),

new System.Numerics.BigInteger(6478788396742708827L),

new System.Numerics.BigInteger(3799880418882289675L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8209095403408440388L),

new System.Numerics.BigInteger(1850077419276455640L),

new System.Numerics.BigInteger(7214177965301096276L),

new System.Numerics.BigInteger(1671060618104126859L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4589760912804478371L),

new System.Numerics.BigInteger(1027548388354171244L),

new System.Numerics.BigInteger(6862024451102419824L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3894718394447634839L),

new System.Numerics.BigInteger(1723221630311729240L),

new System.Numerics.BigInteger(1385200544407322685L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6198481844411991233L),

new System.Numerics.BigInteger(5627563029832503734L),

new System.Numerics.BigInteger(8116281198560542140L),

new System.Numerics.BigInteger(72982185480348538L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2983388166630826208L),

new System.Numerics.BigInteger(86901313905760612L),

new System.Numerics.BigInteger(4603150686812235520L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2759883522982778813L),

new System.Numerics.BigInteger(722922850426702188L),

new System.Numerics.BigInteger(4262563688129157804L),

new System.Numerics.BigInteger(2614804159540829828L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7927345074749243845L),

new System.Numerics.BigInteger(7682642751783064486L),

new System.Numerics.BigInteger(6388009412842605327L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(528710510685669356L),

new System.Numerics.BigInteger(1880866648784170663L),

new System.Numerics.BigInteger(8122776223494607580L),

new System.Numerics.BigInteger(6002286117551609669L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2977274795958499774L),

new System.Numerics.BigInteger(6190528788679372003L),

new System.Numerics.BigInteger(7662100835489217031L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8871396164429323904L),

new System.Numerics.BigInteger(4118670878070969059L),

new System.Numerics.BigInteger(4329321238857093800L),

new System.Numerics.BigInteger(66666346242233568L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1950423613293736032L),

new System.Numerics.BigInteger(5098891666380270417L),

new System.Numerics.BigInteger(8907939740792260909L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3974079259785350505L),

new System.Numerics.BigInteger(2190223885629796965L),

new System.Numerics.BigInteger(8298741048373884585L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1752926561681036035L),

new System.Numerics.BigInteger(8131833236608454548L),

new System.Numerics.BigInteger(5842906559393288502L),

new System.Numerics.BigInteger(8405807978766869801L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4092711942935482072L),

new System.Numerics.BigInteger(1626806830413620606L),

new System.Numerics.BigInteger(3398416383727392945L),

new System.Numerics.BigInteger(7160897094529660963L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2182146564622193952L),

new System.Numerics.BigInteger(4010419408905506744L),

new System.Numerics.BigInteger(6617013478442014364L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1363448809450451117L),

new System.Numerics.BigInteger(3434463735899434216L),

new System.Numerics.BigInteger(6832095540785871908L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1210360010641097763L),

new System.Numerics.BigInteger(9134675704327177669L),

new System.Numerics.BigInteger(814710214184289110L),

new System.Numerics.BigInteger(6192683111348953114L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(209230682191928885L),

new System.Numerics.BigInteger(4014126223147138076L),

new System.Numerics.BigInteger(3297502884335968335L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7533741995269895484L),

new System.Numerics.BigInteger(6314448850898792916L),

new System.Numerics.BigInteger(8449139486519036476L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5863055636025689963L),

new System.Numerics.BigInteger(6066318527616107139L),

new System.Numerics.BigInteger(6048201914516990626L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6226660589943370734L),

new System.Numerics.BigInteger(6316803261692685983L),

new System.Numerics.BigInteger(1214963460663948902L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7114389758040293287L),

new System.Numerics.BigInteger(3295686013840747408L),

new System.Numerics.BigInteger(1142547627578239687L),

new System.Numerics.BigInteger(6568992724687266801L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5230924934587832450L),

new System.Numerics.BigInteger(420554410745927246L),

new System.Numerics.BigInteger(289257926276594396L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4808206500673217637L),

new System.Numerics.BigInteger(3089019222476766750L),

new System.Numerics.BigInteger(1500560035142104862L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793832711580381816L),

new System.Numerics.BigInteger(2907447840540630627L),

new System.Numerics.BigInteger(2435806574605992282L),

new System.Numerics.BigInteger(8481526369968668927L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(481710901141469831L),

new System.Numerics.BigInteger(1358160985042809023L),

new System.Numerics.BigInteger(2381235838731201355L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1138197771467998001L),

new System.Numerics.BigInteger(4083834706407189221L),

new System.Numerics.BigInteger(1061431391960990623L),

new System.Numerics.BigInteger(5868415658244272713L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6831274845848484724L),

new System.Numerics.BigInteger(4522259095190528071L),

new System.Numerics.BigInteger(8223555151003278680L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7109095938871565057L),

new System.Numerics.BigInteger(4822229895356994642L),

new System.Numerics.BigInteger(6661213866154837719L),

new System.Numerics.BigInteger(176471126740758719L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5657570027184042790L),

new System.Numerics.BigInteger(5274577523436174032L),

new System.Numerics.BigInteger(7670127772023119767L),

new System.Numerics.BigInteger(5604563794207627399L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1659102132194483808L),

new System.Numerics.BigInteger(2831825849139934191L),

new System.Numerics.BigInteger(1985121697269466560L),

new System.Numerics.BigInteger(1081891105839949446L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1160075701303238910L),

new System.Numerics.BigInteger(1112659531762310756L),

new System.Numerics.BigInteger(7769960634417724882L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4489959671261701990L),

new System.Numerics.BigInteger(484287511167594004L),

new System.Numerics.BigInteger(7727846187016430706L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2208898622180559643L),

new System.Numerics.BigInteger(3646178668933491971L),

new System.Numerics.BigInteger(5760984854896583284L),

new System.Numerics.BigInteger(2907704243759709694L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9210943780005762498L),

new System.Numerics.BigInteger(5608029896413369048L),

new System.Numerics.BigInteger(2275507381523274401L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8499920403406437522L),

new System.Numerics.BigInteger(7742917949034226588L),

new System.Numerics.BigInteger(1977589038478938919L),

new System.Numerics.BigInteger(3190379844788577891L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5125841420310417198L),

new System.Numerics.BigInteger(5550652606601435833L),

new System.Numerics.BigInteger(618292458963995805L),

new System.Numerics.BigInteger(8990790390326535310L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(449707573147629873L),

new System.Numerics.BigInteger(323262208302471501L),

new System.Numerics.BigInteger(3668799009142981580L),

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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 182, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 163, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 117, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 163, 10))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[1], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[2], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[3], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[4], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[5], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[6], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[7], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[8], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[9], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[10], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[11], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[12], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[13], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[14], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[15], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[19],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[20],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[21],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[22],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[23],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[24],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[25],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[26],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[27],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[28],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[29],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[30],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[31],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[32],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[33],_testData[34], false);
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

