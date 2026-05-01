

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
7762828003980356505L,

5507896668094166813L,

7513126473140837977L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7025676039456547871L,

2269921034352478L,

6340426012457658773L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1377887146449576564L,

3905658543088030036L,

394145177990457751L,

5760677630214390872L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5585953915515383866L,

2516908551350267417L,

2862402647593447200L,

},
},
            new Int64bigintArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3852762097586999916L,

4975911680614624536L,

4596301046630132563L,

2039872561481099057L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4498531185432442607L,

4216412129122999491L,

6003212868852991998L,

7184708413808276950L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1230246094347612475L,

8897848149331155489L,

8343530712138755772L,

3086379272398145818L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8426610013899125367L,

8764568110586170954L,

8038135689708826824L,

6133542644261318219L,

},
},
            new Int64bigintArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5402981057044543736L,

2554807896224468221L,

8618935242021862268L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5202573614322688778L,

1251168147656578447L,

6889136200554242640L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8427333847129806593L,

1240443398520083024L,

7882989885120717670L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3422166270883936993L,

7430662879678494718L,

1754622614766710099L,

},
},
            new Int64bigintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4803439197311137731L,

2253602531801110029L,

5810750295204368171L,

1943239835677718754L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3124357136351567948L,

2456432680449532591L,

7299950634301659811L,

4795847236236895157L,

},
},
            new Int64bigintArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8564924093996285887L,

4073476583608141924L,

2103056673437741023L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7037501813043207966L,

4823620966949173197L,

3124418334638065141L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1457614742333374718L,

9148275344558257065L,

5950100204400698798L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8837165154894783738L,

4481093916883157304L,

1081978933893865304L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6457892698669996817L,

1073504589308342478L,

2391287166677496119L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7462854676524890009L,

5223700533008808103L,

5210445506068360552L,

1019008334453997866L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1994330075373986212L,

1656086163457561150L,

281736571596424067L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3925666600200132937L,

8268686568592170674L,

7139818375245265869L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4434541745520958416L,

3327822696493646347L,

5905529698661132746L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1217777369760637289L,

8956646873784647625L,

1721351079621387112L,

3397420437494171738L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5001237053009186233L,

7651655005575157303L,

1113186565132941873L,

},
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1703837164430866796L,

1047715981436176122L,

7699866234703515625L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6148774840858816091L,

5945298762968627681L,

5943617607983864822L,

7003518380212469492L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1081362450149833186L,

6616852363265289434L,

2630519378482239900L,

5137785755315295744L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7285100895562775870L,

8510895316238194771L,

7972969666034114772L,

7927930382191726413L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9119282631771839164L,

5054364275328259557L,

4503280489510409179L,

9145340612114738141L,

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
5913290572653863559L,

2259386683981594420L,

780268077379620897L,

9145014199142311932L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1043241299050548811L,

1885870968044428848L,

3467812910330724119L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4335693411612435473L,

311482586447331756L,

3201887427985052894L,

3768767579084232839L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3102271895121109194L,

2572255446126954280L,

9185302539308819602L,

3154928995635944723L,

},
},
            new Int64bigintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4457265197080661454L,

1599582623797500326L,

171633000334900063L,

1124007381498993615L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5743296192728108468L,

3520741738897090915L,

7445233499186707352L,

6123962131388506886L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4121772279855518150L,

6397905146291383735L,

3298491639516760522L,

6883591555310650365L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5555454004869446613L,

6889153353741919446L,

7673608762641986488L,

1588716266874734348L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
107994086110388138L,

5090400429491292324L,

7810573717030922474L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7523714231192904378L,

731460477109975165L,

7289043315073735745L,

2065425735769181447L,

},
},
            new Int64bigintArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8757344676767733827L,

8566806816281673746L,

5012028131070965695L,

5200376487100294255L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4686477406419777934L,

7433872289479118228L,

7688162928573834895L,

2700445701553440557L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1701939110820398453L,

7469465707759216164L,

2125131485910327086L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3757765218645708002L,

2027223092988113684L,

3592956451283229823L,

},
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1576705184463254210L,

7859973151655719181L,

2049306743330527779L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
782417149848787547L,

2091887422564397808L,

519256151313367562L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6821821710844004061L,

3405747317354578532L,

1561476225331361783L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9134659808399872547L,

7470851208736773297L,

2324859031848950862L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8558013981211271395L,

2271257537448245154L,

4750217770057417266L,

95724682635839936L,

},
},
            new Int64bigintArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7824575183396691535L,

8758375143100571094L,

2889515512360640238L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8545092045627778709L,

2997898362407179630L,

1973110617111874953L,

},
},
            new Int64bigintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5239747884752871188L,

6256922814766871441L,

425043044354606287L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7111691968770428542L,

2616341201052538210L,

699470673899085861L,

3781708079889619075L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7687161309309697964L,

3207964402154049013L,

8247321472802233589L,

8508175170082505341L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8531765522013110941L,

4372512178673983990L,

7911055475701304444L,

5617690733794105025L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1042744638459686950L,

4221898324243631605L,

3399546625771930103L,

4738395612107530397L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6105031262939714393L,

5517170129434525088L,

3559295128957386456L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3580488187301322180L,

705430800619504654L,

3735828489372697455L,

},
},
            new Int64bigintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7692354220961122822L,

3565348605187085632L,

8613865279271582940L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6239767378180894435L,

233606479652105526L,

3974354116313965659L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4782096880435401874L,

2773941851590152186L,

2179898996839646905L,

2094004598945787797L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2812659974388765622L,

756473364242064781L,

3378830418860762178L,

4830857990117661190L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7995455198260900803L,

4594637699734171714L,

4453358173466077730L,

},
},
            new Int64bigintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7776022800397614272L,

4892154431281068103L,

4052738193603808438L,

4560720581915377549L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3911397228762414442L,

8701644764533065341L,

8553615960614726885L,

1968368454282168630L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3391011182061794752L,

8415786936768309102L,

2611567311299106568L,

7529013284663650499L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6199910722750776841L,

6634913845393721242L,

75578545143967166L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2784404750055625082L,

5776343624113056486L,

1968538971787685511L,

},
},
            new Int64bigintArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7726493352813781591L,

5894380465329046116L,

8870988333297981426L,

1836145529349088876L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2763713705776859530L,

6686276973206465486L,

1424203486051600110L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8858010468874811206L,

6977212766876204352L,

9148151873972176046L,

},
},
            new Int64bigintArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8563354311722757219L,

3294865652827890591L,

1447042579890124538L,

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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[34], false);
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
                parametr2.Value = 11;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray2M.AssertModel(models[0],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 95, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 95, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 138, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintArray2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 61, 15))
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
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        Int64bigintArray2M.AssertModel(models[26],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[34], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

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
                Int64bigintArray2M.AssertModel(models[10],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[34], false);
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

                Int64bigintArray2M.AssertModel(models[0],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[34], false);
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

