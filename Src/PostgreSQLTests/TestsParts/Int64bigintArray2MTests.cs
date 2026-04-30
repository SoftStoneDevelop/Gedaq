

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
    internal partial interface IInt64ListbigintArray
    {
    }
    
    internal partial class Int64ListbigintArray : IInt64ListbigintArray
    {


#region TestData

        private readonly Int64bigintArray2M[] _testData = new Int64bigintArray2M[]
        {
            new Int64bigintArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8992155041907563188L,

1273309305048502633L,

7134617116034379133L,

8310639226301852740L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4437033807760446551L,

4777235502115716873L,

8973846397966424007L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7630534329798648891L,

3710134801291022847L,

5379062798973639314L,

8149377477547352207L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7827406885965434606L,

6945312592783877175L,

7419566075040641101L,

5789940965050906386L,

},
},
            new Int64bigintArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
859551257697615371L,

4845905421905539526L,

2420020044224062009L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
772443380676173217L,

789113447786419475L,

7015590135636051310L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3151908950704629092L,

8198987538625674905L,

5861947881493792084L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4974686953011293347L,

5081310987622989909L,

7601306514277620782L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6219919873735009495L,

681446409043053668L,

6868108171640079895L,

},
},
            new Int64bigintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
548982463263674715L,

7331910334821774726L,

8609177740188181758L,

4484997389209276333L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
10519023223025431L,

3056473077420766004L,

6710402034397631234L,

9168133144818689124L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7307508101616458077L,

8488014539200434360L,

7573345234821906015L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4709561796717809487L,

2839982290575307919L,

2674700509160648981L,

8257985160097623447L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4664267273047397517L,

3092867186077529769L,

8732954251462441897L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3067222913346990574L,

722045815722132853L,

5252447203914602036L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7066354566597191396L,

486668537043320239L,

4523248444574077488L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2725312664800613686L,

367818434286751859L,

5155347378326244336L,

1043990331807973639L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9165677771602431154L,

4787345142339310608L,

3569854746333103011L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2033394647991447270L,

3733642249538590049L,

7016533237881218738L,

},
},
            new Int64bigintArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6601887425280543110L,

5293820686017532384L,

8308792095685028034L,

5507502771705662190L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5231107043351618958L,

8879902932976238604L,

7587584395092440089L,

2505753694779567260L,

},
},
            new Int64bigintArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
356434561318007199L,

4568867516418843708L,

4863796591220722137L,

6857718315335123674L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2936278517335757448L,

6777607592830837843L,

6658071066157863222L,

1802021267745546323L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4032357789342231005L,

8038142771819962394L,

2589347806533065301L,

460444278113034940L,

},
},
            new Int64bigintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8472326370797981023L,

7430048346180155078L,

5727814117922532888L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3463762432577815261L,

824889465464584796L,

4955633433492747558L,

},
},
            new Int64bigintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5248445360040403022L,

8661927836430632401L,

3970151288276922865L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7310929389263825482L,

1730637359364916663L,

4880693401114165333L,

9056059924916272747L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7560567604510221217L,

4657394009263249104L,

89931613517836411L,

44469742541573184L,

},
},
            new Int64bigintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6407735234230131654L,

8220399829324005324L,

4979501328857948723L,

6497355797182803599L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1585389215603210444L,

5051847643136106030L,

4262567294898445230L,

},
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5738737955703103966L,

5364581658093041593L,

7146622792954364540L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6233480653560759649L,

8637210335942802154L,

1866398970160180427L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5091215994839453367L,

2315426604962933977L,

8000449644641893345L,

5553769742098233476L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8911960579811771523L,

1683205751474126872L,

8218695336133930427L,

3688972689557115411L,

},
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7042268937151252110L,

1081252898188229278L,

9194930815097844063L,

3464512235322994374L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6428767037011484352L,

8423436870599205900L,

5582423472249081157L,

4752491257079303884L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6737327474819017150L,

