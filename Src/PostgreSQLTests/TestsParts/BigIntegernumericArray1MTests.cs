

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4564863784694410550L),
new System.Numerics.BigInteger(199133640670160684L),
new System.Numerics.BigInteger(8399063745134567376L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4622386231794096217L),
new System.Numerics.BigInteger(1723980366769335191L),
new System.Numerics.BigInteger(6818236781373269270L),
new System.Numerics.BigInteger(5505819485161383686L),
},
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4869847935291213867L),
new System.Numerics.BigInteger(6342182045495505344L),
new System.Numerics.BigInteger(1303814116274707654L),
new System.Numerics.BigInteger(5425366781473665297L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6993742955651336208L),
new System.Numerics.BigInteger(8947599507437553450L),
new System.Numerics.BigInteger(681386154115927547L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4296903914235611900L),
new System.Numerics.BigInteger(6876684826734500479L),
new System.Numerics.BigInteger(5184726495990523044L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4453801843376583783L),
new System.Numerics.BigInteger(3891359751268013313L),
new System.Numerics.BigInteger(6961992087967362904L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(381973603399148022L),
new System.Numerics.BigInteger(2325831524805909348L),
new System.Numerics.BigInteger(422317340591134286L),
new System.Numerics.BigInteger(5848081108105736450L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8263602237565231340L),
new System.Numerics.BigInteger(7680099757195143816L),
new System.Numerics.BigInteger(5125910006997196856L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6943761148211873574L),
new System.Numerics.BigInteger(6445223876679970655L),
new System.Numerics.BigInteger(5669498289982892016L),
new System.Numerics.BigInteger(1165852195601380979L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7186307421170155711L),
new System.Numerics.BigInteger(514714269156731116L),
new System.Numerics.BigInteger(1653287661803724691L),
new System.Numerics.BigInteger(6162304183749091684L),
},
},
            new BigIntegernumericArray1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3837392530401212934L),
new System.Numerics.BigInteger(8975616418825376988L),
new System.Numerics.BigInteger(1925350683014107039L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6603513614969293057L),
new System.Numerics.BigInteger(3401186197391773797L),
new System.Numerics.BigInteger(4914500115256296872L),
new System.Numerics.BigInteger(6963797666863743158L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(559139462020931758L),
new System.Numerics.BigInteger(5863008170046808156L),
new System.Numerics.BigInteger(5932041353895058800L),
new System.Numerics.BigInteger(2864069365179376746L),
},
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2328338735110983295L),
new System.Numerics.BigInteger(7915809848478530546L),
new System.Numerics.BigInteger(8809325107547911963L),
new System.Numerics.BigInteger(5330054731335071272L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8674029870104499934L),
new System.Numerics.BigInteger(4249567724139056234L),
new System.Numerics.BigInteger(7587935956928850355L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7666294762892351145L),
new System.Numerics.BigInteger(5333215290836665656L),
new System.Numerics.BigInteger(2041361109505359980L),
new System.Numerics.BigInteger(3068617836983824684L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8113525665622109790L),
new System.Numerics.BigInteger(8278516287242612855L),
new System.Numerics.BigInteger(7460858899403435021L),
new System.Numerics.BigInteger(1948611727989875818L),
},
},
            new BigIntegernumericArray1M
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3448709700171114317L),
new System.Numerics.BigInteger(4543510288800860019L),
new System.Numerics.BigInteger(2870586272383831428L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4430772745521111830L),
new System.Numerics.BigInteger(4810188917987551478L),
new System.Numerics.BigInteger(8374310676453585626L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(933551735383810012L),
new System.Numerics.BigInteger(5159205361947362988L),
new System.Numerics.BigInteger(1575180527948629259L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3181973610261026109L),
new System.Numerics.BigInteger(7974496283369924380L),
new System.Numerics.BigInteger(2402881045789892206L),
new System.Numerics.BigInteger(8146565812179728637L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8443973452483816315L),
new System.Numerics.BigInteger(721100111555355293L),
new System.Numerics.BigInteger(8634824973312139467L),
new System.Numerics.BigInteger(5086240460575380371L),
},
},
            new BigIntegernumericArray1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2162170187248325314L),
new System.Numerics.BigInteger(5888434233171425071L),
new System.Numerics.BigInteger(2581330341312412704L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7260190946175059615L),
new System.Numerics.BigInteger(3587834390239098708L),
new System.Numerics.BigInteger(8163317148852037840L),
},
},
            new BigIntegernumericArray1M
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5968346568568688451L),
new System.Numerics.BigInteger(7322200511801961735L),
new System.Numerics.BigInteger(8784465647229359655L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1289270694083608250L),
new System.Numerics.BigInteger(5989865999064027682L),
new System.Numerics.BigInteger(1997210805016996772L),
new System.Numerics.BigInteger(5468184777954715481L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7669640836675561866L),
new System.Numerics.BigInteger(4125029226475914890L),
new System.Numerics.BigInteger(6975651072886451938L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1666233514581414138L),
new System.Numerics.BigInteger(8001201251951627308L),
new System.Numerics.BigInteger(7904789964844975125L),
new System.Numerics.BigInteger(2073535002814002299L),
},
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3069580067220816896L),
new System.Numerics.BigInteger(3050884142860369458L),
new System.Numerics.BigInteger(3953040719432541977L),
new System.Numerics.BigInteger(1870270724340008602L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8681957459176205842L),
new System.Numerics.BigInteger(3528883827922304962L),
new System.Numerics.BigInteger(5517021501457353183L),
new System.Numerics.BigInteger(6165424032268587179L),
},
},
            new BigIntegernumericArray1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6943551876298562602L),
