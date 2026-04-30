

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6903881025481818902L,

1752624494390371433L,

4790022435958330576L,

2018372449119425179L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5837890482355294540L,

8447514390164543503L,

2301147117596796993L,

},
},
            new Int64bigintArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7668969606108384863L,

6830804135495885098L,

674372615110885158L,

4210544739504289238L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5617705942054351717L,

8240888941465085656L,

4458436080783481047L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7924776051101840146L,

2188596588805358039L,

205059477113315172L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2855612228239722190L,

1336520103681462044L,

3216548476568046719L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8740202253434868172L,

7959670379317085238L,

3285005456272138034L,

7264705877234017792L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5695678741837577007L,

86954301119635013L,

734852252292077097L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
894934843055579717L,

8631852580697812420L,

413979583478332958L,

8787815990352167990L,

},
},
            new Int64bigintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5602157898590949433L,

8802082067033918437L,

2396608746887973679L,

3760098354879690473L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6287080281966021548L,

3805299714002897114L,

8337314898557361179L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9174276749674930676L,

8887189819038699487L,

6813598981840001700L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6454308081987835795L,

6470256780125170739L,

2336854648648485888L,

7228993931135247605L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6183078248130945622L,

7436228723013366067L,

6561249768356384017L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4186307796013481790L,

5795538731484470545L,

6281470024868861001L,

5927798641973774372L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1657105158329524499L,

2200621900860510208L,

8971646075335349584L,

3725866524935459598L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4269698875110096438L,

5243842841669146947L,

5970344239575724448L,

4646373214295857781L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6505713482199059262L,

4347501335849230219L,

8593985528360693366L,

},
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5091992581555060001L,

3830219357140011695L,

7443886923962694138L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4137367739785435038L,

1479328493321210433L,

6243680986786345960L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1607805292412528167L,

4705618524674809019L,

5195179944603289333L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
835110658355657446L,

6930471993292728497L,

4637997681660769223L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8241710142931893974L,

5555634757622633951L,

9119270873320063582L,

6008419316600014989L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7771896648413018460L,

6200665080972655244L,

3956820528064835955L,

3391813266027269827L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1281313268968927536L,

6948040934322779737L,

7648183114252249904L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5163737242622433363L,

6226070292935503065L,

2394345578167033191L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3422866438544840517L,

651661354742655904L,

345974884575826584L,

},
},
            new Int64bigintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7832629971885603051L,

6636757272496167514L,

5191172940394204757L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3365717961519854096L,

8855924267006682985L,

8520954794013012806L,

6922572036125639801L,

},
},
            new Int64bigintArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7158004079729915682L,

3577668299032993106L,

3041697840925969887L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5397080292112950423L,

5734277055307397137L,

5885405871983904214L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2038193541991544258L,

8723101802825306541L,

1153932053618207886L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7873777908105806584L,

847243846456327015L,

6277134323606951215L,

8640502190860032089L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5028432188853498918L,

1849173513915455787L,

1596951656496522055L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3619546274826227765L,

4943635040578250539L,

6265746496717804525L,

4669916655087735290L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4918416258711778507L,

6401204533615324645L,

1346562166705451389L,

7359455885995220890L,

},
},
            new Int64bigintArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2820098402515481954L,

3453397977138501075L,

8281472984675414031L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3762046256717986922L,

1841766366455544473L,

8209715858317012154L,

1020810953565649870L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9151433938348337829L,

2051917592705207378L,

2672842908881713006L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5767666203756848949L,

918992268109760786L,

6325788376588440039L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2119305357951385746L,

4896160141270152879L,

6958186145907040167L,

5080096084824072108L,

},
},
            new Int64bigintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4748473518944855541L,

9155164046783155826L,

5859194596490497292L,

8699812417981282809L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8906865504231583008L,

7443193917729473657L,

8956523706740359829L,

6595209998197755459L,

},
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1645891758291785931L,

1033866690451500754L,

2761622195507418111L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7401435748910490145L,

3352632929250814575L,

378547091024182004L,

7672151995952341522L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
828980277373307289L,

6851068803008109494L,

3345750372465894309L,

},
},
            new Int64bigintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8787972341260068767L,

8399122004285000022L,

1220345766047314915L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5710076202873250086L,

2047974378095831526L,

7167198126256239121L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7455454195991770512L,

