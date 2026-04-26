

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7005896197850794857L,

7843295395163617917L,

5205872302050188265L,

8093240228335810993L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6452239698763863885L,

5707219834576073181L,

838432448427041005L,

887667272341592953L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2741376285381105032L,

6136385615789765149L,

2902162783212998566L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3155088335697014820L,

416585083376313046L,

2441993103162913697L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8148061543836979317L,

4306455323195988551L,

1479689015071732487L,

},
},
            new Int64bigintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7988314245210768273L,

7989270539888780439L,

5626998200701795028L,

9095191673965873089L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8423149659582776389L,

1390485864948060388L,

276533140811814570L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3948083009448475451L,

4921244744816265367L,

2272322480084595234L,

9071002396144986186L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4007046606035736345L,

2980264733428014202L,

622791568136163972L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6065565974478115461L,

518706321789181491L,

8633296031622741693L,

1352787908768371021L,

},
},
            new Int64bigintArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5236534852791255283L,

8188450541514930410L,

2047917973756287510L,

3248092231295794822L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1527803885629826329L,

7127593988491063498L,

2929272808463633661L,

8339100396212198716L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3496217180406934050L,

3871945210950329913L,

926880316749494508L,

9133494529766925439L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6734296274866957387L,

4920032132745086377L,

7115607654063716383L,

7180000012753647244L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7807011416271564393L,

3620304336862039784L,

3046779774057399472L,

2004196925610236067L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4427399070012782999L,

7788171152136913166L,

5119624437390423794L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6257291669434506983L,

8560210116432956505L,

4490472027962550815L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5173998552357299820L,

6638338789267407836L,

8995912596024619283L,

},
},
            new Int64bigintArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3636608140465808431L,

8889802843009312304L,

8025648362708479119L,

1708707944086252804L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3802389443337356370L,

832597019980405532L,

8670206441870580153L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6383345461269892045L,

1758680810873469201L,

8332561602173278808L,

8610602697871379033L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3066341116576336438L,

5604217824040674485L,

1800127009070516165L,

9221175055399277378L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4730027093975803871L,

8283401500091890995L,

3364971539600731514L,

},
},
            new Int64bigintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5205217224183763708L,

5714822198119805216L,

2944542073102504713L,

6879651643705480507L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4960508969502176131L,

594652935499717635L,

2154426432275808642L,

8652136342495925041L,

},
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7050289151252349235L,

613937723832491096L,

3077073062457458807L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4766039154196682664L,

1207901289882467757L,

4014345386023742392L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8953517216488097822L,

6935173799413010497L,

590891772640838972L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4963039143034874823L,

8632913613259440686L,

844976634655452461L,

4604877521982624259L,

},
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4532551992376726935L,

7108105460830692105L,

2485684751576334371L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
227750219838870440L,

7889465179041134426L,

7599866168676681758L,

8978547018273798966L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9022326228514029301L,

1761571865080444390L,

5366701437077281870L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3751393081417265193L,

7064574633049979382L,

8796956781701335833L,

3055497714056846564L,

},
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5944666656511334024L,

7546175675996105702L,

3635235485291020415L,

3618337886610259765L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7094585767325098699L,

1254544623344820692L,

8239243703130736568L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4967976211807361496L,

3759693732665838571L,

5588562329391027923L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7160653357334296152L,

7585120249047197268L,

3808346197980210859L,

2299445251548569249L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8668876182966239377L,

9111903313945491530L,

8813751578610917426L,

748261753813854988L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5246754542263050720L,

193674679235417034L,

3985398810693020596L,

6083904610790285966L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3915803725830280397L,

4686454866907236363L,

8722340521699452226L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4240976796008957800L,

4460523081282677068L,

4612106162405987860L,

474497433226099455L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2424166510772276907L,

7308979506926592884L,

5127802417886811918L,

},
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4197483992711001438L,

8314820640970853674L,

1519606442891844379L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5467694941973150230L,

8936962967680243444L,

8761708621362527435L,

},
},
            new Int64bigintArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
319792339057368457L,

4319772073695216865L,

5546710066552034116L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5600287464424618163L,

5451089066239032293L,