new System.Numerics.BigInteger(2060308151144064370L),
new System.Numerics.BigInteger(9118594332165059855L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4490354767984437757L),
new System.Numerics.BigInteger(7579859942023480280L),
new System.Numerics.BigInteger(4332608207562571030L),
new System.Numerics.BigInteger(3407858934674747896L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3669968701660524681L),
new System.Numerics.BigInteger(6322789668152084871L),
new System.Numerics.BigInteger(6022327484184322392L),
new System.Numerics.BigInteger(3997386998981209136L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(583946486555755291L),
new System.Numerics.BigInteger(7839164900712281970L),
new System.Numerics.BigInteger(9004956249113296966L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 89,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8816226432431489396L),
new System.Numerics.BigInteger(1489659288482814887L),
new System.Numerics.BigInteger(1172390409182763097L),
new System.Numerics.BigInteger(7745862477998199780L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1545775941061002873L),
new System.Numerics.BigInteger(5709935187471255735L),
new System.Numerics.BigInteger(666536672872051116L),
new System.Numerics.BigInteger(7680889093442069237L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8900330537004314085L),
new System.Numerics.BigInteger(5811714035870535191L),
new System.Numerics.BigInteger(4250150240749212740L),
new System.Numerics.BigInteger(4504932119438519766L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6305295384994386670L),
new System.Numerics.BigInteger(7639218124628792106L),
new System.Numerics.BigInteger(6458086080788082753L),
new System.Numerics.BigInteger(6528307053683238789L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6728442774167226885L),
new System.Numerics.BigInteger(6570526445572357381L),
new System.Numerics.BigInteger(7443472629555041569L),
new System.Numerics.BigInteger(8873644669967982702L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6863074404617193727L),
new System.Numerics.BigInteger(1441326703668270327L),
new System.Numerics.BigInteger(5721213385205906318L),
new System.Numerics.BigInteger(3102047207830246884L),
},
},
            new BigIntegernumericArray1M
{
    Id = 98,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7136045973485817031L),
new System.Numerics.BigInteger(3939873324732099978L),
new System.Numerics.BigInteger(4157030136142704385L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8141955166889994250L),
new System.Numerics.BigInteger(8899610942530253374L),
new System.Numerics.BigInteger(5519381553229229423L),
new System.Numerics.BigInteger(6989519319186584754L),
},
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7576468077602330089L),
new System.Numerics.BigInteger(6617865338884867649L),
new System.Numerics.BigInteger(4804335560651637115L),
new System.Numerics.BigInteger(5464150011603419942L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3343998384494038739L),
new System.Numerics.BigInteger(3376662858400688738L),
new System.Numerics.BigInteger(4844205365977268464L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3811280887917500574L),
new System.Numerics.BigInteger(2847591165740303523L),
new System.Numerics.BigInteger(3895446730707639112L),
},
},
            new BigIntegernumericArray1M
{
    Id = 114,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8879770261911074991L),
new System.Numerics.BigInteger(7523023572515112033L),
new System.Numerics.BigInteger(4178253358749929407L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3967322261912298068L),
new System.Numerics.BigInteger(4324623163058143689L),
new System.Numerics.BigInteger(4441167238549359098L),
new System.Numerics.BigInteger(8673913687030939816L),
},
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4296375837744931211L),
new System.Numerics.BigInteger(2794661391113501121L),
new System.Numerics.BigInteger(4783979308367047215L),
new System.Numerics.BigInteger(3893862522266644756L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6421289018725424169L),
new System.Numerics.BigInteger(4190619405008620389L),
new System.Numerics.BigInteger(4878558930228397192L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3408879309586678993L),
new System.Numerics.BigInteger(6281190376705132207L),
new System.Numerics.BigInteger(2972273340898967541L),
new System.Numerics.BigInteger(6751902756236787131L),
},
},
            new BigIntegernumericArray1M
{
    Id = 124,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1242114216952777238L),
new System.Numerics.BigInteger(4377512357309037720L),
new System.Numerics.BigInteger(6011038090476629181L),
new System.Numerics.BigInteger(1933263611537584969L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5661634675462592635L),
new System.Numerics.BigInteger(8473080291964021760L),
new System.Numerics.BigInteger(6466791304098487452L),
new System.Numerics.BigInteger(3016242741838016379L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8053005765766040591L),
new System.Numerics.BigInteger(1292053781310452651L),
new System.Numerics.BigInteger(4023443125556382506L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3294622881176099441L),
new System.Numerics.BigInteger(580103391668314896L),
new System.Numerics.BigInteger(1534549840751737781L),
new System.Numerics.BigInteger(9009377207570036126L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8358789710853459211L),
new System.Numerics.BigInteger(6532812268508061708L),
new System.Numerics.BigInteger(2739958342192259722L),
new System.Numerics.BigInteger(4806287084254741716L),
},
},
            new BigIntegernumericArray1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2256426008482899920L),
