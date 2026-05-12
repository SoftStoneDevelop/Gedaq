

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

        private readonly BigIntegernumericE0M[] _testData = new BigIntegernumericE0M[]
        {
            new BigIntegernumericE0M
{
    Id = 2,
    Value = new System.Numerics.BigInteger(3276414756239375703L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2776963983812461747L),
},
            new BigIntegernumericE0M
{
    Id = 4,
    Value = new System.Numerics.BigInteger(2481116227691188024L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 3,
    Value = new System.Numerics.BigInteger(823026889834453292L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 9,
    Value = new System.Numerics.BigInteger(5133496000333717478L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 14,
    Value = new System.Numerics.BigInteger(5577694412152792583L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 8,
    Value = new System.Numerics.BigInteger(2306387798893183530L),
    NullableValue = new System.Numerics.BigInteger(180975299525778165L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 15,
    Value = new System.Numerics.BigInteger(398588162205895167L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5601265329975629649L),
},
            new BigIntegernumericE0M
{
    Id = 20,
    Value = new System.Numerics.BigInteger(7513762981109769486L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 13,
    Value = new System.Numerics.BigInteger(2648752614988272610L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 27,
    Value = new System.Numerics.BigInteger(4700072841214261852L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 30,
    Value = new System.Numerics.BigInteger(1066807407760277163L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 16,
    Value = new System.Numerics.BigInteger(71961354388613297L),
    NullableValue = new System.Numerics.BigInteger(3889240831541922326L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 34,
    Value = new System.Numerics.BigInteger(5683373322728298935L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 35,
    Value = new System.Numerics.BigInteger(5246080762186711260L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 23,
    Value = new System.Numerics.BigInteger(8268777344272958283L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(3934954729245188393L),
},
            new BigIntegernumericE0M
{
    Id = 41,
    Value = new System.Numerics.BigInteger(6827859068867708307L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(9167643658952681623L),
},
            new BigIntegernumericE0M
{
    Id = 50,
    Value = new System.Numerics.BigInteger(3256160165906455951L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 27,
    Value = new System.Numerics.BigInteger(3398453871833564586L),
    NullableValue = new System.Numerics.BigInteger(6464065801783885946L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 56,
    Value = new System.Numerics.BigInteger(8590048068483167538L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(3272399030364011380L),
},
            new BigIntegernumericE0M
{
    Id = 57,
    Value = new System.Numerics.BigInteger(6723121392666989165L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 32,
    Value = new System.Numerics.BigInteger(4060737435378348156L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 65,
    Value = new System.Numerics.BigInteger(2053910703479437203L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 73,
    Value = new System.Numerics.BigInteger(4453835800876598993L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 33,
    Value = new System.Numerics.BigInteger(543504151699008285L),
    NullableValue = new System.Numerics.BigInteger(3805783509439125460L),
},
    NullableValue = new System.Numerics.BigInteger(7184463628353421455L),
},
            new BigIntegernumericE0M
{
    Id = 79,
    Value = new System.Numerics.BigInteger(828235629795465808L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4098760286918892491L),
},
            new BigIntegernumericE0M
{
    Id = 81,
    Value = new System.Numerics.BigInteger(7445941634018343744L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 40,
    Value = new System.Numerics.BigInteger(2322586500940309725L),
    NullableValue = new System.Numerics.BigInteger(5296268486649818610L),
},
    NullableValue = new System.Numerics.BigInteger(6810479411590198506L),
},
            new BigIntegernumericE0M
{
    Id = 82,
    Value = new System.Numerics.BigInteger(4351019093725933040L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2623872255151329381L),
},
            new BigIntegernumericE0M
{
    Id = 86,
    Value = new System.Numerics.BigInteger(1279624092909197027L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 44,
    Value = new System.Numerics.BigInteger(7429026652937512979L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(4452252978515344232L),
},
            new BigIntegernumericE0M
{
    Id = 92,
    Value = new System.Numerics.BigInteger(6046778904190047759L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 98,
    Value = new System.Numerics.BigInteger(3181862846589689667L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 45,
    Value = new System.Numerics.BigInteger(748995113946408126L),
    NullableValue = new System.Numerics.BigInteger(6619358720699775940L),
},
    NullableValue = new System.Numerics.BigInteger(4099177502662817753L),
},
            new BigIntegernumericE0M
{
    Id = 106,
    Value = new System.Numerics.BigInteger(7778488114872856302L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 109,
    Value = new System.Numerics.BigInteger(5344251788621296570L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 51,
    Value = new System.Numerics.BigInteger(8766338549113986250L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 114,
    Value = new System.Numerics.BigInteger(8166117407593493563L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 121,
    Value = new System.Numerics.BigInteger(6200861838848985809L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 56,
    Value = new System.Numerics.BigInteger(337670019135114266L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 123,
    Value = new System.Numerics.BigInteger(6384077028944929403L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 124,
    Value = new System.Numerics.BigInteger(518814075432855143L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 62,
    Value = new System.Numerics.BigInteger(2890577020491942948L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(8165942226355777214L),
},
            new BigIntegernumericE0M
{
    Id = 130,
    Value = new System.Numerics.BigInteger(6876880124214602544L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 134,
    Value = new System.Numerics.BigInteger(8132959762678515735L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 71,
    Value = new System.Numerics.BigInteger(8985245128112997930L),
    NullableValue = new System.Numerics.BigInteger(1902304511672052455L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 137,
    Value = new System.Numerics.BigInteger(3865898720885907139L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 144,
    Value = new System.Numerics.BigInteger(2132712981212740649L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 78,
    Value = new System.Numerics.BigInteger(5354600919376289002L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(8627185178968324804L),
},
            new BigIntegernumericE0M
{
    Id = 152,
    Value = new System.Numerics.BigInteger(5698165210468327307L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2977247204879252417L),
},
            new BigIntegernumericE0M
{
    Id = 157,
    Value = new System.Numerics.BigInteger(3469606558272734783L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 80,
    Value = new System.Numerics.BigInteger(3779400866725184200L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(985339974498794612L),
},
            new BigIntegernumericE0M
{
    Id = 160,
    Value = new System.Numerics.BigInteger(1657651748281905765L),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0mi(
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
INSERT INTO public.bigintegernumerice0mi(
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
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
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
INSERT INTO public.bigintegernumerice0mi(
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
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
                methodParametrName: "bigintegernumerice0mi_id", 
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
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                methodParametrName: "bigintegernumerice0mi_id", 
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
                List<BigIntegernumericE0M> models = null;

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericE0M> models = null;

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bigintegernumerice0mi_id
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
                parametrName: "bigintegernumerice0mi_id", 
                methodParametrName: "bigintegernumerice0mi_id", 
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
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
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
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
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
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[24],_testData[34], false);
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 137, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 50, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[34], false);
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
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 4, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[34], false);
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
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumericE0M.AssertModel(models[0],_testData[15], false);
                BigIntegernumericE0M.AssertModel(models[1],_testData[16], false);
                BigIntegernumericE0M.AssertModel(models[2],_testData[17], false);
                BigIntegernumericE0M.AssertModel(models[3],_testData[18], false);
                BigIntegernumericE0M.AssertModel(models[4],_testData[19], false);
                BigIntegernumericE0M.AssertModel(models[5],_testData[20], false);
                BigIntegernumericE0M.AssertModel(models[6],_testData[21], false);
                BigIntegernumericE0M.AssertModel(models[7],_testData[22], false);
                BigIntegernumericE0M.AssertModel(models[8],_testData[23], false);
                BigIntegernumericE0M.AssertModel(models[9],_testData[24], false);
                BigIntegernumericE0M.AssertModel(models[10],_testData[25], false);
                BigIntegernumericE0M.AssertModel(models[11],_testData[26], false);
                BigIntegernumericE0M.AssertModel(models[12],_testData[27], false);
                BigIntegernumericE0M.AssertModel(models[13],_testData[28], false);
                BigIntegernumericE0M.AssertModel(models[14],_testData[29], false);
                BigIntegernumericE0M.AssertModel(models[15],_testData[30], false);
                BigIntegernumericE0M.AssertModel(models[16],_testData[31], false);
                BigIntegernumericE0M.AssertModel(models[17],_testData[32], false);
                BigIntegernumericE0M.AssertModel(models[18],_testData[33], false);
                BigIntegernumericE0M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                BigIntegernumericE0M.AssertModel(models[0],_testData[6], false);
                BigIntegernumericE0M.AssertModel(models[1],_testData[7], false);
                BigIntegernumericE0M.AssertModel(models[2],_testData[8], false);
                BigIntegernumericE0M.AssertModel(models[3],_testData[9], false);
                BigIntegernumericE0M.AssertModel(models[4],_testData[10], false);
                BigIntegernumericE0M.AssertModel(models[5],_testData[11], false);
                BigIntegernumericE0M.AssertModel(models[6],_testData[12], false);
                BigIntegernumericE0M.AssertModel(models[7],_testData[13], false);
                BigIntegernumericE0M.AssertModel(models[8],_testData[14], false);
                BigIntegernumericE0M.AssertModel(models[9],_testData[15], false);
                BigIntegernumericE0M.AssertModel(models[10],_testData[16], false);
                BigIntegernumericE0M.AssertModel(models[11],_testData[17], false);
                BigIntegernumericE0M.AssertModel(models[12],_testData[18], false);
                BigIntegernumericE0M.AssertModel(models[13],_testData[19], false);
                BigIntegernumericE0M.AssertModel(models[14],_testData[20], false);
                BigIntegernumericE0M.AssertModel(models[15],_testData[21], false);
                BigIntegernumericE0M.AssertModel(models[16],_testData[22], false);
                BigIntegernumericE0M.AssertModel(models[17],_testData[23], false);
                BigIntegernumericE0M.AssertModel(models[18],_testData[24], false);
                BigIntegernumericE0M.AssertModel(models[19],_testData[25], false);
                BigIntegernumericE0M.AssertModel(models[20],_testData[26], false);
                BigIntegernumericE0M.AssertModel(models[21],_testData[27], false);
                BigIntegernumericE0M.AssertModel(models[22],_testData[28], false);
                BigIntegernumericE0M.AssertModel(models[23],_testData[29], false);
                BigIntegernumericE0M.AssertModel(models[24],_testData[30], false);
                BigIntegernumericE0M.AssertModel(models[25],_testData[31], false);
                BigIntegernumericE0M.AssertModel(models[26],_testData[32], false);
                BigIntegernumericE0M.AssertModel(models[27],_testData[33], false);
                BigIntegernumericE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3276414756239375703L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2776963983812461747L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2481116227691188024L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(823026889834453292L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5133496000333717478L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5577694412152792583L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2306387798893183530L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(180975299525778165L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(398588162205895167L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5601265329975629649L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7513762981109769486L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2648752614988272610L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4700072841214261852L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1066807407760277163L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(71961354388613297L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3889240831541922326L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5683373322728298935L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5246080762186711260L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8268777344272958283L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3934954729245188393L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6827859068867708307L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9167643658952681623L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3256160165906455951L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3398453871833564586L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6464065801783885946L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8590048068483167538L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3272399030364011380L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6723121392666989165L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4060737435378348156L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2053910703479437203L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4453835800876598993L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(543504151699008285L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3805783509439125460L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7184463628353421455L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(828235629795465808L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4098760286918892491L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7445941634018343744L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2322586500940309725L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5296268486649818610L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6810479411590198506L))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4351019093725933040L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2623872255151329381L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1279624092909197027L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7429026652937512979L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4452252978515344232L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6046778904190047759L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3181862846589689667L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(748995113946408126L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6619358720699775940L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4099177502662817753L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7778488114872856302L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5344251788621296570L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8766338549113986250L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8166117407593493563L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6200861838848985809L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(337670019135114266L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6384077028944929403L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(518814075432855143L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2890577020491942948L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8165942226355777214L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6876880124214602544L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8132959762678515735L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8985245128112997930L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1902304511672052455L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3865898720885907139L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2132712981212740649L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5354600919376289002L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8627185178968324804L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5698165210468327307L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2977247204879252417L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3469606558272734783L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3779400866725184200L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(985339974498794612L))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1657651748281905765L))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3276414756239375703L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2776963983812461747L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2481116227691188024L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(823026889834453292L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5133496000333717478L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5577694412152792583L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2306387798893183530L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(180975299525778165L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(398588162205895167L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5601265329975629649L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7513762981109769486L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2648752614988272610L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4700072841214261852L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1066807407760277163L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(71961354388613297L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3889240831541922326L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5683373322728298935L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5246080762186711260L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8268777344272958283L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3934954729245188393L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6827859068867708307L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9167643658952681623L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3256160165906455951L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3398453871833564586L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6464065801783885946L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8590048068483167538L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3272399030364011380L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6723121392666989165L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4060737435378348156L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2053910703479437203L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4453835800876598993L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(543504151699008285L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3805783509439125460L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7184463628353421455L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(828235629795465808L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4098760286918892491L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7445941634018343744L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2322586500940309725L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5296268486649818610L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6810479411590198506L))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4351019093725933040L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2623872255151329381L))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1279624092909197027L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7429026652937512979L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4452252978515344232L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6046778904190047759L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3181862846589689667L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(748995113946408126L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6619358720699775940L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4099177502662817753L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7778488114872856302L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5344251788621296570L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8766338549113986250L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8166117407593493563L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6200861838848985809L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(337670019135114266L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6384077028944929403L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(518814075432855143L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2890577020491942948L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8165942226355777214L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6876880124214602544L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8132959762678515735L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8985245128112997930L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1902304511672052455L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3865898720885907139L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2132712981212740649L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5354600919376289002L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8627185178968324804L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5698165210468327307L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2977247204879252417L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3469606558272734783L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3779400866725184200L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(985339974498794612L))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1657651748281905765L))));//Value

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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
            queryMapType: typeof(BigIntegernumericE0MIWA),
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
            queryMapType: typeof(BigIntegernumericE0MIWA),
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
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
COPY public.binary_bigintegernumerice0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MI),
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
                var importCollection = new List<BigIntegernumericE0MI>(2);
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
                    BigIntegernumericE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MI>(2);
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
                    BigIntegernumericE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MIWA),
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
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
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumerice0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumerice0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericE0M),
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
FROM public.binary_bigintegernumerice0m m
LEFT JOIN public.binary_bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                var importCollection = new List<BigIntegernumericE0M>();
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
                    BigIntegernumericE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0M>();
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
                    BigIntegernumericE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
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
                    BigIntegernumericE0M.AssertModel(model, expectedModel, true);
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
                    BigIntegernumericE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI), typeof(BigIntegernumericE0MI)],
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
                var models1 = new List<BigIntegernumericE0MI>();
                var models2 = new List<BigIntegernumericE0MI>();
                await ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MI>();
                var models2 = new List<BigIntegernumericE0MI>();
                ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
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
                    BigIntegernumericE0MI.AssertModel(model, expectedModel, false);
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
                    BigIntegernumericE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

