

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4587596419957838282L,

3124386410682200048L,

1142946996502396614L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8486817087006874215L,

9083912207200838254L,

8396238823690174259L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3623060248568340391L,

8263249982737048721L,

7032241868546861987L,

1500459237118876293L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6891441305088535218L,

3165395564590277705L,

8138760988233688715L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
187803417244474033L,

38604317625584890L,

3394847487393614615L,

5066147963649818453L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5370813782342880351L,

7871109919676976070L,

5842861390285800898L,

1859482035552584629L,

},
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9213380781217257057L,

2637234721306855556L,

1350535433340539279L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8303414145823779700L,

3962167334631434271L,

6555904846964761375L,

5024581969268286328L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2111483845151542461L,

657827928010135241L,

9104153628259859303L,

3827022895357459693L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1269932432501611374L,

4523234737811521121L,

9104759289371714484L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2950454179203258884L,

6834433146284137025L,

7891396856875044209L,

5910967724932089144L,

},
},
            new Int64bigintArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8926037558177045251L,

8921310916144576002L,

6350947249395093864L,

6245322943761088930L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7899700419085442805L,

279841364538990443L,

7771104404600964016L,

7901383591553614956L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8402455299296060792L,

5715832096599597322L,

6617750565521184556L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8937755669383746905L,

3174365196357229810L,

5101696212243776816L,

1010318000492771536L,

},
},
            new Int64bigintArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2396259559998161645L,

8116734791328986088L,

5676411427541272906L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1869561233360636600L,

8166145725097871084L,

3698491167614498898L,

3134811868423215804L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2260649898924622606L,

8613579372956473869L,

4827115266525842353L,

7523988309110022212L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7317679014798570882L,

2223026443334013220L,

1489034526472445597L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7761270206869878025L,

8426931634277619166L,

2531381822438023395L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5009385560887539736L,

7393407420078917679L,

635558313373143363L,

},
},
            new Int64bigintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1389492609198858895L,

5211845460618607458L,

8133067385869865095L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2200254626741251815L,

5922585935989513860L,

4339129176517527452L,

1185900361449397116L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3574898232643310952L,

1534965557450541037L,

6116284106127361585L,

6243720912452428300L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
963583654700476633L,

5190526844911594345L,

1723749868471353065L,

1220937245398460223L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7826951958511698135L,

4184431642558660568L,

7834289440111122134L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4813761666040293133L,

4933766964741698263L,

2110814307931390772L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6281060472430246751L,

4340287425659243823L,

5695715975515455665L,

6776458633657540033L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4342660398110977074L,

3944261996081971594L,

821250007752135627L,

},
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6136455698081860737L,

3454671123689975173L,

5820718868245844522L,

1943108808309733850L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5443080032928212413L,

4323002866711789732L,

3292707069904223354L,

3061206661412909327L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1666615070291218841L,

5932658065382459268L,

2334198087391589368L,

4406255462119077028L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7065912006638351158L,

6909214746898055808L,

8769905675444836232L,

8080492139276641382L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8108573727716160536L,

1515328500960936165L,

5081309579417416357L,

5132424831536131250L,

},
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7939968390433296662L,

8600704334965203240L,

3247306003024147526L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9069766989207055558L,

8400126018401464493L,

6445777341931714524L,

7942891652145561608L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7749405066339548799L,

374338060745686355L,

2811516838657331587L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5318155172049245487L,

8755838140160819220L,

4466320753761764406L,

2851333471026451284L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7394293314399981988L,

7975581418949001754L,

7645093765119027419L,

3031392820386783993L,

},
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5113546663325046687L,

455536310293719522L,

8615915503220240938L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7464031538568658271L,

176315117759615382L,

5271007603654371369L,

5160444064626773407L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2314899849933830194L,

7307371038674858440L,

8040717445517154355L,

},
},
            new Int64bigintArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7687091776900767895L,

7273053076085505837L,

1503551135784924350L,

2777975737647105814L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3476959011154590275L,

3471708059780792328L,

7084871932908187981L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2705437660671198725L,

7300423329101840627L,

3180186976768301745L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2948900864067989966L,

2748725426261544757L,

4527654098354786054L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5341072451866811694L,

7178818733007525541L,

7253070382451287256L,

},
},
            new Int64bigintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9097474097401463438L,

9043254517713527594L,

4032475571087527808L,

2638701477811928101L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7658519802168042557L,

5049980202939337382L,

8338308781256946438L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5745749044762041318L,

5107158306858863057L,

7400190410336416880L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5673288541929486684L,

4722988977531874876L,

9207661531087334895L,

},
},
            new Int64bigintArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6097592560726286377L,

5193904243297322912L,

5256250522019187205L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9121759015068389200L,

6716558978896846822L,

4457599823138836213L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8431542602247804482L,

5042241561966314027L,

4424967262514173435L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1978812420720945715L,

5159860396179893591L,