new System.Numerics.BigInteger(5214319427369092132L),
new System.Numerics.BigInteger(8980862319902789163L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788980321099277843L),
new System.Numerics.BigInteger(7372498494123824479L),
new System.Numerics.BigInteger(6098408274207187015L),
new System.Numerics.BigInteger(8616774902826189494L),
},
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2367421444874758487L),
new System.Numerics.BigInteger(2849290690651420677L),
new System.Numerics.BigInteger(7765797834061211880L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4372546652956533088L),
new System.Numerics.BigInteger(1714861088079067111L),
new System.Numerics.BigInteger(5353138008789907882L),
new System.Numerics.BigInteger(3209533667603061070L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8302999885052243993L),
new System.Numerics.BigInteger(2326229111597387592L),
new System.Numerics.BigInteger(6749739810111662926L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6885461802714922119L),
new System.Numerics.BigInteger(7107851626405881225L),
new System.Numerics.BigInteger(3636617070828263442L),
new System.Numerics.BigInteger(4135654307612295230L),
},
},
            new BigIntegernumericArray1M
{
    Id = 159,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3588546506828847879L),
new System.Numerics.BigInteger(6455921672436837630L),
new System.Numerics.BigInteger(5931815904191191077L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2077645646614221641L),
new System.Numerics.BigInteger(6101459904139427551L),
new System.Numerics.BigInteger(1024358673944190256L),
},
},
            new BigIntegernumericArray1M
{
    Id = 161,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6941561258636826811L),
new System.Numerics.BigInteger(5966691280319732443L),
new System.Numerics.BigInteger(953078505217492010L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(764718389872579561L),
new System.Numerics.BigInteger(2826439472683239221L),
new System.Numerics.BigInteger(7170901060069423652L),
new System.Numerics.BigInteger(7256591675907568228L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 162,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7024711859367648313L),
new System.Numerics.BigInteger(8553898412957077180L),
new System.Numerics.BigInteger(443466656489710339L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6831344740014012579L),
new System.Numerics.BigInteger(7043515234102485385L),
new System.Numerics.BigInteger(3216177509870720251L),
new System.Numerics.BigInteger(3245997561084959014L),
},
},
            new BigIntegernumericArray1M
{
    Id = 167,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5433855946020945070L),
new System.Numerics.BigInteger(5924141184389916867L),
new System.Numerics.BigInteger(5501167657615204231L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(144793702694461060L),
new System.Numerics.BigInteger(337012313783746657L),
new System.Numerics.BigInteger(8198988773326415234L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5428488019934365195L),
new System.Numerics.BigInteger(5902711151314129579L),
new System.Numerics.BigInteger(8192629858005473782L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9004330395705503952L),
new System.Numerics.BigInteger(4314958438018971805L),
new System.Numerics.BigInteger(5254945722382487885L),
},
},
            new BigIntegernumericArray1M
{
    Id = 181,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1418575299270622088L),
new System.Numerics.BigInteger(8404157397769581817L),
new System.Numerics.BigInteger(1464896427582377461L),
new System.Numerics.BigInteger(8741935584233234970L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5544262820448174900L),
new System.Numerics.BigInteger(5349381316657380673L),
new System.Numerics.BigInteger(829402323032289568L),
new System.Numerics.BigInteger(1539253300661941501L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5311275756861237953L),
new System.Numerics.BigInteger(2135187685406681157L),
new System.Numerics.BigInteger(772802731063839072L),
new System.Numerics.BigInteger(520365277543799077L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 183,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5360583282085976222L),
new System.Numerics.BigInteger(3799258234353027035L),
new System.Numerics.BigInteger(699480202601319066L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8290872045146159989L),
new System.Numerics.BigInteger(1843877622671380074L),
new System.Numerics.BigInteger(8784730502354012326L),
new System.Numerics.BigInteger(3610031272276134229L),
},
},
            new BigIntegernumericArray1M
{
    Id = 188,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7265632010758048920L),
new System.Numerics.BigInteger(8715834252963027770L),
new System.Numerics.BigInteger(8406872586865060113L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6634774766224006560L),
new System.Numerics.BigInteger(6879108727535958062L),
new System.Numerics.BigInteger(1332168533696744771L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3086659844275324977L),
new System.Numerics.BigInteger(9204501165480484821L),
new System.Numerics.BigInteger(8074918296999374531L),
new System.Numerics.BigInteger(989889422657031667L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 195,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2096891871836926927L),
new System.Numerics.BigInteger(4138873463108809237L),
new System.Numerics.BigInteger(871171123317259905L),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 89;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 174, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 181))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 162, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