3875147229592342863L,

1509869994077827597L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8122703607424569767L,

1271457716632531600L,

5793972266041254120L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5338650164198760888L,

7307732892627745586L,

1534185589864304534L,

},
},
            new Int64bigintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6891707065208997397L,

5749358258672668730L,

1111111481447181551L,

6149571347609636961L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1573124108066556616L,

1180329036458109182L,

8351712863811343713L,

6796759097116862624L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2522385908966887781L,

2476282781331097128L,

4620283278300805840L,

8621252652052747003L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
911096618794864303L,

6947673062656335364L,

3217689299194458077L,

4133515949228046746L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4096928802063027177L,

601725219022779025L,

3439239662066941927L,

},
},
            new Int64bigintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5166654129349251758L,

679090543159919884L,

4402797703396257433L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7015606060041114068L,

499587980008259192L,

1432361662674927064L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5614028396030047258L,

3278448400848358189L,

3678125033811848123L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5637255735203279995L,

652866249713997336L,

2133039461528707097L,

3538647915053737176L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5507856317837286539L,

5672413698833130141L,

1632318299691967021L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2002655230876877877L,

9018111689585043793L,

8364540875368686231L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7483666051158010234L,

1491287178615052960L,

8676204138474710605L,

},
},
            new Int64bigintArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3478138406777420662L,

6233756908971797010L,

3587567963819317063L,

1006778004738719543L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7153695670360674181L,

1182656618075259194L,

1771284059212352266L,

3407332082046543568L,

},
},
            new Int64bigintArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8331919909567918598L,

6660084256663155740L,

2297622669119286645L,

8000697198245201587L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5146369178912895958L,

7135185503282942909L,

6920113591059853719L,

9122216685811917717L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6868751628502368560L,

3229802824060188092L,

4249100256009993692L,

2507399895770181338L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7978433270454062983L,

3257690787341410005L,

4041414912458760982L,

8244210751699081911L,

},
},
            new Int64bigintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8934956704823711861L,

20392918749789702L,

5559005485345844486L,

1368170396483873403L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3123848086458771416L,

2764714578451343073L,

6197155765381813399L,

3540838905911770195L,

},
},
            new Int64bigintArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5788190595779524375L,

850231614114004289L,

4095802309433372744L,

5659144064220509845L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4452138670490134714L,

1387828360336090049L,