253145678753979006L,

8657414916812121619L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4093375489805902221L,

2221760021816333507L,

3581928660252537820L,

},
},
            new Int64bigintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4281124107628025856L,

5284816755664728461L,

3710175022820779478L,

7444601241961299421L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6163990890044931407L,

1048700328971620970L,

78120713628218565L,

},
},
            new Int64bigintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6411965476310594618L,

7159545271289461022L,

4263309515975520947L,

7378279084704325358L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7485918302137440178L,

3121045263927263257L,

4105784328796738458L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2932037383134010992L,

5209759319208533738L,

6730079344659316866L,

1681801706911905521L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8714461390829042619L,

5376849353779712965L,

2748860386398704970L,

6013215149198794780L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4554599458828958506L,

5143140063726224370L,

4343313394973897920L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8702278229617375546L,

8722004508479798337L,

4129096734780561403L,

3719973039456712211L,

},
},
            new Int64bigintArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
186881884824393104L,

6497426213120053817L,

3252210026508829756L,

6215155858103110995L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5246522899024136480L,

2888034418303858116L,

8084805913778816754L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3526361708711379030L,

7148786021568508582L,

2528243930190502943L,

6001376931698025806L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2562595786614942046L,

2545430389461197152L,

693748007017398417L,

4493732578470228584L,

},
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7416844791912336133L,

5117391529161284754L,

1053204639330266194L,

278836429869005303L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7110392370558640720L,

4183839364535297358L,

7126888528070451877L,

6754562468597708064L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8249500197671130808L,

4016003612499280362L,

1892977115357140546L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8290463748860045321L,

7690285343052262182L,

8678688495167599546L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3941906538493310873L,

5136015491826964175L,

6046478278856013503L,

},
},
            new Int64bigintArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4486836784485219405L,

3318295770921729986L,

8677631534846108055L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
930428783976761435L,

1689765183160061570L,

6945533467794835701L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7037472978095735069L,

1581875187714901106L,

5304009859695815323L,

4388697970442949369L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7610152539859806947L,

7129352238994109492L,

1076794944602741615L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1365182257289702828L,

5485451283133580751L,

7519224950427706562L,

},
},
            new Int64bigintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8977424546992900831L,

6678543227768419362L,

635975659451175169L,

},
    ModelInner = null,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray2M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 15, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 4, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 46, query2))
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 106))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 129, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintArray2M.AssertModel(models[0],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int64bigintArray2M.AssertModel(models[0],_testData[30], false);Int64bigintArray2M.AssertModel(models[1],_testData[31], false);Int64bigintArray2M.AssertModel(models[2],_testData[32], false);Int64bigintArray2M.AssertModel(models[3],_testData[33], false);Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
Int64bigintArray2M.AssertModel(models[0],_testData[5], false);Int64bigintArray2M.AssertModel(models[1],_testData[6], false);Int64bigintArray2M.AssertModel(models[2],_testData[7], false);Int64bigintArray2M.AssertModel(models[3],_testData[8], false);Int64bigintArray2M.AssertModel(models[4],_testData[9], false);Int64bigintArray2M.AssertModel(models[5],_testData[10], false);Int64bigintArray2M.AssertModel(models[6],_testData[11], false);Int64bigintArray2M.AssertModel(models[7],_testData[12], false);Int64bigintArray2M.AssertModel(models[8],_testData[13], false);Int64bigintArray2M.AssertModel(models[9],_testData[14], false);Int64bigintArray2M.AssertModel(models[10],_testData[15], false);Int64bigintArray2M.AssertModel(models[11],_testData[16], false);Int64bigintArray2M.AssertModel(models[12],_testData[17], false);Int64bigintArray2M.AssertModel(models[13],_testData[18], false);Int64bigintArray2M.AssertModel(models[14],_testData[19], false);Int64bigintArray2M.AssertModel(models[15],_testData[20], false);Int64bigintArray2M.AssertModel(models[16],_testData[21], false);Int64bigintArray2M.AssertModel(models[17],_testData[22], false);Int64bigintArray2M.AssertModel(models[18],_testData[23], false);Int64bigintArray2M.AssertModel(models[19],_testData[24], false);Int64bigintArray2M.AssertModel(models[20],_testData[25], false);Int64bigintArray2M.AssertModel(models[21],_testData[26], false);Int64bigintArray2M.AssertModel(models[22],_testData[27], false);Int64bigintArray2M.AssertModel(models[23],_testData[28], false);Int64bigintArray2M.AssertModel(models[24],_testData[29], false);Int64bigintArray2M.AssertModel(models[25],_testData[30], false);Int64bigintArray2M.AssertModel(models[26],_testData[31], false);Int64bigintArray2M.AssertModel(models[27],_testData[32], false);Int64bigintArray2M.AssertModel(models[28],_testData[33], false);Int64bigintArray2M.AssertModel(models[29],_testData[34], false);
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

