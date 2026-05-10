

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3070816801920489849L,

1594481364363056528L,

8959426148971729483L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
252847289756486773L,

4288063951511465883L,

7759838118963479667L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5804849313651393949L,

1677475230167889732L,

8819824753707137229L,

6671985824990298883L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
107083555669164389L,

2214639241257053716L,

8944596448324732616L,

580691766337470521L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7074779858071917117L,

5452421985385269371L,

2974123780385801626L,

},
},
            new Int64bigintArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261152994911755811L,

5725469079926880889L,

3037355172520166703L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3287049530799518831L,

4894028722754291780L,

3370796812543395272L,

7273771001234025916L,

},
},
            new Int64bigintArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7352171177580718603L,

4264020343278499169L,

8203221681687311213L,

1904505198242659539L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3340267906843084879L,

3893743206754188927L,

2752648619830756779L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4017284896926790495L,

5133343667962033440L,

5892211890270235526L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5067620302240398730L,

3238734524113920932L,

6012900447100104951L,

},
},
            new Int64bigintArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1395773609990486424L,

163408112829033327L,

2483733219190362373L,

6806227517063676864L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4973266032008921364L,

8811293636238698386L,

7235353271412466926L,

2297640465371682167L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5851547347477017156L,

5168403743806818026L,

1528640950676026511L,

1067221146637527511L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7196954926314211536L,

6052006514571751759L,

3175859858997371816L,

3052012502903284328L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4446048670548631454L,

8801687023601596033L,

352005254778589473L,

2281280963881409532L,

},
},
            new Int64bigintArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2345351568042697828L,

8416234167284515268L,

8114165311142602754L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5964306720621011433L,

6619432100069464192L,

2568166832999885052L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8462827459001649337L,

821287380596161054L,

295762187111627130L,

497896070657951692L,

},
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6935364472806106400L,

7093279535514924541L,

1833140380245248281L,

3939474854494470052L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4142222409122690521L,

480573788803917994L,

1827014063051618651L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
503347373487696497L,

5436490039068968083L,

8123604480697414971L,

2036612345589240476L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1608443560762095931L,

5508600506172266991L,

2619180578931685459L,

5013265859279960276L,

},
},
            new Int64bigintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7488197057460936693L,

8355204859355466886L,

2512177635387234918L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8829255911642819316L,

7693151832990034612L,

8345559914991768540L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4925802050278772133L,

4628248195114938297L,

8804317979549377504L,

8216307485362008908L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4491395610007594153L,

4803059492279102403L,

1899802897657809792L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
727707699143900797L,

137903744800304763L,

557595013832289733L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7201900838455642765L,

777086631942677623L,

3312575931450409290L,

5622187886777754080L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3866366417317965610L,

7956613261136325428L,

1954721008469470711L,

2106682543337199154L,

},
},
            new Int64bigintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1084835460281266687L,

9004391620961614355L,

5104737668500635970L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8499395909564813159L,

7389127777662027346L,

1836420475008274475L,

},
},
            new Int64bigintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4941670480402632481L,

6987547252057033647L,

9159944900170702682L,

2293301242020288922L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5823037100903348048L,

2504934804264314921L,

9001355420967743117L,

3076793278017278176L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8599023880629690109L,

6138336915409595815L,

8468785706582751870L,

6873620703768032616L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8692533717173402228L,

6308992015085880887L,

8264939768080401318L,

8637605660544405849L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8007683736273298915L,

2062241682520666594L,

6190338445157555176L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8049004745339387571L,

3876170718093869476L,

7458313793595187951L,

},
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3505765566183669102L,

2489372811644263532L,

1107367055738597292L,

4563817216877538722L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3583406979111329421L,

399426300805386669L,

8999718831331528522L,

},
},
            new Int64bigintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8729038442313286428L,

2200247257821138525L,

2709909312867693617L,

5855788285017431438L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
659327781933134968L,

2170755023565880336L,

4416625511153260218L,

8320899822652675190L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5016452227100922237L,

8033947669986126841L,

6636290963300024912L,

1773607073755271397L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8674989759221899084L,

4013148133008565186L,

9220677392651161688L,

6382699111244710354L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1966389311613510921L,

1156397980034741968L,

5165971329240597351L,

},
},
            new Int64bigintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8935522160120061292L,

4846314975176036369L,

4937187553675272386L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7929968018479222886L,

638267157802123162L,

6501599610254787413L,

5498879866558281353L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7526510227552776017L,

2544802237569542382L,

387854576670211654L,

2644928751061678881L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6045382164133515943L,

4543040123050093230L,

1575911773464461228L,

},
},
            new Int64bigintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2219126186574615702L,

3112894802450483589L,

8345465870986403819L,

7778339028593951511L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4328258750686404551L,

5100193823898171538L,

3687491988161629826L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
184746877302696093L,

4769833236026940303L,

7755059541235567272L,

1490864358893242879L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2213434240347001712L,

3147597156748388815L,

6433815736491567479L,

4061330158509950164L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8929469280602026824L,

3381359181399525751L,

6680309294668921870L,

9034216622001698497L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316456673446052072L,

378344874692899479L,

14265594304799496L,

6087908398080869362L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5037918622351912470L,

133425587381046094L,

3820723834288667116L,

1268421635077757964L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4515405209347869441L,

1296891668706832468L,

3620072940351930663L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644425819804048040L,

1583155105838430136L,

6028203982281360369L,

},
},
            new Int64bigintArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
466858998617597637L,

7596693442646112459L,

1095992278753622525L,

4461905024822217076L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931007272400456520L,

1842392363638922282L,

2604934024975428915L,

2851561773708925934L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8511946109526556925L,

107171118302312845L,

9146345826554332911L,

},
},
            new Int64bigintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5022543539259810698L,

4467693622841542962L,

1646633242671158329L,

5440154914428160007L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3306876039675697117L,

8829051954779054458L,

6268850176621202400L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4254105452957053893L,

803636872271354787L,

5724402334166782746L,

2491662325907786921L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6290955939148212993L,

4833934164431164067L,

7235410713056433448L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8232165414686976454L,

2876561107532119641L,

6084638103672646629L,

2851456725774764571L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7969001279517947869L,

8085303233275050897L,

2907917543841208630L,

3014090293728130027L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2000887274529927651L,

3008152379060472100L,

8084157036478534003L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3029359084605717172L,

844564756991378363L,

8610056427556174642L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2435314869579036540L,

7620446754341629785L,

3692072708235764913L,

},
},
            new Int64bigintArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1760314550107079102L,

2090865082309262400L,

1281677887078819178L,

5742851035679548354L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6334915306828482688L,

3697020411795050400L,

7233476994311941161L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760449391941979128L,

1830310584161894695L,

705803600404068572L,

9112513608737827532L,

},
},
            new Int64bigintArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3963482708845932617L,

6340864940352338464L,

348225198992661761L,

778023999746187993L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3993498500671163461L,

933550094472046510L,

5878748028604754914L,

6064490000171987303L,

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

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 138;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        Int64bigintArray2M.AssertModel(models[24],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray2M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray2M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        Int64bigintArray2M.AssertModel(models[20],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        Int64bigintArray2M.AssertModel(models[25],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintArray2M.AssertModel(models[0],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 66, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray2M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[34], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Int64bigintArray2M.AssertModel(models[0],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[14], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[15], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[16], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[17], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[17],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[18],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[19],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[20],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[21],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[22],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[23],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[24],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[25],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int64bigintArray2M.AssertModel(models[0],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI), typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                await ((IInt64ListbigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                ((IInt64ListbigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

