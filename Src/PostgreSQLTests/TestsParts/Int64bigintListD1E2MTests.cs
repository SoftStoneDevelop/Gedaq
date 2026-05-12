

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
    internal partial interface IInt64ListbigintListD1
    {
    }
    
    internal partial class Int64ListbigintListD1 : IInt64ListbigintListD1
    {


#region TestData

        private readonly Int64bigintListD1E2M[] _testData = new Int64bigintListD1E2M[]
        {
            new Int64bigintListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8870769004100188942L,

5529109689056824587L,

270578675882586571L,

7912560129919441359L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6347794292858282283L,

4126707367171244096L,

7239404895975809789L,

},
},
            new Int64bigintListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
432118071071469905L,

6079411292655221841L,

2121897837206669060L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4402227181734116769L,

1847946490104977370L,

8211591318829376354L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5067718216062666818L,

7470207545295930631L,

2223342305345954720L,

5316183636588744511L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6807845483057664787L,

699724625695873143L,

4725569907925938340L,

7855580261926145775L,

},
},
            new Int64bigintListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2866348331422458517L,

5120229944645096599L,

3418759317732798243L,

5140007981069646321L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4313179266778987112L,

8656535513714193569L,

1545785521114691014L,

3475244977820658324L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1425161753679927424L,

797002846094552565L,

1636763603907347956L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1187303870233929274L,

2851539478039324741L,

2365735563796750296L,

7434327458736985714L,

},
},
            new Int64bigintListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6772379133171549396L,

9137458313012673403L,

4881558103702861807L,

6477447107682360939L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4764297396312605137L,

1715677927762537387L,

4549825975805454661L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7421911069548635223L,

4494630335601705786L,

2849272758768011150L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
418434877196493924L,

3798186563790217934L,

8493314671983373933L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
410218167410732021L,

1364466174433623401L,

8254521895570038802L,

},
},
            new Int64bigintListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
838129861434987438L,

4240530733801205697L,

3171629424007273308L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
570440167720611530L,

2088263769789448578L,

6158977614977189497L,

6106370734002031686L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
67476031565601345L,

7927399863766485012L,

6171649386991569987L,

3946052063283244770L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5360328063490612264L,

2176134400743411947L,

8727162219276574861L,

6461183034345824587L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
176153867237283043L,

1096275623353890753L,

6788737932229710821L,

4915232248406590135L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
87120004710427651L,

5008132481272922454L,

1405665113602924433L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9148658386073632412L,

5337426337034314580L,

251861118101719678L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8392235751618721484L,

6994046479563897697L,

3226517272378022516L,

3782811031031005426L,

},
},
            new Int64bigintListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2448340739077615829L,

6442974349701654707L,

5888050090009544273L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6347402177627149017L,

5612929557838545486L,

2990133382960645809L,

4298902545974237200L,

},
},
            new Int64bigintListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
156392752642298454L,

4187724292640259632L,

7599414684019017669L,

7811335006029639524L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1306294347476297875L,

7709280741684995342L,

6309162519090588791L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2464451802551336672L,

8672061664877722763L,

3094120312765033371L,

},
},
            new Int64bigintListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2428367709273045469L,

8143734547772245848L,

3836076744433435713L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
897415748220968843L,

5014099451670455305L,

5824002149994338968L,

4363418032335047232L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3437769328897278997L,

8224345019261394937L,

4056131462085136740L,

2258038743150190727L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155248810051154786L,

6179126084527523753L,

2689363905330836758L,

2021777368370860788L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2686584785742472219L,

430955401144110062L,

3205661261772286783L,

},
},
            new Int64bigintListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8625492492395494711L,

4281274674201723659L,

5824049928312674692L,

8901711221267489204L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7612321141265305999L,

7577918636889902527L,

4123469772893476646L,

8373399584836979778L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5091678321108359766L,

7701000891685417166L,

6342307831067009011L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5082733269755592454L,

4830924221201078114L,

8866773737493289633L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3528997193746587929L,

8935205203181481169L,

8631454067656216655L,

},
},
            new Int64bigintListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2543911967769772368L,

124969160481963670L,

8525992433617046264L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1459016488554694087L,

6056225692310616456L,

