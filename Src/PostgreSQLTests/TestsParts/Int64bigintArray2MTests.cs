

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2175890935528088173L,

4005090232023634202L,

4370038872567685917L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3944298609086988713L,

393549640971238909L,

4256554237580642418L,

},
},
            new Int64bigintArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1590857721621040482L,

6344839599013549919L,

6777583629044247400L,

262714219941418904L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2971415281784242274L,

1678976878001226957L,

3223385481928394318L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6134666648429611428L,

609651253357556870L,

7626184156040548301L,

8354128944881023541L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6884613558070201393L,

4316418704949799650L,

2814189840407460368L,

},
},
            new Int64bigintArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8642991610658414030L,

5384093904428084786L,

5926135511326376364L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3319891794708192009L,

8728081761989017711L,

5636367965895032467L,

51066498334890208L,

},
},
            new Int64bigintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6703021128266602248L,

5030528400476083788L,

8001966738437584449L,

1657984204436915063L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1139101456238084413L,

4188116313607387134L,

6376446076871897904L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3321831732172557235L,

8860776079939518294L,

6405415143026433354L,

1616209226550632878L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7475330337767898432L,

2714896684651718180L,

3841707623054255724L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7970358109716662919L,

3578905079952960845L,

2696222312644136046L,

8239162922745082257L,

},
},
            new Int64bigintArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
98325859406942963L,

3708721747585214093L,

4674151879138903305L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
532558812502586330L,

2212041980737527989L,

396454542878219333L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4915163337567921880L,

5646596500637957336L,

1580233113500553477L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2060458027927522257L,

3632277862697693927L,

5551435476244464589L,

17462170116946074L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2561749239265562962L,

2552957621608515290L,

2597637031348543596L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
626126257059986043L,

8961676012996721726L,

4833369420157337291L,

165522835288769153L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8222230073529988558L,

533755988742785067L,

4064150571429435582L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7334217662972394296L,

3669351718917342666L,

3438469203727497010L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6564032688518217968L,

77778192772911381L,

4042338860544364010L,

8360273981166620822L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3304803079826573071L,

6879237553477308889L,

4438401652586202914L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8892752255282799181L,

3515554500992065443L,

3075431294581095972L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3064530783855116142L,

6561400190400564086L,

5762878046274126587L,

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
2643289334439546005L,

2913876491960462562L,

3350812854572281045L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1602620861753196872L,

8283631757310374483L,

8642631584214803383L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3914018181474080519L,

4340347593795106472L,

6198156461082032171L,

6593447553236896376L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7738150489883194934L,

8210942153092363889L,

9057867651653375664L,

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
2208411256561196145L,

824089471780525953L,

2069117973087696027L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
488723703509907078L,

8023182149854248309L,

4574858693680437459L,

5709609595418551362L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7347909836840024783L,

5360314103608426455L,

245127300433323633L,

5185018224549655080L,

},
},
            new Int64bigintArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2104150034788081692L,

4004628274106895637L,

5164889861347137478L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6730752024572050835L,

4205223505946140351L,

8263757304888461447L,

},
},
            new Int64bigintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7235574934495051666L,

952909587454317684L,

4352013477585087172L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3314736224108319078L,

9106078706400692058L,

1796780416370366327L,

9132030727850980923L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7813239494259648059L,

1843963377644218759L,

9202193591023236081L,

8105847014101052775L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5689622222329832245L,

2806654285438608722L,

6209660033052697766L,

862010459759337306L,

},
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5835778197147330511L,

2917280222030063716L,

296682749504217363L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4588247045992044649L,

2538047418883964359L,

2245861736469648824L,

5987760019970518794L,

},
},
            new Int64bigintArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
564283351816143052L,

6198144213445999223L,

85709755024151015L,

4647799971524212115L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6950744846271396006L,

7846357819705075466L,

2603176164957658762L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4525663617262803731L,

4310812742970889262L,

1136022486242491793L,

},
},
            new Int64bigintArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6803175556489493188L,

6630251072478973192L,

5582574443707807281L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5048537850893864243L,

8867664416794167867L,

6769532307004023158L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7505526956776439530L,

5636510468576568641L,

7771949081408709980L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6584401961420173233L,

1689205245085717314L,

6073995492875685952L,

7151169684197444168L,

},
},
            new Int64bigintArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
273847930069492252L,

6551758415790367228L,

2992267997170751543L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
609159414875219349L,

922769547056765888L,

1482797316820648354L,

432332106164248102L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5241245568131857659L,

5388813751324069168L,

2632850183451645569L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3165108108119755832L,

4837677676846236467L,

