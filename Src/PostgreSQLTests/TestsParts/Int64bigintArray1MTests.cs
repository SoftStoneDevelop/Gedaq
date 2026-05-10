

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 6,
    Value = 
new System.Int64[3]
{
7192378294776066228L,
4344463952276338771L,
7387867529775588659L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4280794043718181084L,
3311435868620814792L,
3439728702613991709L,
},
},
            new Int64bigintArray1M
{
    Id = 10,
    Value = 
new System.Int64[4]
{
3943435313740776768L,
6254516171137950212L,
8580325497530948652L,
4382838602936582099L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
9040923634028547129L,
6195856228545996727L,
862951763083948912L,
4411826705226141141L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[4]
{
5971594183831773138L,
7298530199431577506L,
4611745313832466668L,
8712362060482256287L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 24,
    Value = 
new System.Int64[3]
{
7814134203413777937L,
3628414385816447265L,
2715528422683306314L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 6,
    Value = 
new System.Int64[4]
{
6087836676262766996L,
2631272526661425335L,
4694873441669121990L,
5547784621783506015L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4120954226453356817L,
6017153836099186350L,
7918042171117106098L,
},
},
            new Int64bigintArray1M
{
    Id = 30,
    Value = 
new System.Int64[3]
{
3322085402640908986L,
5196808991653202865L,
142740740374988375L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
893546656349008181L,
3678883775155903267L,
4870863006044996079L,
},
},
            new Int64bigintArray1M
{
    Id = 32,
    Value = 
new System.Int64[3]
{
7514280938142627270L,
8828640888325667392L,
5215767093864020471L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 13,
    Value = 
new System.Int64[3]
{
88701226550412590L,
2906524203131914049L,
5253061477923077691L,
},
    NullableValue = 
new System.Int64[4]
{
5958429048584813001L,
6199246332734162374L,
8751006116743615109L,
3194808616758044580L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 40,
    Value = 
new System.Int64[3]
{
8760284922693760736L,
3540669899154771374L,
5804852343110532857L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
8698716578256620714L,
88050737071488329L,
7513703630073701288L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 14,
    Value = 
new System.Int64[3]
{
6665039230482026937L,
5119226115769652841L,
7879674147333875043L,
},
    NullableValue = 
new System.Int64[4]
{
8482295215053652764L,
2829253974796715376L,
6123537193369433587L,
8505955485735680709L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 56,
    Value = 
new System.Int64[4]
{
3807968658600147469L,
8313574624028896553L,
7584791270289649200L,
5364973548340231044L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 59,
    Value = 
new System.Int64[4]
{
9143612820101849032L,
2156251967997346617L,
347242555290924802L,
9066069439650341679L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 16,
    Value = 
new System.Int64[4]
{
6518742278256751977L,
1488818732061680864L,
4382577792302691428L,
7970375667628537364L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4098309142001334078L,
1160596728998542177L,
4081101476632508071L,
7872603250572616804L,
},
},
            new Int64bigintArray1M
{
    Id = 68,
    Value = 
new System.Int64[4]
{
2551477348868120260L,
8417121887431292854L,
7115464164587941672L,
8254351030956947758L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[3]
{
894260525072365677L,
3232019653846934154L,
2296483857944438351L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
7082382749981053793L,
8714864306090280339L,
104517594449016516L,
1516456850093901253L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 83,
    Value = 
new System.Int64[4]
{
79671360073211336L,
2706142064532383278L,
4706239851623081567L,
1366527781594005034L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 85,
    Value = 
new System.Int64[3]
{
7687669496631863364L,
5186357552385337152L,
5659313050399394160L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 29,
    Value = 
new System.Int64[3]
{
8626400595953972518L,
928120722893905964L,
6340866184357500321L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7640522278457542349L,
2416365245706648430L,
1578582795359635903L,
},
},
            new Int64bigintArray1M
{
    Id = 89,
    Value = 
new System.Int64[3]
{
119493841445032921L,
4213906191616022835L,
195468849369175722L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
128500262883865129L,
7569959063203747670L,
6936626385494715773L,
4886066358332387209L,
},
},
            new Int64bigintArray1M
{
    Id = 97,
    Value = 
new System.Int64[3]
{
4984644450997466957L,
3076584073312456344L,
1534822853750521198L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 31,
    Value = 
new System.Int64[4]
{
7945629698176749928L,
4388871436684820130L,
3357387596639617334L,
7145443298928993360L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 102,
    Value = 
new System.Int64[4]
{
2474462726215877613L,
5305492562084417381L,
5231627650732814573L,
3692195731078615418L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 110,
    Value = 
new System.Int64[4]
{
8852315865276280160L,
393284012010406835L,
4900599273832214151L,
5400171081342605383L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[4]
{
5591288196489272255L,
6953940955707673001L,
2533462448787511830L,
4849552855367030775L,
},
    NullableValue = 
new System.Int64[4]
{
2476136924300790058L,
2647463909761152966L,
5206674500135860423L,
2862721057782222615L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 114,
    Value = 
new System.Int64[4]
{
8262658606551303266L,
7552277946378499606L,
8591983816129723133L,
6203984916740822989L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 120,
    Value = 
new System.Int64[4]
{
3481267010336689023L,
5553771303396478885L,
6439977148778881712L,
2899047662748139095L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
613068298696439178L,
5910674143446009442L,
6067581847878656223L,
3849760707873155005L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2808478417639034666L,
2362861104057156300L,
8254702672428924893L,
5861399126827437417L,
},
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
9065828568429767508L,
1555564528863723795L,
7837378247273435067L,
4467478158350586363L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
2593540724832469900L,
6659687783764433200L,
3030302215377229179L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 48,
    Value = 
new System.Int64[3]
{
6546170106715381848L,
8037195042944989611L,
4803426041463301145L,
},
    NullableValue = 
new System.Int64[3]
{
8327154772348227131L,
7643500287952096540L,
1383951458401285585L,
},
},
    NullableValue = 
new System.Int64[4]
{
3682769247346138291L,
9194070833527048194L,
4024542976522480607L,
8419857423344673886L,
},
},
            new Int64bigintArray1M
{
    Id = 135,
    Value = 
new System.Int64[4]
{
5204118258112920998L,
4841498712955242122L,
843248108642620515L,
6741072639318397321L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 138,
    Value = 
new System.Int64[3]
{
8481830026676688747L,
2243571101761077308L,
1075884687693885267L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
6335846080267170607L,
3281971080583220786L,
4024910468969684454L,
1462039598628273600L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8546839451902592967L,
7288570540357741299L,
610397125572476700L,
},
},
            new Int64bigintArray1M
{
    Id = 146,
    Value = 
new System.Int64[3]
{
1346965323991194741L,
8082414405336964388L,
3136069851941997127L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1155325435027864679L,
1754080714127217504L,
321875311810363978L,
},
},
            new Int64bigintArray1M
{
    Id = 151,
    Value = 
new System.Int64[3]
{
7471353797163734975L,
1107107712758259823L,
3957822624936379653L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 62,
    Value = 
new System.Int64[3]
{
7112653289162284381L,
248148621349272028L,
8208277022936020767L,
},
    NullableValue = 
new System.Int64[4]
{
1561282587529908504L,
4297350817097696494L,
6685924506602261386L,
7073299694725736233L,
},
},
    NullableValue = 
new System.Int64[3]
{
5426011886719326600L,
8768634389799112320L,
4349888752274884551L,
},
},
            new Int64bigintArray1M
{
    Id = 154,
    Value = 
new System.Int64[3]
{
5380474107395019044L,
6805659470262744697L,
4257467354144594962L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5334985731178275102L,
2216709756036400237L,
6283576997239081122L,
},
},
            new Int64bigintArray1M
{
    Id = 160,
    Value = 
new System.Int64[3]
{
1706866762250293830L,
6897678525317256405L,
1959356535966721466L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 70,
    Value = 
new System.Int64[3]
{
8151279937090644440L,
2966049325060395576L,
5224281967989145169L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
9072900480493771602L,
24576867617852876L,
1930682160365736584L,
},
},
            new Int64bigintArray1M
{
    Id = 164,
    Value = 
new System.Int64[4]
{
5564571583440439230L,
4861313038148752862L,
3215749916522183206L,
3229599178121908739L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 167,
    Value = 
new System.Int64[3]
{
1010110106099832270L,
5251797871536195271L,
6678370491735902454L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
185330120216468849L,
2418963971792982656L,
7987374390616926011L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 170,
    Value = 
new System.Int64[3]
{
4076205776430451506L,
3931136540273445986L,
4871499043358991445L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 172,
    Value = 
new System.Int64[4]
{
6026430440656499906L,
4332977003232469674L,
661602477123833906L,
2460181895970982796L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 78,
    Value = 
new System.Int64[4]
{
8658561321335892321L,
8696931610276534788L,
1234203520391243029L,
4661524861480898425L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
6085322044076526899L,
8559718041739987457L,
3642787953642942679L,
},
},
            new Int64bigintArray1M
{
    Id = 174,
    Value = 
new System.Int64[3]
{
6217320745453249367L,
731987333901714841L,
8982931806916161366L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 183,
    Value = 
new System.Int64[3]
{
1046829190454187378L,
1329889140840238404L,
7886344266038589611L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 87,
    Value = 
new System.Int64[4]
{
5385975576939438980L,
6242430343617093015L,
4891901313907360964L,
1025025729050823044L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 184,
    Value = 
new System.Int64[4]
{
2266054974424634089L,
5629548119467973653L,
2871223457208008063L,
1819112651326555396L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8671512747677141266L,
928172263632010510L,
86516843889038843L,
8763274994703024465L,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
893546656349008181L,
3678883775155903267L,
4870863006044996079L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4098309142001334078L,
1160596728998542177L,
4081101476632508071L,
7872603250572616804L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigintArray1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 135, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 114, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 120, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 135, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Int64bigintArray1M.AssertModel(models[0],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int64bigintArray1M.AssertModel(models[0],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[30],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[31],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[32],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

