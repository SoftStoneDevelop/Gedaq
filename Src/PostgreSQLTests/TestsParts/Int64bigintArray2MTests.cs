

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1282871760138528302L,

8138198919855140054L,

5918339520278542498L,

237251007465124608L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7587963813142026246L,

378375723135850424L,

678510715529327767L,

585173218802172414L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6002968085334547473L,

4864690788031637718L,

5245176810186092100L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1392157948227543318L,

2746693687709490519L,

8741471046798250699L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8194333811202226091L,

165100737964764075L,

7458785779154142249L,

4190117875411945577L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9032024338226980855L,

6774768484756809615L,

8316061672397728788L,

7294759136697823839L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3219417953946513518L,

56234148541401250L,

196453058430333794L,

6768961651513807075L,

},
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3775119207431527948L,

4368126279814316418L,

7410656453459036196L,

4678147517182102770L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8408260620847394457L,

8953796630318056970L,

3222316034291887243L,

1190053581712665985L,

},
},
            new Int64bigintArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
302283904906388052L,

451963118869087870L,

6312857461151712027L,

9104168504047138567L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
739884343298690115L,

7665545839410905215L,

7959174905198131298L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2780167087936817290L,

800920927917946489L,

8507295923891122879L,

7548726228069561793L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1071698027996332859L,

1857617069886591708L,

1437358828536981946L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6754521530224060184L,

6639290441488264030L,

8905894489125738917L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3982571351860182351L,

1239974492595662346L,

21866903419587801L,

6448787785512006099L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5959667199250029677L,

1034837812797868459L,

4478585225288969563L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5212999938638678848L,

3975823358656691689L,

7811051262144206281L,

8283044447869593619L,

},
},
            new Int64bigintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2503944184720862941L,

9024089734627491309L,

2236389756826931108L,

3691507183290017573L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2876580730667253299L,

7894380610586337112L,

8599155052152249215L,

7807271292382017472L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8957337222045330731L,

2312543570468488280L,

5197683335726019727L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4400488370832509488L,

3785347061019710569L,

936979447385457830L,

8925981572815915551L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7632098076906114487L,

3579427952582159948L,

154795290640018501L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
675295268326122781L,

258577043676152231L,

2321319931245880292L,

},
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4125742403627544136L,

1303241931226975260L,

8862962806628277673L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3161107879660118138L,

4614344504773026315L,

3142743234184364164L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5434925693348212763L,

8475222535012785773L,

4272335522601561200L,

2972489885026156326L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3716567686061959163L,

512746191133843906L,

7388053782955759117L,

},
},
            new Int64bigintArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5608922831801433168L,

8330156410914721960L,

5926499060738707160L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9056622371709296043L,

1272025563286244810L,

6375559641930053954L,

},
},
            new Int64bigintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4851156482999989157L,

7919490901397131894L,

3510335979729402304L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4096051785228023660L,

1105994000696013039L,

5546059153748998034L,

2321742897138632454L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6945885684955262920L,

2466232153731357716L,

2138185229630261049L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8206334197074407961L,

3518551400348271058L,

8010269688624180446L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3049211991435583631L,

7422740731203971385L,

651375969689828271L,

},
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8325323745642264777L,

1801039646626666917L,

6553287939402220417L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3633185650006346925L,

8411275640129866810L,

2584734559780347683L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1759639851818020734L,

1128278629758832244L,

5360889109529172288L,

6003342647675101531L,

},
},
            new Int64bigintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8823451255756793254L,

4837208345091899495L,

8822336526202047225L,

6290047956383034074L,

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
4037242644212803819L,

1093251142449590859L,

1896315792325040644L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5158821876403300634L,

4663940048254198604L,

5984539606949321343L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6174693168523227781L,

7230292703694832725L,

3546381577521513860L,

7306741106036229290L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6336964510720780019L,

774963897306664304L,

7858780077784557842L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2919423787878077533L,

4675836654340659699L,

2188551010153510113L,

1010295465647900659L,

},
},
            new Int64bigintArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4279723490684216574L,

7499645138960129166L,

3219838917659194884L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
903899329580242212L,

4117604435504182075L,

6493505856156497780L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3263112243023806390L,

5019421010059443009L,

7639406717073166142L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1470330357507693990L,

559878401490106018L,

3061617452790275012L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7487676589111484946L,

3411319375102950827L,

1151100279627433700L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1760834323235639154L,

8224594997838797231L,

8142933170616255889L,

7101813793143263119L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6633946020466615300L,

8422910360416859063L,

