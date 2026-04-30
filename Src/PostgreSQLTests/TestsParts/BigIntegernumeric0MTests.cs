

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
    Value = new System.Numerics.BigInteger(1382215236322383847L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 9,
    Value = new System.Numerics.BigInteger(4826934197229547153L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 3,
    Value = new System.Numerics.BigInteger(3703027886457332134L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(4151479429984842978L),
},
            new BigIntegernumeric0M
{
    Id = 18,
    Value = new System.Numerics.BigInteger(3326957719092086962L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8554294256459815419L),
},
            new BigIntegernumeric0M
{
    Id = 25,
    Value = new System.Numerics.BigInteger(5584739859106484176L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 5,
    Value = new System.Numerics.BigInteger(429732668610178682L),
    NullableValue = new System.Numerics.BigInteger(7999471492210938542L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 27,
    Value = new System.Numerics.BigInteger(8133394918489649499L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 33,
    Value = new System.Numerics.BigInteger(1563532238544888570L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 9,
    Value = new System.Numerics.BigInteger(1548340459863875077L),
    NullableValue = new System.Numerics.BigInteger(7456937442254838054L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 38,
    Value = new System.Numerics.BigInteger(9009481760266297899L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 42,
    Value = new System.Numerics.BigInteger(3932920592653100303L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 13,
    Value = new System.Numerics.BigInteger(4797242181623417705L),
    NullableValue = new System.Numerics.BigInteger(1677328058598870018L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 45,
    Value = new System.Numerics.BigInteger(6931518220358705206L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1441288182182972347L),
},
            new BigIntegernumeric0M
{
    Id = 49,
    Value = new System.Numerics.BigInteger(4824983886014687043L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 17,
    Value = new System.Numerics.BigInteger(5914507763310042401L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 58,
    Value = new System.Numerics.BigInteger(4668414288095111771L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2423628097346543615L),
},
            new BigIntegernumeric0M
{
    Id = 66,
    Value = new System.Numerics.BigInteger(8634745711999189732L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 26,
    Value = new System.Numerics.BigInteger(7082022119246590121L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 67,
    Value = new System.Numerics.BigInteger(3562819421626173535L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(6469066963084990428L),
},
            new BigIntegernumeric0M
{
    Id = 72,
    Value = new System.Numerics.BigInteger(1550441393094118338L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 29,
    Value = new System.Numerics.BigInteger(1785075075783246744L),
    NullableValue = new System.Numerics.BigInteger(4323237824665080417L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 75,
    Value = new System.Numerics.BigInteger(6252387963832782238L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4541800767371542501L),
},
            new BigIntegernumeric0M
{
    Id = 79,
    Value = new System.Numerics.BigInteger(7467993139457687171L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 36,
    Value = new System.Numerics.BigInteger(5102302425570127492L),
    NullableValue = new System.Numerics.BigInteger(5363192623964866347L),
},
    NullableValue = new System.Numerics.BigInteger(1809296157377322833L),
},
            new BigIntegernumeric0M
{
    Id = 80,
    Value = new System.Numerics.BigInteger(1330806611797071271L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(519625621181084232L),
},
            new BigIntegernumeric0M
{
    Id = 89,
    Value = new System.Numerics.BigInteger(7979253031959625141L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 41,
    Value = new System.Numerics.BigInteger(4386956208558109369L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 90,
    Value = new System.Numerics.BigInteger(7094160161813614139L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1574784229231678343L),
},
            new BigIntegernumeric0M
{
    Id = 93,
    Value = new System.Numerics.BigInteger(5768127120814989129L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 48,
    Value = new System.Numerics.BigInteger(6447029853535881995L),
    NullableValue = new System.Numerics.BigInteger(8548035057299120441L),
},
    NullableValue = new System.Numerics.BigInteger(3691753764944675329L),
},
            new BigIntegernumeric0M
{
    Id = 101,
    Value = new System.Numerics.BigInteger(103757708915043928L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 104,
    Value = new System.Numerics.BigInteger(4224547025814688769L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 50,
    Value = new System.Numerics.BigInteger(8847609218771273576L),
    NullableValue = new System.Numerics.BigInteger(1299408741756277111L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 106,
    Value = new System.Numerics.BigInteger(337728694285615280L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 108,
    Value = new System.Numerics.BigInteger(8618456243484244855L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 54,
    Value = new System.Numerics.BigInteger(1491773760760452662L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(3511243612661753771L),
},
            new BigIntegernumeric0M
{
    Id = 111,
    Value = new System.Numerics.BigInteger(7557463456137295813L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 115,
    Value = new System.Numerics.BigInteger(8146627649377457744L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 62,
    Value = new System.Numerics.BigInteger(4308279388356371890L),
    NullableValue = new System.Numerics.BigInteger(230849348276911933L),
},
    NullableValue = new System.Numerics.BigInteger(6964480630486702439L),
},
            new BigIntegernumeric0M
{
    Id = 116,
    Value = new System.Numerics.BigInteger(5597427951926505980L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4722688926955322988L),
},
            new BigIntegernumeric0M
{
    Id = 120,
    Value = new System.Numerics.BigInteger(3299005533350083302L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 63,
    Value = new System.Numerics.BigInteger(5776329816632034880L),
    NullableValue = new System.Numerics.BigInteger(1968581483555843726L),
},
    NullableValue = new System.Numerics.BigInteger(783398428052634311L),
},
            new BigIntegernumeric0M
{
    Id = 125,
    Value = new System.Numerics.BigInteger(3720841368598372875L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 133,
    Value = new System.Numerics.BigInteger(4752890513573100488L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 67,
    Value = new System.Numerics.BigInteger(3775657775816525350L),
    NullableValue = null,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 108, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[29], false);
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 116, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
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
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
BigIntegernumeric0M.AssertModel(models[0],_testData[13], false);BigIntegernumeric0M.AssertModel(models[1],_testData[14], false);BigIntegernumeric0M.AssertModel(models[2],_testData[15], false);BigIntegernumeric0M.AssertModel(models[3],_testData[16], false);BigIntegernumeric0M.AssertModel(models[4],_testData[17], false);BigIntegernumeric0M.AssertModel(models[5],_testData[18], false);BigIntegernumeric0M.AssertModel(models[6],_testData[19], false);BigIntegernumeric0M.AssertModel(models[7],_testData[20], false);BigIntegernumeric0M.AssertModel(models[8],_testData[21], false);BigIntegernumeric0M.AssertModel(models[9],_testData[22], false);BigIntegernumeric0M.AssertModel(models[10],_testData[23], false);BigIntegernumeric0M.AssertModel(models[11],_testData[24], false);BigIntegernumeric0M.AssertModel(models[12],_testData[25], false);BigIntegernumeric0M.AssertModel(models[13],_testData[26], false);BigIntegernumeric0M.AssertModel(models[14],_testData[27], false);BigIntegernumeric0M.AssertModel(models[15],_testData[28], false);BigIntegernumeric0M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
BigIntegernumeric0M.AssertModel(models[0],_testData[26], false);BigIntegernumeric0M.AssertModel(models[1],_testData[27], false);BigIntegernumeric0M.AssertModel(models[2],_testData[28], false);BigIntegernumeric0M.AssertModel(models[3],_testData[29], false);
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
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1382215236322383847L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4826934197229547153L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3703027886457332134L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4151479429984842978L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3326957719092086962L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8554294256459815419L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5584739859106484176L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(429732668610178682L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7999471492210938542L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8133394918489649499L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1563532238544888570L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1548340459863875077L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7456937442254838054L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9009481760266297899L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3932920592653100303L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4797242181623417705L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1677328058598870018L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6931518220358705206L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1441288182182972347L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4824983886014687043L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5914507763310042401L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4668414288095111771L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2423628097346543615L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8634745711999189732L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7082022119246590121L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3562819421626173535L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6469066963084990428L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1550441393094118338L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1785075075783246744L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4323237824665080417L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6252387963832782238L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4541800767371542501L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7467993139457687171L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5102302425570127492L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5363192623964866347L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1809296157377322833L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1330806611797071271L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(519625621181084232L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7979253031959625141L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4386956208558109369L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7094160161813614139L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1574784229231678343L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5768127120814989129L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6447029853535881995L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8548035057299120441L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3691753764944675329L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(103757708915043928L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4224547025814688769L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8847609218771273576L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1299408741756277111L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(337728694285615280L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8618456243484244855L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1491773760760452662L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3511243612661753771L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7557463456137295813L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8146627649377457744L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4308279388356371890L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(230849348276911933L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6964480630486702439L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5597427951926505980L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4722688926955322988L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3299005533350083302L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5776329816632034880L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1968581483555843726L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(783398428052634311L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3720841368598372875L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4752890513573100488L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3775657775816525350L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1382215236322383847L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4826934197229547153L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3703027886457332134L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4151479429984842978L))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3326957719092086962L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8554294256459815419L))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5584739859106484176L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(429732668610178682L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7999471492210938542L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8133394918489649499L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1563532238544888570L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1548340459863875077L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7456937442254838054L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9009481760266297899L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3932920592653100303L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4797242181623417705L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1677328058598870018L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6931518220358705206L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1441288182182972347L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4824983886014687043L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5914507763310042401L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4668414288095111771L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2423628097346543615L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8634745711999189732L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7082022119246590121L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3562819421626173535L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6469066963084990428L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1550441393094118338L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1785075075783246744L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4323237824665080417L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6252387963832782238L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4541800767371542501L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7467993139457687171L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5102302425570127492L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5363192623964866347L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1809296157377322833L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1330806611797071271L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(519625621181084232L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7979253031959625141L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4386956208558109369L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7094160161813614139L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1574784229231678343L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5768127120814989129L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6447029853535881995L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8548035057299120441L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3691753764944675329L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(103757708915043928L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4224547025814688769L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8847609218771273576L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1299408741756277111L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(337728694285615280L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8618456243484244855L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1491773760760452662L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3511243612661753771L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7557463456137295813L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8146627649377457744L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4308279388356371890L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(230849348276911933L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6964480630486702439L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5597427951926505980L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4722688926955322988L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3299005533350083302L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5776329816632034880L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1968581483555843726L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(783398428052634311L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3720841368598372875L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4752890513573100488L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3775657775816525350L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumeric0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumeric0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumeric0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumeric0mi
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
                    BigIntegernumeric0MIWA.AssertModel(model, expectedModel, false);
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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerSingleTypenumeric)this).ExportModelInner(connection).ToList();
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

