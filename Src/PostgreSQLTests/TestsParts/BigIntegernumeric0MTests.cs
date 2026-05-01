

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
    internal partial interface IBigIntegerSingleTypenumeric
    {
    }
    
    internal partial class BigIntegerSingleTypenumeric : IBigIntegerSingleTypenumeric
    {


#region TestData

        private readonly BigIntegernumeric0M[] _testData = new BigIntegernumeric0M[]
        {
            new BigIntegernumeric0M
{
    Id = 3,
    Value = new System.Numerics.BigInteger(4709852387752512386L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 8,
    Value = new System.Numerics.BigInteger(4607822434691902440L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 5,
    Value = new System.Numerics.BigInteger(7301547561708840261L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(6247153502464382452L),
},
            new BigIntegernumeric0M
{
    Id = 16,
    Value = new System.Numerics.BigInteger(55593696906876393L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(7254084903369943913L),
},
            new BigIntegernumeric0M
{
    Id = 24,
    Value = new System.Numerics.BigInteger(186214813506575363L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 10,
    Value = new System.Numerics.BigInteger(4168025700262277684L),
    NullableValue = new System.Numerics.BigInteger(647088365241098049L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 30,
    Value = new System.Numerics.BigInteger(2197169791945317177L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 31,
    Value = new System.Numerics.BigInteger(8038003568022165084L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 14,
    Value = new System.Numerics.BigInteger(7663506588936336176L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 32,
    Value = new System.Numerics.BigInteger(8128361669912656750L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 36,
    Value = new System.Numerics.BigInteger(1583694482355442319L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 17,
    Value = new System.Numerics.BigInteger(2155498335472434179L),
    NullableValue = new System.Numerics.BigInteger(1172326032862095511L),
},
    NullableValue = new System.Numerics.BigInteger(3520830047858655635L),
},
            new BigIntegernumeric0M
{
    Id = 39,
    Value = new System.Numerics.BigInteger(5709314171746713944L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 43,
    Value = new System.Numerics.BigInteger(667770813425990147L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 23,
    Value = new System.Numerics.BigInteger(8099085871325468591L),
    NullableValue = new System.Numerics.BigInteger(3904765891959914696L),
},
    NullableValue = new System.Numerics.BigInteger(31726214804698354L),
},
            new BigIntegernumeric0M
{
    Id = 48,
    Value = new System.Numerics.BigInteger(7923354264572677397L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 50,
    Value = new System.Numerics.BigInteger(8806622318103632617L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 29,
    Value = new System.Numerics.BigInteger(1689970011149945066L),
    NullableValue = new System.Numerics.BigInteger(3732010550366644297L),
},
    NullableValue = new System.Numerics.BigInteger(4465198151185199953L),
},
            new BigIntegernumeric0M
{
    Id = 57,
    Value = new System.Numerics.BigInteger(7533905219945746835L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 59,
    Value = new System.Numerics.BigInteger(6177442019703951490L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 35,
    Value = new System.Numerics.BigInteger(3030914281266535104L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 67,
    Value = new System.Numerics.BigInteger(4670651964864784100L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 70,
    Value = new System.Numerics.BigInteger(3449171341946954356L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 44,
    Value = new System.Numerics.BigInteger(5021739595701570048L),
    NullableValue = new System.Numerics.BigInteger(8708115603973435068L),
},
    NullableValue = new System.Numerics.BigInteger(2518096768126233329L),
},
            new BigIntegernumeric0M
{
    Id = 71,
    Value = new System.Numerics.BigInteger(944600309529405168L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2588672760372754321L),
},
            new BigIntegernumeric0M
{
    Id = 72,
    Value = new System.Numerics.BigInteger(994625683691948970L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 45,
    Value = new System.Numerics.BigInteger(3613783579751855692L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 75,
    Value = new System.Numerics.BigInteger(7054540286193867804L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8251030851636725721L),
},
            new BigIntegernumeric0M
{
    Id = 79,
    Value = new System.Numerics.BigInteger(1774893887942744206L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 46,
    Value = new System.Numerics.BigInteger(5382275009298909795L),
    NullableValue = new System.Numerics.BigInteger(6257857797710464234L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 86,
    Value = new System.Numerics.BigInteger(6532746272904051388L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 92,
    Value = new System.Numerics.BigInteger(9218657862081470755L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 49,
    Value = new System.Numerics.BigInteger(9194935746324304352L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(7461401052328359128L),
},
            new BigIntegernumeric0M
{
    Id = 95,
    Value = new System.Numerics.BigInteger(7872108269897758898L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1909437950136761009L),
},
            new BigIntegernumeric0M
{
    Id = 101,
    Value = new System.Numerics.BigInteger(8147205860534505362L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 55,
    Value = new System.Numerics.BigInteger(3284150039953341657L),
    NullableValue = new System.Numerics.BigInteger(2716764689728033815L),
},
    NullableValue = new System.Numerics.BigInteger(2199186558443144150L),
},
            new BigIntegernumeric0M
{
    Id = 104,
    Value = new System.Numerics.BigInteger(3314344875992607401L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 107,
    Value = new System.Numerics.BigInteger(3083241394209127114L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 59,
    Value = new System.Numerics.BigInteger(8588065936747721940L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(3846459875939389937L),
},
            new BigIntegernumeric0M
{
    Id = 112,
    Value = new System.Numerics.BigInteger(7618290331090048192L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8823750510014482358L),
},
            new BigIntegernumeric0M
{
    Id = 116,
    Value = new System.Numerics.BigInteger(2874357242567967803L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 68,
    Value = new System.Numerics.BigInteger(2517678067406663416L),
    NullableValue = new System.Numerics.BigInteger(4813288574910006238L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 119,
    Value = new System.Numerics.BigInteger(7818724038684053230L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1434652404028718827L),
},
            new BigIntegernumeric0M
{
    Id = 125,
    Value = new System.Numerics.BigInteger(8466528231255446729L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 76,
    Value = new System.Numerics.BigInteger(2568650189797204804L),
    NullableValue = new System.Numerics.BigInteger(8057001759113369051L),
},
    NullableValue = new System.Numerics.BigInteger(7017927246579076514L),
},
            new BigIntegernumeric0M
{
    Id = 129,
    Value = new System.Numerics.BigInteger(6214452322645656024L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 137,
    Value = new System.Numerics.BigInteger(6424215999311061577L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 83,
    Value = new System.Numerics.BigInteger(4105576912627134956L),
    NullableValue = new System.Numerics.BigInteger(8712147761753655724L),
},
    NullableValue = new System.Numerics.BigInteger(3892046628639083325L),
},
            new BigIntegernumeric0M
{
    Id = 138,
    Value = new System.Numerics.BigInteger(2958937166746695963L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2860965590460283618L),
},
            new BigIntegernumeric0M
{
    Id = 140,
    Value = new System.Numerics.BigInteger(8103868024373409671L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 85,
    Value = new System.Numerics.BigInteger(6799059264682964795L),
    NullableValue = new System.Numerics.BigInteger(7589963000481438474L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 149,
    Value = new System.Numerics.BigInteger(8325320383075492535L),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0mi(
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
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7), 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumeric0mi_id", 
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
                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
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
    bigintegernumeric0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
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
    bigintegernumeric0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumeric0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumeric0M> models = null;

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumeric0M> models = null;

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumeric0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bigintegernumeric0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Numerics.BigInteger), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bigintegernumeric0mi_id", 
                methodParametrName: "bigintegernumeric0mi_id", 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M), typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M), typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M), typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 43;
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M), typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 104, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumeric0M>();
                var models2 = new List<FlatBigIntegernumeric0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumeric0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var firstItems2 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[34], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 75, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[34], false);
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
FROM public.bigintegernumeric0m m
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
FROM public.bigintegernumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems1 = new List<FlatBigIntegernumeric0M>();
                var secondItems2 = new List<FlatBigIntegernumeric0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 125, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 30, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                BigIntegernumeric0M.AssertModel(models[0],_testData[10], false);
                BigIntegernumeric0M.AssertModel(models[1],_testData[11], false);
                BigIntegernumeric0M.AssertModel(models[2],_testData[12], false);
                BigIntegernumeric0M.AssertModel(models[3],_testData[13], false);
                BigIntegernumeric0M.AssertModel(models[4],_testData[14], false);
                BigIntegernumeric0M.AssertModel(models[5],_testData[15], false);
                BigIntegernumeric0M.AssertModel(models[6],_testData[16], false);
                BigIntegernumeric0M.AssertModel(models[7],_testData[17], false);
                BigIntegernumeric0M.AssertModel(models[8],_testData[18], false);
                BigIntegernumeric0M.AssertModel(models[9],_testData[19], false);
                BigIntegernumeric0M.AssertModel(models[10],_testData[20], false);
                BigIntegernumeric0M.AssertModel(models[11],_testData[21], false);
                BigIntegernumeric0M.AssertModel(models[12],_testData[22], false);
                BigIntegernumeric0M.AssertModel(models[13],_testData[23], false);
                BigIntegernumeric0M.AssertModel(models[14],_testData[24], false);
                BigIntegernumeric0M.AssertModel(models[15],_testData[25], false);
                BigIntegernumeric0M.AssertModel(models[16],_testData[26], false);
                BigIntegernumeric0M.AssertModel(models[17],_testData[27], false);
                BigIntegernumeric0M.AssertModel(models[18],_testData[28], false);
                BigIntegernumeric0M.AssertModel(models[19],_testData[29], false);
                BigIntegernumeric0M.AssertModel(models[20],_testData[30], false);
                BigIntegernumeric0M.AssertModel(models[21],_testData[31], false);
                BigIntegernumeric0M.AssertModel(models[22],_testData[32], false);
                BigIntegernumeric0M.AssertModel(models[23],_testData[33], false);
                BigIntegernumeric0M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumeric0M.AssertModel(models[0],_testData[15], false);
                BigIntegernumeric0M.AssertModel(models[1],_testData[16], false);
                BigIntegernumeric0M.AssertModel(models[2],_testData[17], false);
                BigIntegernumeric0M.AssertModel(models[3],_testData[18], false);
                BigIntegernumeric0M.AssertModel(models[4],_testData[19], false);
                BigIntegernumeric0M.AssertModel(models[5],_testData[20], false);
                BigIntegernumeric0M.AssertModel(models[6],_testData[21], false);
                BigIntegernumeric0M.AssertModel(models[7],_testData[22], false);
                BigIntegernumeric0M.AssertModel(models[8],_testData[23], false);
                BigIntegernumeric0M.AssertModel(models[9],_testData[24], false);
                BigIntegernumeric0M.AssertModel(models[10],_testData[25], false);
                BigIntegernumeric0M.AssertModel(models[11],_testData[26], false);
                BigIntegernumeric0M.AssertModel(models[12],_testData[27], false);
                BigIntegernumeric0M.AssertModel(models[13],_testData[28], false);
                BigIntegernumeric0M.AssertModel(models[14],_testData[29], false);
                BigIntegernumeric0M.AssertModel(models[15],_testData[30], false);
                BigIntegernumeric0M.AssertModel(models[16],_testData[31], false);
                BigIntegernumeric0M.AssertModel(models[17],_testData[32], false);
                BigIntegernumeric0M.AssertModel(models[18],_testData[33], false);
                BigIntegernumeric0M.AssertModel(models[19],_testData[34], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4709852387752512386L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4607822434691902440L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7301547561708840261L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6247153502464382452L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(55593696906876393L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7254084903369943913L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(186214813506575363L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4168025700262277684L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(647088365241098049L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2197169791945317177L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8038003568022165084L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7663506588936336176L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8128361669912656750L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1583694482355442319L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2155498335472434179L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1172326032862095511L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3520830047858655635L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5709314171746713944L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(667770813425990147L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8099085871325468591L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3904765891959914696L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(31726214804698354L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7923354264572677397L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8806622318103632617L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1689970011149945066L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3732010550366644297L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4465198151185199953L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7533905219945746835L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6177442019703951490L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3030914281266535104L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4670651964864784100L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3449171341946954356L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5021739595701570048L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8708115603973435068L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2518096768126233329L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(944600309529405168L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2588672760372754321L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(994625683691948970L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3613783579751855692L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7054540286193867804L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8251030851636725721L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1774893887942744206L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5382275009298909795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6257857797710464234L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6532746272904051388L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9218657862081470755L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9194935746324304352L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7461401052328359128L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7872108269897758898L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1909437950136761009L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8147205860534505362L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3284150039953341657L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2716764689728033815L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2199186558443144150L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3314344875992607401L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3083241394209127114L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8588065936747721940L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3846459875939389937L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7618290331090048192L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8823750510014482358L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2874357242567967803L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2517678067406663416L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4813288574910006238L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7818724038684053230L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1434652404028718827L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8466528231255446729L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2568650189797204804L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8057001759113369051L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7017927246579076514L))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6214452322645656024L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6424215999311061577L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4105576912627134956L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8712147761753655724L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3892046628639083325L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2958937166746695963L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2860965590460283618L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8103868024373409671L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6799059264682964795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7589963000481438474L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8325320383075492535L))));//Value

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
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4709852387752512386L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4607822434691902440L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7301547561708840261L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6247153502464382452L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(55593696906876393L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7254084903369943913L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(186214813506575363L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4168025700262277684L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(647088365241098049L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2197169791945317177L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8038003568022165084L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7663506588936336176L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8128361669912656750L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1583694482355442319L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2155498335472434179L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1172326032862095511L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3520830047858655635L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5709314171746713944L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(667770813425990147L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8099085871325468591L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3904765891959914696L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(31726214804698354L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7923354264572677397L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8806622318103632617L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1689970011149945066L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3732010550366644297L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4465198151185199953L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7533905219945746835L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6177442019703951490L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3030914281266535104L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4670651964864784100L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3449171341946954356L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5021739595701570048L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8708115603973435068L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2518096768126233329L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(944600309529405168L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2588672760372754321L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(994625683691948970L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3613783579751855692L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7054540286193867804L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8251030851636725721L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1774893887942744206L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5382275009298909795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6257857797710464234L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6532746272904051388L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9218657862081470755L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9194935746324304352L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7461401052328359128L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7872108269897758898L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1909437950136761009L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8147205860534505362L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3284150039953341657L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2716764689728033815L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2199186558443144150L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3314344875992607401L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3083241394209127114L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8588065936747721940L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3846459875939389937L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7618290331090048192L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8823750510014482358L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2874357242567967803L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2517678067406663416L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4813288574910006238L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7818724038684053230L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1434652404028718827L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8466528231255446729L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2568650189797204804L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8057001759113369051L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7017927246579076514L))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6214452322645656024L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6424215999311061577L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4105576912627134956L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8712147761753655724L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3892046628639083325L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2958937166746695963L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2860965590460283618L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8103868024373409671L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6799059264682964795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7589963000481438474L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8325320383075492535L))));//Value

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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerSingleTypenumeric)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumeric0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerSingleTypenumeric)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumeric0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumeric0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumeric0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumeric0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
FROM public.binary_bigintegernumeric0m m
LEFT JOIN public.binary_bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerSingleTypenumeric)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumeric0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumeric0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerSingleTypenumeric)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumeric0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumeric0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumeric0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumeric0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumeric0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA), typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA), typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI), typeof(BigIntegernumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models1 = new List<BigIntegernumeric0MI>();
                var models2 = new List<BigIntegernumeric0MI>();
                await ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumeric0MI>();
                var models2 = new List<BigIntegernumeric0MI>();
                ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models = await ((IBigIntegerSingleTypenumeric)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumeric0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA), typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumeric0MIWA>();
                var models2 = new List<BigIntegernumeric0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models = await ((IBigIntegerSingleTypenumeric)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