5796797401587244414L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4045903360278660366L,

7219830138065697169L,

1819420364346476815L,

4512857553366280631L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3898511813547708263L,

7845955281079223692L,

5219886005774006068L,

4975390848522042290L,

},
},
            new Int64bigintArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3454183259895592562L,

461035643589291707L,

5930791330534188912L,

954204366291020151L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2609420784890911208L,

2194242717075473560L,

9078308075594522165L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4178392811484397630L,

8896463312220862757L,

5340564777445588730L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
624827551593945530L,

4695467634972282658L,

4980719299489677135L,

4082902992641193279L,

},
},
            new Int64bigintArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8533626305430610348L,

803873648472222870L,

8818342909249537478L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7872874790568479562L,

5504260303301242192L,

5776889172407280575L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6519183136276739430L,

6787584691210763921L,

4579998599521981441L,

760121271813697829L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3633232845435320072L,

8629085637134705933L,

5011264239492909363L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261251385563202196L,

4777221866349134682L,

4974289529585624476L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3359864761130263077L,

6818867477573202868L,

141531550727134216L,

},
},
            new Int64bigintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3616648485808765519L,

1907929677232963219L,

8951042905090413035L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
122525029765789872L,

341962441539099471L,

540041351974812495L,

8997193363428576293L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
96840480965698846L,

8037855161408998770L,

5009417003236679761L,

},
},
            new Int64bigintArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2867578313504463922L,

1015440580234302998L,

6318865930110471145L,

6078213871044555946L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5345157326046054551L,

8390858350954486710L,

8583020672722158913L,

8483210478283600238L,

},
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6289548479799744131L,

3871122910882731534L,

7471448275906246148L,

8772223447563218901L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3518071356808774212L,

5223904242251031781L,

5880752220159712600L,