7800729424497151819L,

7733407209207269709L,

},
},
            new Int64bigintListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6446256710901740521L,

8205923264477223675L,

5613496449039243401L,

2618044490231123122L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3250455387087450656L,

1827140584226721810L,

3495371952686240212L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8934829306411760196L,

6707441911648434716L,

1590327036395120357L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6349654222238061547L,

5717173840886836993L,

6672000556182615848L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5980796812611305667L,

1532118155105331536L,

1608085386366566840L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8746021421267247646L,

3257772315926104476L,

7249036234850088275L,

8675793996674112803L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1309682934613537675L,

4439132379939398403L,

4677467938582429179L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6918285395840332994L,

243758830904826886L,

7701196994429060260L,

6186586152987560612L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3303589170648230751L,

1782295988284256349L,

7831702878782059553L,

8850347971964812583L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4486315873493944874L,

7287299828404106228L,

3656839919830604388L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6464626876881101981L,

3138473880120845407L,

4834279993933744247L,

5521006081112446807L,

},
},
            new Int64bigintListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5898256248113190496L,

7233997648253922645L,

2764320954750478948L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5993950609613283304L,

8868400517496388161L,

7999917657927722827L,

},
},
            new Int64bigintListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5811706298070005899L,

1558263479196427218L,

5403880406684403463L,

5228703491787734830L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4587277672750925569L,

6084940410562281554L,

9007655535885002674L,

1589324455908292642L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6247974557162709757L,

4377818364484065644L,

7028396878364998722L,

4678435061133083146L,

},
},
            new Int64bigintListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4597887674694040480L,

4202184600473702683L,

4243563998056212076L,

7399389070281491974L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9158750507313955185L,

5518579565742849265L,

8931029281807137833L,

3631199790804777530L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6666153259346756025L,

6538694537078306074L,

7466919417820894765L,

8877234431430643872L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5370313085784560172L,

8889533183860989687L,

8128471396719189789L,

1177812314317573148L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2288098160109600810L,

7759708374822591276L,

2092196136116304328L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3166727175017248821L,

3234572687313352335L,

7242259714007874098L,

7538697378441631700L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2829507621144400696L,

8939268296500826858L,

8237322057691456330L,

},
},
            new Int64bigintListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5114599781473813458L,

6652471098042254803L,

3182477957285888734L,

2784468074099893360L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7989485847374841L,

5200351743133538624L,

7211709403447841512L,

},
},
            new Int64bigintListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6105442882821531324L,

456509257321529216L,

5956334287376634114L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1157762141695233364L,

7783374691223303744L,

2972979170836135523L,

8146558610304441578L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1422833724699137983L,

810517601625878289L,

4227098770050102982L,

6296210994242660697L,

},
},
            new Int64bigintListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7674373057547816927L,

867528320055967930L,

1565108576423622956L,

2122557749373107205L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
985749165545054760L,

7321080609686901655L,

408241238101363073L,

6837943906514141641L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
428299370920983618L,

6652011717666944834L,

846785845499093154L,

6533583938216611559L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8861804995091556168L,

2054009756149250014L,

4029605458582788622L,

1629492893401058480L,

},
},
            new Int64bigintListD1E2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2054891520333809927L,

359079808591811762L,

5155283715757969710L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1102046711865579636L,

7054972354597458101L,

2874008967731576149L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
682120669964084376L,

252081063026965485L,

5883890232587747650L,

172079000833947530L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3402715614148789479L,

2700882955851104579L,

3075454613461684187L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1380125919724564394L,

1661636663762108642L,

8090924960590279696L,

2589866337404637215L,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2mi(
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
INSERT INTO public.int64bigintlistd1e2mi(
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
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
            asPartInterface: typeof(IInt64ListbigintListD1)), 
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
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                List<Int64bigintListD1E2M> models = null;

                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintListD1E2M> models = null;

                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 181;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 55;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 165;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 181, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 124, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 92, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 137, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MI),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintListD1E2M),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
FROM public.binary_int64bigintlistd1e2m m
LEFT JOIN public.binary_int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models =  ((IInt64ListbigintListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI), typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                await ((IInt64ListbigintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                ((IInt64ListbigintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