6069396606025797213L,

3410820072451976137L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8573859633683712764L,

5534379224927884166L,

6453602079414362118L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4236994843102632251L,

3902608231637643971L,

3313883703418944885L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4629933244924064509L,

5452398643776096618L,

2597245257349660449L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
995327883127592188L,

8928253774812080110L,

3826568595904103690L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2295556134591208594L,

2670553925407615738L,

1537975296182918499L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8516888638058612274L,

252363499369009112L,

1164024370884034254L,

182563409927313435L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1816755781083670536L,

8931261555702176556L,

5712648007549304827L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3607380760509181388L,

2890413889390550360L,

2515578668059111826L,

8537651487682902841L,

},
},
            new Int64bigintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1129999833542371933L,

1795947529193263068L,

3895173669299295661L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7655453041070006082L,

4222856342959444437L,

778174535670497580L,

1384956673865532431L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3845345431526560337L,

835982988976937100L,

3321203730297973197L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4072758456547043984L,

3727457125775819169L,

3208914566407166352L,

1680262733921830342L,

},
},
            new Int64bigintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3335256191773290285L,

5856983052161526455L,

7816343600153743844L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7611117965272717077L,

5458374087435608109L,

4864050646813623993L,

},
},
            new Int64bigintArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8656098573640311828L,

7397575005561798266L,

603054297424695440L,

1117670715394922293L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6315236359149464469L,

5912169782276531359L,

7124268200264855104L,

7837617756787994263L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5153497318477077279L,

1684380584986833240L,

4582658894945931232L,

5569945322126294902L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7626348287407830085L,

2262518063103180899L,

5821772653748093613L,

3804751422961203654L,

},
},
            new Int64bigintArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2735805908363918827L,

6112853335934286420L,

964719728848120060L,

5045252053201988514L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6971056346768771751L,

696475080549978830L,

7157635348092842136L,

7154281348532403737L,

},
},
            new Int64bigintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7539308170344949808L,

7925789348057901093L,

4684545255049614851L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7352284427547736556L,

2727358641789688987L,

7440549004630415050L,

2694063284429928278L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8289783923007867851L,

2861989596891172510L,

7006078117807304767L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3743189058083993034L,

1801355477531939725L,

2434578713672292964L,

},
},
            new Int64bigintArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2982529012608744955L,

2327895577524094500L,

3128673712518709638L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7879182615859396062L,

9135122051885902135L,

523052947382340785L,

},
},
            new Int64bigintArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2199573019746040974L,

2960203026415862056L,

7561080022319340222L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2915713297624993016L,

7622996749396357611L,

3947475234296118104L,

1463315780217505236L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6254588654555709544L,

6638777847306122829L,

7855291390180708199L,

5115827174905921970L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6757880488784396344L,

5399838739264859943L,

6190120228622006902L,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
            asPartInterface: typeof(IInt64ListbigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                List<Int64bigintArray2M> models = null;

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintArray2M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray2M.AssertModel(models[0],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray2M.AssertModel(models[0],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 123, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 27, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 18, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 70, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 11, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 115, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintArray2M.AssertModel(models[0],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Int64bigintArray2M.AssertModel(models[0],_testData[22], false);Int64bigintArray2M.AssertModel(models[1],_testData[23], false);Int64bigintArray2M.AssertModel(models[2],_testData[24], false);Int64bigintArray2M.AssertModel(models[3],_testData[25], false);Int64bigintArray2M.AssertModel(models[4],_testData[26], false);Int64bigintArray2M.AssertModel(models[5],_testData[27], false);Int64bigintArray2M.AssertModel(models[6],_testData[28], false);Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Int64bigintArray2M.AssertModel(models[0],_testData[28], false);Int64bigintArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ListbigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                await ((IInt64ListbigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray2M),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
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
FROM public.binary_int64bigintarray2m m
LEFT JOIN public.binary_int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2M>(15);

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
                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray2M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray2M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ListbigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

