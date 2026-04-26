

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
    Id = 4,
    Value = new System.Numerics.BigInteger(3234483892175036122L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 7,
    Value = new System.Numerics.BigInteger(6124428592201589064L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 4,
    Value = new System.Numerics.BigInteger(5476603742170443452L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(7253788205562719445L),
},
            new BigIntegernumeric0M
{
    Id = 11,
    Value = new System.Numerics.BigInteger(3765589386058918977L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(7281898994776226196L),
},
            new BigIntegernumeric0M
{
    Id = 20,
    Value = new System.Numerics.BigInteger(705863995940828154L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 12,
    Value = new System.Numerics.BigInteger(2497301506429482687L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 22,
    Value = new System.Numerics.BigInteger(6122513760801408287L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5467727801380954085L),
},
            new BigIntegernumeric0M
{
    Id = 31,
    Value = new System.Numerics.BigInteger(4009481003408076586L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 15,
    Value = new System.Numerics.BigInteger(1852086714548843971L),
    NullableValue = new System.Numerics.BigInteger(6851575723223028576L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 37,
    Value = new System.Numerics.BigInteger(584452454074167658L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 42,
    Value = new System.Numerics.BigInteger(7747990417449241288L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 18,
    Value = new System.Numerics.BigInteger(6078436384297484183L),
    NullableValue = new System.Numerics.BigInteger(1743231951550397135L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 50,
    Value = new System.Numerics.BigInteger(3161165858143049208L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(7433686834320308817L),
},
            new BigIntegernumeric0M
{
    Id = 55,
    Value = new System.Numerics.BigInteger(3819545198210938012L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 22,
    Value = new System.Numerics.BigInteger(6188665750629730222L),
    NullableValue = new System.Numerics.BigInteger(3580838830829461240L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 64,
    Value = new System.Numerics.BigInteger(2007464839829727971L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(528698414074534779L),
},
            new BigIntegernumeric0M
{
    Id = 72,
    Value = new System.Numerics.BigInteger(7315747221256118159L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 24,
    Value = new System.Numerics.BigInteger(4818987280606197737L),
    NullableValue = new System.Numerics.BigInteger(182769020503670021L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 75,
    Value = new System.Numerics.BigInteger(2970730687892684537L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 77,
    Value = new System.Numerics.BigInteger(6948686187369974795L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 32,
    Value = new System.Numerics.BigInteger(2362002985617509983L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(6196112313178000144L),
},
            new BigIntegernumeric0M
{
    Id = 84,
    Value = new System.Numerics.BigInteger(7256829598109064236L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 90,
    Value = new System.Numerics.BigInteger(5364727909942108933L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 35,
    Value = new System.Numerics.BigInteger(46000261630332301L),
    NullableValue = new System.Numerics.BigInteger(8543568444291344211L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 92,
    Value = new System.Numerics.BigInteger(2053252445995543976L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 97,
    Value = new System.Numerics.BigInteger(6390705816469252163L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 40,
    Value = new System.Numerics.BigInteger(4066398588141493634L),
    NullableValue = new System.Numerics.BigInteger(6275986268990399090L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 101,
    Value = new System.Numerics.BigInteger(2445626085477865451L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8601336938216210382L),
},
            new BigIntegernumeric0M
{
    Id = 109,
    Value = new System.Numerics.BigInteger(2893520888449466847L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 43,
    Value = new System.Numerics.BigInteger(8982939266616105577L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(7547432004691578437L),
},
            new BigIntegernumeric0M
{
    Id = 117,
    Value = new System.Numerics.BigInteger(4561671920753127540L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5329294081946377721L),
},
            new BigIntegernumeric0M
{
    Id = 121,
    Value = new System.Numerics.BigInteger(767492778642725975L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 47,
    Value = new System.Numerics.BigInteger(8428018950313698844L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(4674406122433754695L),
},
            new BigIntegernumeric0M
{
    Id = 125,
    Value = new System.Numerics.BigInteger(6081390294327927487L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4954210399046503851L),
},
            new BigIntegernumeric0M
{
    Id = 130,
    Value = new System.Numerics.BigInteger(8410521600062271826L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 51,
    Value = new System.Numerics.BigInteger(1103605421979253044L),
    NullableValue = new System.Numerics.BigInteger(4161074420288198606L),
},
    NullableValue = new System.Numerics.BigInteger(4052300875906292005L),
},
            new BigIntegernumeric0M
{
    Id = 136,
    Value = new System.Numerics.BigInteger(8055519000150893221L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 138,
    Value = new System.Numerics.BigInteger(6569145628533527891L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 59,
    Value = new System.Numerics.BigInteger(5971832194518221706L),
    NullableValue = new System.Numerics.BigInteger(4202919943871893181L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 141,
    Value = new System.Numerics.BigInteger(6735660545603479973L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 146,
    Value = new System.Numerics.BigInteger(888427977852504738L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 60,
    Value = new System.Numerics.BigInteger(6189762139874839213L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 154,
    Value = new System.Numerics.BigInteger(746020479631004411L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(3711286004030723008L),
},
            new BigIntegernumeric0M
{
    Id = 155,
    Value = new System.Numerics.BigInteger(7057991429333305139L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 62,
    Value = new System.Numerics.BigInteger(373000254125690530L),
    NullableValue = new System.Numerics.BigInteger(5642828142196963260L),
},
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((IBigIntegerSingleTypenumeric)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[7], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[8], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[9], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[10], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[11], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[18],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[19],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[20],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[21],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[29], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[6], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[7], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[8], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[9], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[10], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[11], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[18],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[19],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[20],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[21],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[22],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[23],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
BigIntegernumeric0M.AssertModel(models[0],_testData[7], false);BigIntegernumeric0M.AssertModel(models[1],_testData[8], false);BigIntegernumeric0M.AssertModel(models[2],_testData[9], false);BigIntegernumeric0M.AssertModel(models[3],_testData[10], false);BigIntegernumeric0M.AssertModel(models[4],_testData[11], false);BigIntegernumeric0M.AssertModel(models[5],_testData[12], false);BigIntegernumeric0M.AssertModel(models[6],_testData[13], false);BigIntegernumeric0M.AssertModel(models[7],_testData[14], false);BigIntegernumeric0M.AssertModel(models[8],_testData[15], false);BigIntegernumeric0M.AssertModel(models[9],_testData[16], false);BigIntegernumeric0M.AssertModel(models[10],_testData[17], false);BigIntegernumeric0M.AssertModel(models[11],_testData[18], false);BigIntegernumeric0M.AssertModel(models[12],_testData[19], false);BigIntegernumeric0M.AssertModel(models[13],_testData[20], false);BigIntegernumeric0M.AssertModel(models[14],_testData[21], false);BigIntegernumeric0M.AssertModel(models[15],_testData[22], false);BigIntegernumeric0M.AssertModel(models[16],_testData[23], false);BigIntegernumeric0M.AssertModel(models[17],_testData[24], false);BigIntegernumeric0M.AssertModel(models[18],_testData[25], false);BigIntegernumeric0M.AssertModel(models[19],_testData[26], false);BigIntegernumeric0M.AssertModel(models[20],_testData[27], false);BigIntegernumeric0M.AssertModel(models[21],_testData[28], false);BigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
BigIntegernumeric0M.AssertModel(models[0],_testData[15], false);BigIntegernumeric0M.AssertModel(models[1],_testData[16], false);BigIntegernumeric0M.AssertModel(models[2],_testData[17], false);BigIntegernumeric0M.AssertModel(models[3],_testData[18], false);BigIntegernumeric0M.AssertModel(models[4],_testData[19], false);BigIntegernumeric0M.AssertModel(models[5],_testData[20], false);BigIntegernumeric0M.AssertModel(models[6],_testData[21], false);BigIntegernumeric0M.AssertModel(models[7],_testData[22], false);BigIntegernumeric0M.AssertModel(models[8],_testData[23], false);BigIntegernumeric0M.AssertModel(models[9],_testData[24], false);BigIntegernumeric0M.AssertModel(models[10],_testData[25], false);BigIntegernumeric0M.AssertModel(models[11],_testData[26], false);BigIntegernumeric0M.AssertModel(models[12],_testData[27], false);BigIntegernumeric0M.AssertModel(models[13],_testData[28], false);BigIntegernumeric0M.AssertModel(models[14],_testData[29], false);
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

                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
BigIntegernumeric0M.AssertModel(models[0],_testData[1], false);BigIntegernumeric0M.AssertModel(models[1],_testData[2], false);BigIntegernumeric0M.AssertModel(models[2],_testData[3], false);BigIntegernumeric0M.AssertModel(models[3],_testData[4], false);BigIntegernumeric0M.AssertModel(models[4],_testData[5], false);BigIntegernumeric0M.AssertModel(models[5],_testData[6], false);BigIntegernumeric0M.AssertModel(models[6],_testData[7], false);BigIntegernumeric0M.AssertModel(models[7],_testData[8], false);BigIntegernumeric0M.AssertModel(models[8],_testData[9], false);BigIntegernumeric0M.AssertModel(models[9],_testData[10], false);BigIntegernumeric0M.AssertModel(models[10],_testData[11], false);BigIntegernumeric0M.AssertModel(models[11],_testData[12], false);BigIntegernumeric0M.AssertModel(models[12],_testData[13], false);BigIntegernumeric0M.AssertModel(models[13],_testData[14], false);BigIntegernumeric0M.AssertModel(models[14],_testData[15], false);BigIntegernumeric0M.AssertModel(models[15],_testData[16], false);BigIntegernumeric0M.AssertModel(models[16],_testData[17], false);BigIntegernumeric0M.AssertModel(models[17],_testData[18], false);BigIntegernumeric0M.AssertModel(models[18],_testData[19], false);BigIntegernumeric0M.AssertModel(models[19],_testData[20], false);BigIntegernumeric0M.AssertModel(models[20],_testData[21], false);BigIntegernumeric0M.AssertModel(models[21],_testData[22], false);BigIntegernumeric0M.AssertModel(models[22],_testData[23], false);BigIntegernumeric0M.AssertModel(models[23],_testData[24], false);BigIntegernumeric0M.AssertModel(models[24],_testData[25], false);BigIntegernumeric0M.AssertModel(models[25],_testData[26], false);BigIntegernumeric0M.AssertModel(models[26],_testData[27], false);BigIntegernumeric0M.AssertModel(models[27],_testData[28], false);BigIntegernumeric0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
BigIntegernumeric0M.AssertModel(models[0],_testData[13], false);BigIntegernumeric0M.AssertModel(models[1],_testData[14], false);BigIntegernumeric0M.AssertModel(models[2],_testData[15], false);BigIntegernumeric0M.AssertModel(models[3],_testData[16], false);BigIntegernumeric0M.AssertModel(models[4],_testData[17], false);BigIntegernumeric0M.AssertModel(models[5],_testData[18], false);BigIntegernumeric0M.AssertModel(models[6],_testData[19], false);BigIntegernumeric0M.AssertModel(models[7],_testData[20], false);BigIntegernumeric0M.AssertModel(models[8],_testData[21], false);BigIntegernumeric0M.AssertModel(models[9],_testData[22], false);BigIntegernumeric0M.AssertModel(models[10],_testData[23], false);BigIntegernumeric0M.AssertModel(models[11],_testData[24], false);BigIntegernumeric0M.AssertModel(models[12],_testData[25], false);BigIntegernumeric0M.AssertModel(models[13],_testData[26], false);BigIntegernumeric0M.AssertModel(models[14],_testData[27], false);BigIntegernumeric0M.AssertModel(models[15],_testData[28], false);BigIntegernumeric0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumeric0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[2], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[3], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[4], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[5], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[6], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[7], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[8], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[9], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[10], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[11], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[18],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[19],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[20],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[21],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[22],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[23],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[24],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[25],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[26],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[29], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[3], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[4], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[5], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[6], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[7], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[8], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[9], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[10], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[11], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[18],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[19],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[20],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[21],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[22],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[23],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[24],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[25],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatBigIntegernumeric0M.AssertModel(models[0],_testData[2], false);FlatBigIntegernumeric0M.AssertModel(models[1],_testData[3], false);FlatBigIntegernumeric0M.AssertModel(models[2],_testData[4], false);FlatBigIntegernumeric0M.AssertModel(models[3],_testData[5], false);FlatBigIntegernumeric0M.AssertModel(models[4],_testData[6], false);FlatBigIntegernumeric0M.AssertModel(models[5],_testData[7], false);FlatBigIntegernumeric0M.AssertModel(models[6],_testData[8], false);FlatBigIntegernumeric0M.AssertModel(models[7],_testData[9], false);FlatBigIntegernumeric0M.AssertModel(models[8],_testData[10], false);FlatBigIntegernumeric0M.AssertModel(models[9],_testData[11], false);FlatBigIntegernumeric0M.AssertModel(models[10],_testData[12], false);FlatBigIntegernumeric0M.AssertModel(models[11],_testData[13], false);FlatBigIntegernumeric0M.AssertModel(models[12],_testData[14], false);FlatBigIntegernumeric0M.AssertModel(models[13],_testData[15], false);FlatBigIntegernumeric0M.AssertModel(models[14],_testData[16], false);FlatBigIntegernumeric0M.AssertModel(models[15],_testData[17], false);FlatBigIntegernumeric0M.AssertModel(models[16],_testData[18], false);FlatBigIntegernumeric0M.AssertModel(models[17],_testData[19], false);FlatBigIntegernumeric0M.AssertModel(models[18],_testData[20], false);FlatBigIntegernumeric0M.AssertModel(models[19],_testData[21], false);FlatBigIntegernumeric0M.AssertModel(models[20],_testData[22], false);FlatBigIntegernumeric0M.AssertModel(models[21],_testData[23], false);FlatBigIntegernumeric0M.AssertModel(models[22],_testData[24], false);FlatBigIntegernumeric0M.AssertModel(models[23],_testData[25], false);FlatBigIntegernumeric0M.AssertModel(models[24],_testData[26], false);FlatBigIntegernumeric0M.AssertModel(models[25],_testData[27], false);FlatBigIntegernumeric0M.AssertModel(models[26],_testData[28], false);FlatBigIntegernumeric0M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelBatchAsync(connection, 84, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
BigIntegernumeric0M.AssertModel(models[0],_testData[15], false);BigIntegernumeric0M.AssertModel(models[1],_testData[16], false);BigIntegernumeric0M.AssertModel(models[2],_testData[17], false);BigIntegernumeric0M.AssertModel(models[3],_testData[18], false);BigIntegernumeric0M.AssertModel(models[4],_testData[19], false);BigIntegernumeric0M.AssertModel(models[5],_testData[20], false);BigIntegernumeric0M.AssertModel(models[6],_testData[21], false);BigIntegernumeric0M.AssertModel(models[7],_testData[22], false);BigIntegernumeric0M.AssertModel(models[8],_testData[23], false);BigIntegernumeric0M.AssertModel(models[9],_testData[24], false);BigIntegernumeric0M.AssertModel(models[10],_testData[25], false);BigIntegernumeric0M.AssertModel(models[11],_testData[26], false);BigIntegernumeric0M.AssertModel(models[12],_testData[27], false);BigIntegernumeric0M.AssertModel(models[13],_testData[28], false);BigIntegernumeric0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
BigIntegernumeric0M.AssertModel(models[0],_testData[11], false);BigIntegernumeric0M.AssertModel(models[1],_testData[12], false);BigIntegernumeric0M.AssertModel(models[2],_testData[13], false);BigIntegernumeric0M.AssertModel(models[3],_testData[14], false);BigIntegernumeric0M.AssertModel(models[4],_testData[15], false);BigIntegernumeric0M.AssertModel(models[5],_testData[16], false);BigIntegernumeric0M.AssertModel(models[6],_testData[17], false);BigIntegernumeric0M.AssertModel(models[7],_testData[18], false);BigIntegernumeric0M.AssertModel(models[8],_testData[19], false);BigIntegernumeric0M.AssertModel(models[9],_testData[20], false);BigIntegernumeric0M.AssertModel(models[10],_testData[21], false);BigIntegernumeric0M.AssertModel(models[11],_testData[22], false);BigIntegernumeric0M.AssertModel(models[12],_testData[23], false);BigIntegernumeric0M.AssertModel(models[13],_testData[24], false);BigIntegernumeric0M.AssertModel(models[14],_testData[25], false);BigIntegernumeric0M.AssertModel(models[15],_testData[26], false);BigIntegernumeric0M.AssertModel(models[16],_testData[27], false);BigIntegernumeric0M.AssertModel(models[17],_testData[28], false);BigIntegernumeric0M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumeric0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelBatch(connection, 72, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumeric0M.AssertModel(models[0],_testData[12], false);BigIntegernumeric0M.AssertModel(models[1],_testData[13], false);BigIntegernumeric0M.AssertModel(models[2],_testData[14], false);BigIntegernumeric0M.AssertModel(models[3],_testData[15], false);BigIntegernumeric0M.AssertModel(models[4],_testData[16], false);BigIntegernumeric0M.AssertModel(models[5],_testData[17], false);BigIntegernumeric0M.AssertModel(models[6],_testData[18], false);BigIntegernumeric0M.AssertModel(models[7],_testData[19], false);BigIntegernumeric0M.AssertModel(models[8],_testData[20], false);BigIntegernumeric0M.AssertModel(models[9],_testData[21], false);BigIntegernumeric0M.AssertModel(models[10],_testData[22], false);BigIntegernumeric0M.AssertModel(models[11],_testData[23], false);BigIntegernumeric0M.AssertModel(models[12],_testData[24], false);BigIntegernumeric0M.AssertModel(models[13],_testData[25], false);BigIntegernumeric0M.AssertModel(models[14],_testData[26], false);BigIntegernumeric0M.AssertModel(models[15],_testData[27], false);BigIntegernumeric0M.AssertModel(models[16],_testData[28], false);BigIntegernumeric0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
BigIntegernumeric0M.AssertModel(models[0],_testData[8], false);BigIntegernumeric0M.AssertModel(models[1],_testData[9], false);BigIntegernumeric0M.AssertModel(models[2],_testData[10], false);BigIntegernumeric0M.AssertModel(models[3],_testData[11], false);BigIntegernumeric0M.AssertModel(models[4],_testData[12], false);BigIntegernumeric0M.AssertModel(models[5],_testData[13], false);BigIntegernumeric0M.AssertModel(models[6],_testData[14], false);BigIntegernumeric0M.AssertModel(models[7],_testData[15], false);BigIntegernumeric0M.AssertModel(models[8],_testData[16], false);BigIntegernumeric0M.AssertModel(models[9],_testData[17], false);BigIntegernumeric0M.AssertModel(models[10],_testData[18], false);BigIntegernumeric0M.AssertModel(models[11],_testData[19], false);BigIntegernumeric0M.AssertModel(models[12],_testData[20], false);BigIntegernumeric0M.AssertModel(models[13],_testData[21], false);BigIntegernumeric0M.AssertModel(models[14],_testData[22], false);BigIntegernumeric0M.AssertModel(models[15],_testData[23], false);BigIntegernumeric0M.AssertModel(models[16],_testData[24], false);BigIntegernumeric0M.AssertModel(models[17],_testData[25], false);BigIntegernumeric0M.AssertModel(models[18],_testData[26], false);BigIntegernumeric0M.AssertModel(models[19],_testData[27], false);BigIntegernumeric0M.AssertModel(models[20],_testData[28], false);BigIntegernumeric0M.AssertModel(models[21],_testData[29], false);
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
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
BigIntegernumeric0M.AssertModel(models[0],_testData[26], false);BigIntegernumeric0M.AssertModel(models[1],_testData[27], false);BigIntegernumeric0M.AssertModel(models[2],_testData[28], false);BigIntegernumeric0M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
BigIntegernumeric0M.AssertModel(models[0],_testData[25], false);BigIntegernumeric0M.AssertModel(models[1],_testData[26], false);BigIntegernumeric0M.AssertModel(models[2],_testData[27], false);BigIntegernumeric0M.AssertModel(models[3],_testData[28], false);BigIntegernumeric0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3234483892175036122L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6124428592201589064L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5476603742170443452L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7253788205562719445L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3765589386058918977L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7281898994776226196L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(705863995940828154L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2497301506429482687L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6122513760801408287L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5467727801380954085L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4009481003408076586L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1852086714548843971L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6851575723223028576L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(584452454074167658L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7747990417449241288L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6078436384297484183L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1743231951550397135L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3161165858143049208L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7433686834320308817L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3819545198210938012L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6188665750629730222L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3580838830829461240L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2007464839829727971L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(528698414074534779L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7315747221256118159L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4818987280606197737L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(182769020503670021L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2970730687892684537L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6948686187369974795L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2362002985617509983L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6196112313178000144L))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7256829598109064236L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5364727909942108933L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(46000261630332301L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8543568444291344211L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2053252445995543976L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6390705816469252163L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4066398588141493634L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6275986268990399090L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2445626085477865451L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8601336938216210382L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2893520888449466847L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8982939266616105577L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7547432004691578437L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4561671920753127540L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5329294081946377721L))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(767492778642725975L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8428018950313698844L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4674406122433754695L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6081390294327927487L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4954210399046503851L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8410521600062271826L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1103605421979253044L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4161074420288198606L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4052300875906292005L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8055519000150893221L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6569145628533527891L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5971832194518221706L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4202919943871893181L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6735660545603479973L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(888427977852504738L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6189762139874839213L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(746020479631004411L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3711286004030723008L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7057991429333305139L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(373000254125690530L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5642828142196963260L))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3234483892175036122L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6124428592201589064L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5476603742170443452L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7253788205562719445L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3765589386058918977L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7281898994776226196L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(705863995940828154L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2497301506429482687L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6122513760801408287L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5467727801380954085L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4009481003408076586L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1852086714548843971L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6851575723223028576L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(584452454074167658L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7747990417449241288L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6078436384297484183L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1743231951550397135L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3161165858143049208L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7433686834320308817L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3819545198210938012L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6188665750629730222L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3580838830829461240L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2007464839829727971L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(528698414074534779L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7315747221256118159L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4818987280606197737L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(182769020503670021L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2970730687892684537L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6948686187369974795L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2362002985617509983L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6196112313178000144L))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7256829598109064236L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5364727909942108933L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(46000261630332301L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8543568444291344211L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2053252445995543976L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6390705816469252163L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4066398588141493634L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6275986268990399090L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2445626085477865451L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8601336938216210382L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2893520888449466847L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8982939266616105577L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7547432004691578437L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4561671920753127540L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5329294081946377721L))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(767492778642725975L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8428018950313698844L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4674406122433754695L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6081390294327927487L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4954210399046503851L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8410521600062271826L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1103605421979253044L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4161074420288198606L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4052300875906292005L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8055519000150893221L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6569145628533527891L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5971832194518221706L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4202919943871893181L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6735660545603479973L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(888427977852504738L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6189762139874839213L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(746020479631004411L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3711286004030723008L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7057991429333305139L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(373000254125690530L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5642828142196963260L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumeric0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(actual, expect, false);
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
                await ((IBigIntegerSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(BigIntegernumeric0M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumeric0M>(15);

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
                ((IBigIntegerSingleTypenumeric)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumeric0M.AssertModel(models[0],_testData[0], false);
                BigIntegernumeric0M.AssertModel(models[1],_testData[1], false);
                BigIntegernumeric0M.AssertModel(models[2],_testData[2], false);
                BigIntegernumeric0M.AssertModel(models[3],_testData[3], false);
                BigIntegernumeric0M.AssertModel(models[4],_testData[4], false);
                BigIntegernumeric0M.AssertModel(models[5],_testData[5], false);
                BigIntegernumeric0M.AssertModel(models[6],_testData[6], false);
                BigIntegernumeric0M.AssertModel(models[7],_testData[7], false);
                BigIntegernumeric0M.AssertModel(models[8],_testData[8], false);
                BigIntegernumeric0M.AssertModel(models[9],_testData[9], false);
                BigIntegernumeric0M.AssertModel(models[10],_testData[10], false);
                BigIntegernumeric0M.AssertModel(models[11],_testData[11], false);
                BigIntegernumeric0M.AssertModel(models[12],_testData[12], false);
                BigIntegernumeric0M.AssertModel(models[13],_testData[13], false);
                BigIntegernumeric0M.AssertModel(models[14],_testData[14], false);
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
                await ((IBigIntegerSingleTypenumeric)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumeric0M.AssertModel(models[0],_testData[0], false);
                BigIntegernumeric0M.AssertModel(models[1],_testData[1], false);
                BigIntegernumeric0M.AssertModel(models[2],_testData[2], false);
                BigIntegernumeric0M.AssertModel(models[3],_testData[3], false);
                BigIntegernumeric0M.AssertModel(models[4],_testData[4], false);
                BigIntegernumeric0M.AssertModel(models[5],_testData[5], false);
                BigIntegernumeric0M.AssertModel(models[6],_testData[6], false);
                BigIntegernumeric0M.AssertModel(models[7],_testData[7], false);
                BigIntegernumeric0M.AssertModel(models[8],_testData[8], false);
                BigIntegernumeric0M.AssertModel(models[9],_testData[9], false);
                BigIntegernumeric0M.AssertModel(models[10],_testData[10], false);
                BigIntegernumeric0M.AssertModel(models[11],_testData[11], false);
                BigIntegernumeric0M.AssertModel(models[12],_testData[12], false);
                BigIntegernumeric0M.AssertModel(models[13],_testData[13], false);
                BigIntegernumeric0M.AssertModel(models[14],_testData[14], false);
                BigIntegernumeric0M.AssertModel(models[15],_testData[15], false);
                BigIntegernumeric0M.AssertModel(models[16],_testData[16], false);
                BigIntegernumeric0M.AssertModel(models[17],_testData[17], false);
                BigIntegernumeric0M.AssertModel(models[18],_testData[18], false);
                BigIntegernumeric0M.AssertModel(models[19],_testData[19], false);
                BigIntegernumeric0M.AssertModel(models[20],_testData[20], false);
                BigIntegernumeric0M.AssertModel(models[21],_testData[21], false);
                BigIntegernumeric0M.AssertModel(models[22],_testData[22], false);
                BigIntegernumeric0M.AssertModel(models[23],_testData[23], false);
                BigIntegernumeric0M.AssertModel(models[24],_testData[24], false);
                BigIntegernumeric0M.AssertModel(models[25],_testData[25], false);
                BigIntegernumeric0M.AssertModel(models[26],_testData[26], false);
                BigIntegernumeric0M.AssertModel(models[27],_testData[27], false);
                BigIntegernumeric0M.AssertModel(models[28],_testData[28], false);
                BigIntegernumeric0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_bigintegernumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerSingleTypenumeric)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

