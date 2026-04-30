

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
    internal partial interface INpgsqlPointSingleTypepoint
    {
    }
    
    internal partial class NpgsqlPointSingleTypepoint : INpgsqlPointSingleTypepoint
    {


#region TestData

        private readonly NpgsqlPointpoint0M[] _testData = new NpgsqlPointpoint0M[]
        {
            new NpgsqlPointpoint0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.14034787918183078d, y: 0.2917796708090943d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5142252688993406d, y: 0.9510323683619298d),
},
            new NpgsqlPointpoint0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5540211704918686d, y: 0.32828147296557453d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4590905386971399d, y: 0.7292996401042015d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.060667253158490975d, y: 0.6459789509256323d),
},
            new NpgsqlPointpoint0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7741088555718589d, y: 0.877900101830219d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.82897448796887d, y: 0.16712274899411395d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.021219742824783228d, y: 0.13221747909828907d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5931055761664956d, y: 0.20984004040113413d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9119413921554247d, y: 0.14771800468476015d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6133735029197289d, y: 0.29742512865470916d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6540151481257208d, y: 0.7468427257045859d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6384987473255337d, y: 0.8750516625336786d),
},
            new NpgsqlPointpoint0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17259591619010684d, y: 0.6947137357726074d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8396638058138752d, y: 0.24067832696097258d),
},
            new NpgsqlPointpoint0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1900456459487384d, y: 0.10444048965062513d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7023816810089606d, y: 0.004006148273438148d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6695740757423503d, y: 0.09135382044798501d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.746376879178738d, y: 0.5291545020208005d),
},
            new NpgsqlPointpoint0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5510888366273882d, y: 0.44541693628896706d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9881221447216199d, y: 0.11700182198569054d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.05993432966289469d, y: 0.20535622521766195d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2295086821094795d, y: 0.07846771701991062d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7739799563605839d, y: 0.17224158879268392d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1326839168816074d, y: 0.9474550615082993d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.40850858019636804d, y: 0.9472876529108862d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.06871645939547244d, y: 0.21391905354782226d),
},
            new NpgsqlPointpoint0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.80267653630969d, y: 0.0501242046078646d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9216270913693774d, y: 0.46923730226106686d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5767621167533794d, y: 0.5281235811095248d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.32479073095703725d, y: 0.6417085910134546d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7525314720107193d, y: 0.3988176802301834d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7799031354758619d, y: 0.10793995080781982d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5137294889612507d, y: 0.06483062883829427d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.06436491836461689d, y: 0.5181126217960454d),
},
            new NpgsqlPointpoint0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6783276879825811d, y: 0.8814727405346879d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9494485558062017d, y: 0.8349589447780227d),
},
            new NpgsqlPointpoint0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9064529230048357d, y: 0.8626582646458341d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6765607612860621d, y: 0.016882603929877837d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9521014440232533d, y: 0.07028013763637819d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.38402463034870393d, y: 0.7366498168019127d),
},
            new NpgsqlPointpoint0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.19553838336203422d, y: 0.8492880611499957d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12326961072069054d, y: 0.9181062250959803d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.08006189892809057d, y: 0.3235880751216611d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7316835083935853d, y: 0.9494604028377477d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.07748780205669314d, y: 0.5140673592317461d),
},
            new NpgsqlPointpoint0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.671868391637495d, y: 0.6534055099171588d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3044786739609906d, y: 0.036680852015698484d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9532829474661282d, y: 0.6370259641638654d),
},
            new NpgsqlPointpoint0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.35582312336791844d, y: 0.9349450226276849d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3043803458340997d, y: 0.4378888679903711d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9160049048240809d, y: 0.9717486058397139d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.848432739990288d, y: 0.8042358244082145d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8493252602178967d, y: 0.9206468868238991d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.38091789737471593d, y: 0.21861527931031266d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8328710272947764d, y: 0.3229603040763054d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5311825340524028d, y: 0.9691344115768327d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.10263168647993026d, y: 0.6240582123082862d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17270561516902305d, y: 0.6252317055934338d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.31950251029492815d, y: 0.6222060504165566d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6545577715768157d, y: 0.3455177266704449d),
},
            new NpgsqlPointpoint0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7962235756464077d, y: 0.6535245442207336d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.24010651005574346d, y: 0.6351771620169d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4336001840250969d, y: 0.2183139701243858d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2729958226018637d, y: 0.6890113319059981d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.48057194509914614d, y: 0.29019724800069946d),
},
            new NpgsqlPointpoint0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8082605954189865d, y: 0.973774276391008d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29017120723116174d, y: 0.8661562023981999d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.324318141940914d, y: 0.06822715508216759d),
},
            new NpgsqlPointpoint0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.89695868533989d, y: 0.4030070730378883d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.522280984606502d, y: 0.9867123055818511d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1070803942937425d, y: 0.8814697142312042d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6386985420027397d, y: 0.4103012252384399d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7841168734862647d, y: 0.9604588410698348d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6384987473255337d, y: 0.8750516625336786d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8396638058138752d, y: 0.24067832696097258d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.746376879178738d, y: 0.5291545020208005d)));
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06871645939547244d, y: 0.21391905354782226d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpoint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPoint), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpointpoint0mi_id", 
                methodParametrName: "npgsqlpointpoint0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 67;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 4, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 40, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[15], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[16], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[17], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[18], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[19], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[20], false);NpgsqlPointpoint0M.AssertModel(models[7],_testData[21], false);NpgsqlPointpoint0M.AssertModel(models[8],_testData[22], false);NpgsqlPointpoint0M.AssertModel(models[9],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[10],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[11],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[12],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[13],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[14],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[15],_testData[29], false);NpgsqlPointpoint0M.AssertModel(models[16],_testData[30], false);NpgsqlPointpoint0M.AssertModel(models[17],_testData[31], false);NpgsqlPointpoint0M.AssertModel(models[18],_testData[32], false);NpgsqlPointpoint0M.AssertModel(models[19],_testData[33], false);NpgsqlPointpoint0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14034787918183078d, y: 0.2917796708090943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5142252688993406d, y: 0.9510323683619298d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5540211704918686d, y: 0.32828147296557453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4590905386971399d, y: 0.7292996401042015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.060667253158490975d, y: 0.6459789509256323d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7741088555718589d, y: 0.877900101830219d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.82897448796887d, y: 0.16712274899411395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.021219742824783228d, y: 0.13221747909828907d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5931055761664956d, y: 0.20984004040113413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9119413921554247d, y: 0.14771800468476015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6133735029197289d, y: 0.29742512865470916d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6540151481257208d, y: 0.7468427257045859d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6384987473255337d, y: 0.8750516625336786d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17259591619010684d, y: 0.6947137357726074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8396638058138752d, y: 0.24067832696097258d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1900456459487384d, y: 0.10444048965062513d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7023816810089606d, y: 0.004006148273438148d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6695740757423503d, y: 0.09135382044798501d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.746376879178738d, y: 0.5291545020208005d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5510888366273882d, y: 0.44541693628896706d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9881221447216199d, y: 0.11700182198569054d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05993432966289469d, y: 0.20535622521766195d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2295086821094795d, y: 0.07846771701991062d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7739799563605839d, y: 0.17224158879268392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1326839168816074d, y: 0.9474550615082993d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40850858019636804d, y: 0.9472876529108862d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06871645939547244d, y: 0.21391905354782226d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.80267653630969d, y: 0.0501242046078646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9216270913693774d, y: 0.46923730226106686d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5767621167533794d, y: 0.5281235811095248d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.32479073095703725d, y: 0.6417085910134546d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7525314720107193d, y: 0.3988176802301834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7799031354758619d, y: 0.10793995080781982d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5137294889612507d, y: 0.06483062883829427d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06436491836461689d, y: 0.5181126217960454d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6783276879825811d, y: 0.8814727405346879d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9494485558062017d, y: 0.8349589447780227d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9064529230048357d, y: 0.8626582646458341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6765607612860621d, y: 0.016882603929877837d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9521014440232533d, y: 0.07028013763637819d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38402463034870393d, y: 0.7366498168019127d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19553838336203422d, y: 0.8492880611499957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12326961072069054d, y: 0.9181062250959803d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08006189892809057d, y: 0.3235880751216611d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7316835083935853d, y: 0.9494604028377477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07748780205669314d, y: 0.5140673592317461d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.671868391637495d, y: 0.6534055099171588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3044786739609906d, y: 0.036680852015698484d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9532829474661282d, y: 0.6370259641638654d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35582312336791844d, y: 0.9349450226276849d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3043803458340997d, y: 0.4378888679903711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9160049048240809d, y: 0.9717486058397139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.848432739990288d, y: 0.8042358244082145d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8493252602178967d, y: 0.9206468868238991d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38091789737471593d, y: 0.21861527931031266d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8328710272947764d, y: 0.3229603040763054d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5311825340524028d, y: 0.9691344115768327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10263168647993026d, y: 0.6240582123082862d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17270561516902305d, y: 0.6252317055934338d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31950251029492815d, y: 0.6222060504165566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6545577715768157d, y: 0.3455177266704449d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7962235756464077d, y: 0.6535245442207336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24010651005574346d, y: 0.6351771620169d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4336001840250969d, y: 0.2183139701243858d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2729958226018637d, y: 0.6890113319059981d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48057194509914614d, y: 0.29019724800069946d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8082605954189865d, y: 0.973774276391008d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29017120723116174d, y: 0.8661562023981999d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.324318141940914d, y: 0.06822715508216759d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.89695868533989d, y: 0.4030070730378883d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.522280984606502d, y: 0.9867123055818511d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1070803942937425d, y: 0.8814697142312042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6386985420027397d, y: 0.4103012252384399d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7841168734862647d, y: 0.9604588410698348d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14034787918183078d, y: 0.2917796708090943d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5142252688993406d, y: 0.9510323683619298d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5540211704918686d, y: 0.32828147296557453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4590905386971399d, y: 0.7292996401042015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.060667253158490975d, y: 0.6459789509256323d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7741088555718589d, y: 0.877900101830219d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.82897448796887d, y: 0.16712274899411395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.021219742824783228d, y: 0.13221747909828907d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5931055761664956d, y: 0.20984004040113413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9119413921554247d, y: 0.14771800468476015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6133735029197289d, y: 0.29742512865470916d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6540151481257208d, y: 0.7468427257045859d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6384987473255337d, y: 0.8750516625336786d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17259591619010684d, y: 0.6947137357726074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8396638058138752d, y: 0.24067832696097258d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1900456459487384d, y: 0.10444048965062513d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7023816810089606d, y: 0.004006148273438148d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6695740757423503d, y: 0.09135382044798501d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.746376879178738d, y: 0.5291545020208005d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5510888366273882d, y: 0.44541693628896706d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9881221447216199d, y: 0.11700182198569054d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05993432966289469d, y: 0.20535622521766195d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2295086821094795d, y: 0.07846771701991062d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7739799563605839d, y: 0.17224158879268392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1326839168816074d, y: 0.9474550615082993d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.40850858019636804d, y: 0.9472876529108862d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06871645939547244d, y: 0.21391905354782226d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.80267653630969d, y: 0.0501242046078646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9216270913693774d, y: 0.46923730226106686d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5767621167533794d, y: 0.5281235811095248d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.32479073095703725d, y: 0.6417085910134546d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7525314720107193d, y: 0.3988176802301834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7799031354758619d, y: 0.10793995080781982d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5137294889612507d, y: 0.06483062883829427d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06436491836461689d, y: 0.5181126217960454d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6783276879825811d, y: 0.8814727405346879d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9494485558062017d, y: 0.8349589447780227d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9064529230048357d, y: 0.8626582646458341d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6765607612860621d, y: 0.016882603929877837d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9521014440232533d, y: 0.07028013763637819d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38402463034870393d, y: 0.7366498168019127d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19553838336203422d, y: 0.8492880611499957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12326961072069054d, y: 0.9181062250959803d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08006189892809057d, y: 0.3235880751216611d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7316835083935853d, y: 0.9494604028377477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07748780205669314d, y: 0.5140673592317461d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.671868391637495d, y: 0.6534055099171588d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3044786739609906d, y: 0.036680852015698484d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9532829474661282d, y: 0.6370259641638654d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35582312336791844d, y: 0.9349450226276849d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3043803458340997d, y: 0.4378888679903711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9160049048240809d, y: 0.9717486058397139d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.848432739990288d, y: 0.8042358244082145d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8493252602178967d, y: 0.9206468868238991d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38091789737471593d, y: 0.21861527931031266d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8328710272947764d, y: 0.3229603040763054d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5311825340524028d, y: 0.9691344115768327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10263168647993026d, y: 0.6240582123082862d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17270561516902305d, y: 0.6252317055934338d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31950251029492815d, y: 0.6222060504165566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6545577715768157d, y: 0.3455177266704449d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7962235756464077d, y: 0.6535245442207336d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.24010651005574346d, y: 0.6351771620169d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4336001840250969d, y: 0.2183139701243858d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2729958226018637d, y: 0.6890113319059981d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.48057194509914614d, y: 0.29019724800069946d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8082605954189865d, y: 0.973774276391008d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29017120723116174d, y: 0.8661562023981999d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.324318141940914d, y: 0.06822715508216759d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.89695868533989d, y: 0.4030070730378883d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.522280984606502d, y: 0.9867123055818511d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1070803942937425d, y: 0.8814697142312042d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6386985420027397d, y: 0.4103012252384399d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7841168734862647d, y: 0.9604588410698348d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
FROM public.binary_npgsqlpointpoint0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