4923163113938145060L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
560757174741093024L,

4487356000368789855L,

572317769093463354L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7546854695067265915L,

6628858778334522097L,

1751849089637805136L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
200575055824320786L,

8230777563311679301L,

3977903978538560275L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2610886434898459731L,

696768438339631833L,

8439374092813436769L,

6104513559694153937L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4206222266553413130L,

75580837421498265L,

3289459204943857079L,

8658282308870468930L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4847543360428635530L,

6629565398883467026L,

380161702337748794L,

2357847256916873570L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7545762469076048516L,

5702446260316727873L,

7093572023616408002L,

969507984132461362L,

},
},
            new Int64bigintArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7307532300881851644L,

2966881708667535908L,

2322698809875486304L,

6617483147566943840L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5782702459989806366L,

5555646186437630916L,

7968815054669040461L,

5667582539954582542L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4109651052658426126L,

2498977058421758943L,

2224071335791658419L,

1963226792146335349L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6345648716160935603L,

3677545912312513244L,

2615202355290459134L,

6847772281126227833L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6645673256203135036L,

4084393028464410664L,

5290419912669875912L,

4401706392507503158L,

},
},
            new Int64bigintArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1197138913688558711L,

6084179375663593211L,

2814234774050806247L,

5335162701186046779L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1949380811622697709L,

7553234971213032746L,

2950859267994295843L,

},
},
            new Int64bigintArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6044189622722136315L,

3048450325716078484L,

1647020436366481974L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
840921772342802738L,

6787463846644163498L,

311408978166051137L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8891912987752767446L,

8880099916101051511L,

532844016455297945L,

1590103451448955018L,

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintArray2M.AssertModel(models[0],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                int resultIndex = 0;
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 121, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[30], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 147, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintArray2M.AssertModel(models[0],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintArray2M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 58, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintArray2M.AssertModel(models[0],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
Int64bigintArray2M.AssertModel(models[0],_testData[9], false);Int64bigintArray2M.AssertModel(models[1],_testData[10], false);Int64bigintArray2M.AssertModel(models[2],_testData[11], false);Int64bigintArray2M.AssertModel(models[3],_testData[12], false);Int64bigintArray2M.AssertModel(models[4],_testData[13], false);Int64bigintArray2M.AssertModel(models[5],_testData[14], false);Int64bigintArray2M.AssertModel(models[6],_testData[15], false);Int64bigintArray2M.AssertModel(models[7],_testData[16], false);Int64bigintArray2M.AssertModel(models[8],_testData[17], false);Int64bigintArray2M.AssertModel(models[9],_testData[18], false);Int64bigintArray2M.AssertModel(models[10],_testData[19], false);Int64bigintArray2M.AssertModel(models[11],_testData[20], false);Int64bigintArray2M.AssertModel(models[12],_testData[21], false);Int64bigintArray2M.AssertModel(models[13],_testData[22], false);Int64bigintArray2M.AssertModel(models[14],_testData[23], false);Int64bigintArray2M.AssertModel(models[15],_testData[24], false);Int64bigintArray2M.AssertModel(models[16],_testData[25], false);Int64bigintArray2M.AssertModel(models[17],_testData[26], false);Int64bigintArray2M.AssertModel(models[18],_testData[27], false);Int64bigintArray2M.AssertModel(models[19],_testData[28], false);Int64bigintArray2M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Int64bigintArray2M.AssertModel(models[0],_testData[13], false);Int64bigintArray2M.AssertModel(models[1],_testData[14], false);Int64bigintArray2M.AssertModel(models[2],_testData[15], false);Int64bigintArray2M.AssertModel(models[3],_testData[16], false);Int64bigintArray2M.AssertModel(models[4],_testData[17], false);Int64bigintArray2M.AssertModel(models[5],_testData[18], false);Int64bigintArray2M.AssertModel(models[6],_testData[19], false);Int64bigintArray2M.AssertModel(models[7],_testData[20], false);Int64bigintArray2M.AssertModel(models[8],_testData[21], false);Int64bigintArray2M.AssertModel(models[9],_testData[22], false);Int64bigintArray2M.AssertModel(models[10],_testData[23], false);Int64bigintArray2M.AssertModel(models[11],_testData[24], false);Int64bigintArray2M.AssertModel(models[12],_testData[25], false);Int64bigintArray2M.AssertModel(models[13],_testData[26], false);Int64bigintArray2M.AssertModel(models[14],_testData[27], false);Int64bigintArray2M.AssertModel(models[15],_testData[28], false);Int64bigintArray2M.AssertModel(models[16],_testData[29], false);
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