1367775098028216623L,

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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                        Assert.That(models, Has.Count.EqualTo(14));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[4], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[5], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[6], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[23],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[24],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(20));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Int64bigintArray2M.AssertModel(models[0],_testData[16], false);Int64bigintArray2M.AssertModel(models[1],_testData[17], false);Int64bigintArray2M.AssertModel(models[2],_testData[18], false);Int64bigintArray2M.AssertModel(models[3],_testData[19], false);Int64bigintArray2M.AssertModel(models[4],_testData[20], false);Int64bigintArray2M.AssertModel(models[5],_testData[21], false);Int64bigintArray2M.AssertModel(models[6],_testData[22], false);Int64bigintArray2M.AssertModel(models[7],_testData[23], false);Int64bigintArray2M.AssertModel(models[8],_testData[24], false);Int64bigintArray2M.AssertModel(models[9],_testData[25], false);Int64bigintArray2M.AssertModel(models[10],_testData[26], false);Int64bigintArray2M.AssertModel(models[11],_testData[27], false);Int64bigintArray2M.AssertModel(models[12],_testData[28], false);Int64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
Int64bigintArray2M.AssertModel(models[0],_testData[26], false);Int64bigintArray2M.AssertModel(models[1],_testData[27], false);Int64bigintArray2M.AssertModel(models[2],_testData[28], false);Int64bigintArray2M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Int64bigintArray2M.AssertModel(models[0],_testData[5], false);Int64bigintArray2M.AssertModel(models[1],_testData[6], false);Int64bigintArray2M.AssertModel(models[2],_testData[7], false);Int64bigintArray2M.AssertModel(models[3],_testData[8], false);Int64bigintArray2M.AssertModel(models[4],_testData[9], false);Int64bigintArray2M.AssertModel(models[5],_testData[10], false);Int64bigintArray2M.AssertModel(models[6],_testData[11], false);Int64bigintArray2M.AssertModel(models[7],_testData[12], false);Int64bigintArray2M.AssertModel(models[8],_testData[13], false);Int64bigintArray2M.AssertModel(models[9],_testData[14], false);Int64bigintArray2M.AssertModel(models[10],_testData[15], false);Int64bigintArray2M.AssertModel(models[11],_testData[16], false);Int64bigintArray2M.AssertModel(models[12],_testData[17], false);Int64bigintArray2M.AssertModel(models[13],_testData[18], false);Int64bigintArray2M.AssertModel(models[14],_testData[19], false);Int64bigintArray2M.AssertModel(models[15],_testData[20], false);Int64bigintArray2M.AssertModel(models[16],_testData[21], false);Int64bigintArray2M.AssertModel(models[17],_testData[22], false);Int64bigintArray2M.AssertModel(models[18],_testData[23], false);Int64bigintArray2M.AssertModel(models[19],_testData[24], false);Int64bigintArray2M.AssertModel(models[20],_testData[25], false);Int64bigintArray2M.AssertModel(models[21],_testData[26], false);Int64bigintArray2M.AssertModel(models[22],_testData[27], false);Int64bigintArray2M.AssertModel(models[23],_testData[28], false);Int64bigintArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray2M.AssertModel(models[0],_testData[20], false);Int64bigintArray2M.AssertModel(models[1],_testData[21], false);Int64bigintArray2M.AssertModel(models[2],_testData[22], false);Int64bigintArray2M.AssertModel(models[3],_testData[23], false);Int64bigintArray2M.AssertModel(models[4],_testData[24], false);Int64bigintArray2M.AssertModel(models[5],_testData[25], false);Int64bigintArray2M.AssertModel(models[6],_testData[26], false);Int64bigintArray2M.AssertModel(models[7],_testData[27], false);Int64bigintArray2M.AssertModel(models[8],_testData[28], false);Int64bigintArray2M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelBatchAsync(connection, 74, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Int64bigintArray2M.AssertModel(models[0],_testData[17], false);Int64bigintArray2M.AssertModel(models[1],_testData[18], false);Int64bigintArray2M.AssertModel(models[2],_testData[19], false);Int64bigintArray2M.AssertModel(models[3],_testData[20], false);Int64bigintArray2M.AssertModel(models[4],_testData[21], false);Int64bigintArray2M.AssertModel(models[5],_testData[22], false);Int64bigintArray2M.AssertModel(models[6],_testData[23], false);Int64bigintArray2M.AssertModel(models[7],_testData[24], false);Int64bigintArray2M.AssertModel(models[8],_testData[25], false);Int64bigintArray2M.AssertModel(models[9],_testData[26], false);Int64bigintArray2M.AssertModel(models[10],_testData[27], false);Int64bigintArray2M.AssertModel(models[11],_testData[28], false);Int64bigintArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
Int64bigintArray2M.AssertModel(models[0],_testData[11], false);Int64bigintArray2M.AssertModel(models[1],_testData[12], false);Int64bigintArray2M.AssertModel(models[2],_testData[13], false);Int64bigintArray2M.AssertModel(models[3],_testData[14], false);Int64bigintArray2M.AssertModel(models[4],_testData[15], false);Int64bigintArray2M.AssertModel(models[5],_testData[16], false);Int64bigintArray2M.AssertModel(models[6],_testData[17], false);Int64bigintArray2M.AssertModel(models[7],_testData[18], false);Int64bigintArray2M.AssertModel(models[8],_testData[19], false);Int64bigintArray2M.AssertModel(models[9],_testData[20], false);Int64bigintArray2M.AssertModel(models[10],_testData[21], false);Int64bigintArray2M.AssertModel(models[11],_testData[22], false);Int64bigintArray2M.AssertModel(models[12],_testData[23], false);Int64bigintArray2M.AssertModel(models[13],_testData[24], false);Int64bigintArray2M.AssertModel(models[14],_testData[25], false);Int64bigintArray2M.AssertModel(models[15],_testData[26], false);Int64bigintArray2M.AssertModel(models[16],_testData[27], false);Int64bigintArray2M.AssertModel(models[17],_testData[28], false);Int64bigintArray2M.AssertModel(models[18],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelBatch(connection, 93, 11))
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
                        Assert.That(models, Has.Count.EqualTo(26));
Int64bigintArray2M.AssertModel(models[0],_testData[4], false);Int64bigintArray2M.AssertModel(models[1],_testData[5], false);Int64bigintArray2M.AssertModel(models[2],_testData[6], false);Int64bigintArray2M.AssertModel(models[3],_testData[7], false);Int64bigintArray2M.AssertModel(models[4],_testData[8], false);Int64bigintArray2M.AssertModel(models[5],_testData[9], false);Int64bigintArray2M.AssertModel(models[6],_testData[10], false);Int64bigintArray2M.AssertModel(models[7],_testData[11], false);Int64bigintArray2M.AssertModel(models[8],_testData[12], false);Int64bigintArray2M.AssertModel(models[9],_testData[13], false);Int64bigintArray2M.AssertModel(models[10],_testData[14], false);Int64bigintArray2M.AssertModel(models[11],_testData[15], false);Int64bigintArray2M.AssertModel(models[12],_testData[16], false);Int64bigintArray2M.AssertModel(models[13],_testData[17], false);Int64bigintArray2M.AssertModel(models[14],_testData[18], false);Int64bigintArray2M.AssertModel(models[15],_testData[19], false);Int64bigintArray2M.AssertModel(models[16],_testData[20], false);Int64bigintArray2M.AssertModel(models[17],_testData[21], false);Int64bigintArray2M.AssertModel(models[18],_testData[22], false);Int64bigintArray2M.AssertModel(models[19],_testData[23], false);Int64bigintArray2M.AssertModel(models[20],_testData[24], false);Int64bigintArray2M.AssertModel(models[21],_testData[25], false);Int64bigintArray2M.AssertModel(models[22],_testData[26], false);Int64bigintArray2M.AssertModel(models[23],_testData[27], false);Int64bigintArray2M.AssertModel(models[24],_testData[28], false);Int64bigintArray2M.AssertModel(models[25],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int64bigintArray2M.AssertModel(models[0],_testData[3], false);Int64bigintArray2M.AssertModel(models[1],_testData[4], false);Int64bigintArray2M.AssertModel(models[2],_testData[5], false);Int64bigintArray2M.AssertModel(models[3],_testData[6], false);Int64bigintArray2M.AssertModel(models[4],_testData[7], false);Int64bigintArray2M.AssertModel(models[5],_testData[8], false);Int64bigintArray2M.AssertModel(models[6],_testData[9], false);Int64bigintArray2M.AssertModel(models[7],_testData[10], false);Int64bigintArray2M.AssertModel(models[8],_testData[11], false);Int64bigintArray2M.AssertModel(models[9],_testData[12], false);Int64bigintArray2M.AssertModel(models[10],_testData[13], false);Int64bigintArray2M.AssertModel(models[11],_testData[14], false);Int64bigintArray2M.AssertModel(models[12],_testData[15], false);Int64bigintArray2M.AssertModel(models[13],_testData[16], false);Int64bigintArray2M.AssertModel(models[14],_testData[17], false);Int64bigintArray2M.AssertModel(models[15],_testData[18], false);Int64bigintArray2M.AssertModel(models[16],_testData[19], false);Int64bigintArray2M.AssertModel(models[17],_testData[20], false);Int64bigintArray2M.AssertModel(models[18],_testData[21], false);Int64bigintArray2M.AssertModel(models[19],_testData[22], false);Int64bigintArray2M.AssertModel(models[20],_testData[23], false);Int64bigintArray2M.AssertModel(models[21],_testData[24], false);Int64bigintArray2M.AssertModel(models[22],_testData[25], false);Int64bigintArray2M.AssertModel(models[23],_testData[26], false);Int64bigintArray2M.AssertModel(models[24],_testData[27], false);Int64bigintArray2M.AssertModel(models[25],_testData[28], false);Int64bigintArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int64bigintArray2M.AssertModel(models[0],_testData[5], false);Int64bigintArray2M.AssertModel(models[1],_testData[6], false);Int64bigintArray2M.AssertModel(models[2],_testData[7], false);Int64bigintArray2M.AssertModel(models[3],_testData[8], false);Int64bigintArray2M.AssertModel(models[4],_testData[9], false);Int64bigintArray2M.AssertModel(models[5],_testData[10], false);Int64bigintArray2M.AssertModel(models[6],_testData[11], false);Int64bigintArray2M.AssertModel(models[7],_testData[12], false);Int64bigintArray2M.AssertModel(models[8],_testData[13], false);Int64bigintArray2M.AssertModel(models[9],_testData[14], false);Int64bigintArray2M.AssertModel(models[10],_testData[15], false);Int64bigintArray2M.AssertModel(models[11],_testData[16], false);Int64bigintArray2M.AssertModel(models[12],_testData[17], false);Int64bigintArray2M.AssertModel(models[13],_testData[18], false);Int64bigintArray2M.AssertModel(models[14],_testData[19], false);Int64bigintArray2M.AssertModel(models[15],_testData[20], false);Int64bigintArray2M.AssertModel(models[16],_testData[21], false);Int64bigintArray2M.AssertModel(models[17],_testData[22], false);Int64bigintArray2M.AssertModel(models[18],_testData[23], false);Int64bigintArray2M.AssertModel(models[19],_testData[24], false);Int64bigintArray2M.AssertModel(models[20],_testData[25], false);Int64bigintArray2M.AssertModel(models[21],_testData[26], false);Int64bigintArray2M.AssertModel(models[22],_testData[27], false);Int64bigintArray2M.AssertModel(models[23],_testData[28], false);Int64bigintArray2M.AssertModel(models[24],_testData[29], false);
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