8090830842875254812L,

},
    NullableValue = null,
},
    NullableValue = null,
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt64ListbigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IInt64ListbigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt64ListbigintArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IInt64ListbigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[3], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[4], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[5], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[6], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[23],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[24],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[25],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[3], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[4], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[5], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[6], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[23],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[24],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[25],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[26],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray2M.AssertModel(models[0],_testData[20], false);Int64bigintArray2M.AssertModel(models[1],_testData[21], false);Int64bigintArray2M.AssertModel(models[2],_testData[22], false);Int64bigintArray2M.AssertModel(models[3],_testData[23], false);Int64bigintArray2M.AssertModel(models[4],_testData[24], false);Int64bigintArray2M.AssertModel(models[5],_testData[25], false);Int64bigintArray2M.AssertModel(models[6],_testData[26], false);Int64bigintArray2M.AssertModel(models[7],_testData[27], false);Int64bigintArray2M.AssertModel(models[8],_testData[28], false);Int64bigintArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
Int64bigintArray2M.AssertModel(models[0],_testData[18], false);Int64bigintArray2M.AssertModel(models[1],_testData[19], false);Int64bigintArray2M.AssertModel(models[2],_testData[20], false);Int64bigintArray2M.AssertModel(models[3],_testData[21], false);Int64bigintArray2M.AssertModel(models[4],_testData[22], false);Int64bigintArray2M.AssertModel(models[5],_testData[23], false);Int64bigintArray2M.AssertModel(models[6],_testData[24], false);Int64bigintArray2M.AssertModel(models[7],_testData[25], false);Int64bigintArray2M.AssertModel(models[8],_testData[26], false);Int64bigintArray2M.AssertModel(models[9],_testData[27], false);Int64bigintArray2M.AssertModel(models[10],_testData[28], false);Int64bigintArray2M.AssertModel(models[11],_testData[29], false);
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

                var models =  ((IInt64ListbigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
Int64bigintArray2M.AssertModel(models[0],_testData[3], false);Int64bigintArray2M.AssertModel(models[1],_testData[4], false);Int64bigintArray2M.AssertModel(models[2],_testData[5], false);Int64bigintArray2M.AssertModel(models[3],_testData[6], false);Int64bigintArray2M.AssertModel(models[4],_testData[7], false);Int64bigintArray2M.AssertModel(models[5],_testData[8], false);Int64bigintArray2M.AssertModel(models[6],_testData[9], false);Int64bigintArray2M.AssertModel(models[7],_testData[10], false);Int64bigintArray2M.AssertModel(models[8],_testData[11], false);Int64bigintArray2M.AssertModel(models[9],_testData[12], false);Int64bigintArray2M.AssertModel(models[10],_testData[13], false);Int64bigintArray2M.AssertModel(models[11],_testData[14], false);Int64bigintArray2M.AssertModel(models[12],_testData[15], false);Int64bigintArray2M.AssertModel(models[13],_testData[16], false);Int64bigintArray2M.AssertModel(models[14],_testData[17], false);Int64bigintArray2M.AssertModel(models[15],_testData[18], false);Int64bigintArray2M.AssertModel(models[16],_testData[19], false);Int64bigintArray2M.AssertModel(models[17],_testData[20], false);Int64bigintArray2M.AssertModel(models[18],_testData[21], false);Int64bigintArray2M.AssertModel(models[19],_testData[22], false);Int64bigintArray2M.AssertModel(models[20],_testData[23], false);Int64bigintArray2M.AssertModel(models[21],_testData[24], false);Int64bigintArray2M.AssertModel(models[22],_testData[25], false);Int64bigintArray2M.AssertModel(models[23],_testData[26], false);Int64bigintArray2M.AssertModel(models[24],_testData[27], false);Int64bigintArray2M.AssertModel(models[25],_testData[28], false);Int64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Int64bigintArray2M.AssertModel(models[0],_testData[23], false);Int64bigintArray2M.AssertModel(models[1],_testData[24], false);Int64bigintArray2M.AssertModel(models[2],_testData[25], false);Int64bigintArray2M.AssertModel(models[3],_testData[26], false);Int64bigintArray2M.AssertModel(models[4],_testData[27], false);Int64bigintArray2M.AssertModel(models[5],_testData[28], false);Int64bigintArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
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
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 51, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelBatchAsync(connection, 131, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Int64bigintArray2M.AssertModel(models[0],_testData[28], false);Int64bigintArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Int64bigintArray2M.AssertModel(models[0],_testData[19], false);Int64bigintArray2M.AssertModel(models[1],_testData[20], false);Int64bigintArray2M.AssertModel(models[2],_testData[21], false);Int64bigintArray2M.AssertModel(models[3],_testData[22], false);Int64bigintArray2M.AssertModel(models[4],_testData[23], false);Int64bigintArray2M.AssertModel(models[5],_testData[24], false);Int64bigintArray2M.AssertModel(models[6],_testData[25], false);Int64bigintArray2M.AssertModel(models[7],_testData[26], false);Int64bigintArray2M.AssertModel(models[8],_testData[27], false);Int64bigintArray2M.AssertModel(models[9],_testData[28], false);Int64bigintArray2M.AssertModel(models[10],_testData[29], false);
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
                var models =  ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelBatch(connection, 15, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Int64bigintArray2M.AssertModel(models[0],_testData[4], false);Int64bigintArray2M.AssertModel(models[1],_testData[5], false);Int64bigintArray2M.AssertModel(models[2],_testData[6], false);Int64bigintArray2M.AssertModel(models[3],_testData[7], false);Int64bigintArray2M.AssertModel(models[4],_testData[8], false);Int64bigintArray2M.AssertModel(models[5],_testData[9], false);Int64bigintArray2M.AssertModel(models[6],_testData[10], false);Int64bigintArray2M.AssertModel(models[7],_testData[11], false);Int64bigintArray2M.AssertModel(models[8],_testData[12], false);Int64bigintArray2M.AssertModel(models[9],_testData[13], false);Int64bigintArray2M.AssertModel(models[10],_testData[14], false);Int64bigintArray2M.AssertModel(models[11],_testData[15], false);Int64bigintArray2M.AssertModel(models[12],_testData[16], false);Int64bigintArray2M.AssertModel(models[13],_testData[17], false);Int64bigintArray2M.AssertModel(models[14],_testData[18], false);Int64bigintArray2M.AssertModel(models[15],_testData[19], false);Int64bigintArray2M.AssertModel(models[16],_testData[20], false);Int64bigintArray2M.AssertModel(models[17],_testData[21], false);Int64bigintArray2M.AssertModel(models[18],_testData[22], false);Int64bigintArray2M.AssertModel(models[19],_testData[23], false);Int64bigintArray2M.AssertModel(models[20],_testData[24], false);Int64bigintArray2M.AssertModel(models[21],_testData[25], false);Int64bigintArray2M.AssertModel(models[22],_testData[26], false);Int64bigintArray2M.AssertModel(models[23],_testData[27], false);Int64bigintArray2M.AssertModel(models[24],_testData[28], false);Int64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Int64bigintArray2M.AssertModel(models[0],_testData[22], false);Int64bigintArray2M.AssertModel(models[1],_testData[23], false);Int64bigintArray2M.AssertModel(models[2],_testData[24], false);Int64bigintArray2M.AssertModel(models[3],_testData[25], false);Int64bigintArray2M.AssertModel(models[4],_testData[26], false);Int64bigintArray2M.AssertModel(models[5],_testData[27], false);Int64bigintArray2M.AssertModel(models[6],_testData[28], false);Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Int64bigintArray2M.AssertModel(models[0],_testData[11], false);Int64bigintArray2M.AssertModel(models[1],_testData[12], false);Int64bigintArray2M.AssertModel(models[2],_testData[13], false);Int64bigintArray2M.AssertModel(models[3],_testData[14], false);Int64bigintArray2M.AssertModel(models[4],_testData[15], false);Int64bigintArray2M.AssertModel(models[5],_testData[16], false);Int64bigintArray2M.AssertModel(models[6],_testData[17], false);Int64bigintArray2M.AssertModel(models[7],_testData[18], false);Int64bigintArray2M.AssertModel(models[8],_testData[19], false);Int64bigintArray2M.AssertModel(models[9],_testData[20], false);Int64bigintArray2M.AssertModel(models[10],_testData[21], false);Int64bigintArray2M.AssertModel(models[11],_testData[22], false);Int64bigintArray2M.AssertModel(models[12],_testData[23], false);Int64bigintArray2M.AssertModel(models[13],_testData[24], false);Int64bigintArray2M.AssertModel(models[14],_testData[25], false);Int64bigintArray2M.AssertModel(models[15],_testData[26], false);Int64bigintArray2M.AssertModel(models[16],_testData[27], false);Int64bigintArray2M.AssertModel(models[17],_testData[28], false);Int64bigintArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int64bigintArray2M.AssertModel(models[0],_testData[14], false);Int64bigintArray2M.AssertModel(models[1],_testData[15], false);Int64bigintArray2M.AssertModel(models[2],_testData[16], false);Int64bigintArray2M.AssertModel(models[3],_testData[17], false);Int64bigintArray2M.AssertModel(models[4],_testData[18], false);Int64bigintArray2M.AssertModel(models[5],_testData[19], false);Int64bigintArray2M.AssertModel(models[6],_testData[20], false);Int64bigintArray2M.AssertModel(models[7],_testData[21], false);Int64bigintArray2M.AssertModel(models[8],_testData[22], false);Int64bigintArray2M.AssertModel(models[9],_testData[23], false);Int64bigintArray2M.AssertModel(models[10],_testData[24], false);Int64bigintArray2M.AssertModel(models[11],_testData[25], false);Int64bigintArray2M.AssertModel(models[12],_testData[26], false);Int64bigintArray2M.AssertModel(models[13],_testData[27], false);Int64bigintArray2M.AssertModel(models[14],_testData[28], false);Int64bigintArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