7727042338227663508L,

5223398730299139466L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
839474907323790973L,

6381876812778528118L,

6871588095864357461L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4972148954608503184L,

7516532933999743881L,

1427716735788470199L,

5322193377320045796L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4154796927720524059L,

1561378401721785493L,

8767702312158558340L,

},
},
            new Int64bigintArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8085515859009722586L,

4475504843606931325L,

4108653026113882391L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4631608338958111814L,

6268168186391392215L,

2843875103999552606L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5353562067288338218L,

3351719849527531485L,

1923179926488896634L,

182164408968847873L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1881757182015134176L,

5314512617907371409L,

5699210572093269763L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7512370680096440027L,

7356450100826724224L,

550413144785189211L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3506149432681929762L,

8804923597458806702L,

3637633517049432047L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1707253311692281411L,

1496997434613504843L,

4381407268243046152L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3736932357274609046L,

6844584554526292791L,

5205050912989013369L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8725872192496864076L,

2678424595840749280L,

2076565275090308865L,

515595271073744704L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
395015236349714079L,

8778940439628772281L,

6341612470290395367L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
302082463093212243L,

4100998183300423757L,

6632564897373074662L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6532334870496813213L,

3214373979307844674L,

4934428720281422627L,

4225976847237044012L,

},
},
            new Int64bigintArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
55535069386783431L,

6852223294629974694L,

5340681547539391033L,

7388062133397036398L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5914375153773554778L,

5763377837008721996L,

468365207726004284L,

},
},
            new Int64bigintArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
19326138741127552L,

4731323975920914088L,

5231098526186382623L,

5329304764542302727L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4183589552120854566L,

3628906610012515333L,

9105312447339871846L,

7416428209962092931L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7515371086082858370L,

9217918072828452657L,

2686091059926614804L,

8250240307813037774L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8835350583709485542L,

4724319204919328129L,

8599247500986755287L,

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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[29], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintArray2M.AssertModel(models[0],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 106, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 102, query1, 111, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[29], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[29], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 80, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray2M.AssertModel(models[0],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 106, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray2M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Int64bigintArray2M.AssertModel(models[0],_testData[12], false);Int64bigintArray2M.AssertModel(models[1],_testData[13], false);Int64bigintArray2M.AssertModel(models[2],_testData[14], false);Int64bigintArray2M.AssertModel(models[3],_testData[15], false);Int64bigintArray2M.AssertModel(models[4],_testData[16], false);Int64bigintArray2M.AssertModel(models[5],_testData[17], false);Int64bigintArray2M.AssertModel(models[6],_testData[18], false);Int64bigintArray2M.AssertModel(models[7],_testData[19], false);Int64bigintArray2M.AssertModel(models[8],_testData[20], false);Int64bigintArray2M.AssertModel(models[9],_testData[21], false);Int64bigintArray2M.AssertModel(models[10],_testData[22], false);Int64bigintArray2M.AssertModel(models[11],_testData[23], false);Int64bigintArray2M.AssertModel(models[12],_testData[24], false);Int64bigintArray2M.AssertModel(models[13],_testData[25], false);Int64bigintArray2M.AssertModel(models[14],_testData[26], false);Int64bigintArray2M.AssertModel(models[15],_testData[27], false);Int64bigintArray2M.AssertModel(models[16],_testData[28], false);Int64bigintArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Int64bigintArray2M.AssertModel(models[0],_testData[17], false);Int64bigintArray2M.AssertModel(models[1],_testData[18], false);Int64bigintArray2M.AssertModel(models[2],_testData[19], false);Int64bigintArray2M.AssertModel(models[3],_testData[20], false);Int64bigintArray2M.AssertModel(models[4],_testData[21], false);Int64bigintArray2M.AssertModel(models[5],_testData[22], false);Int64bigintArray2M.AssertModel(models[6],_testData[23], false);Int64bigintArray2M.AssertModel(models[7],_testData[24], false);Int64bigintArray2M.AssertModel(models[8],_testData[25], false);Int64bigintArray2M.AssertModel(models[9],_testData[26], false);Int64bigintArray2M.AssertModel(models[10],_testData[27], false);Int64bigintArray2M.AssertModel(models[11],_testData[28], false);Int64bigintArray2M.AssertModel(models[12],_testData[29], false);
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
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

