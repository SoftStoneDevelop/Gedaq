

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
    Id = 2,
    Value = new System.Numerics.BigInteger(2462370273724112803L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 10,
    Value = new System.Numerics.BigInteger(5780155403361863566L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 5,
    Value = new System.Numerics.BigInteger(3477027756052329281L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 13,
    Value = new System.Numerics.BigInteger(2863709473249576342L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 18,
    Value = new System.Numerics.BigInteger(2112129806934673940L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 10,
    Value = new System.Numerics.BigInteger(7497717801470046447L),
    NullableValue = new System.Numerics.BigInteger(8052190514388846872L),
},
    NullableValue = new System.Numerics.BigInteger(6066733091861076713L),
},
            new BigIntegernumeric0M
{
    Id = 27,
    Value = new System.Numerics.BigInteger(7415940638375977712L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(7322714954663891782L),
},
            new BigIntegernumeric0M
{
    Id = 35,
    Value = new System.Numerics.BigInteger(1847238130422865606L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 12,
    Value = new System.Numerics.BigInteger(5391899521656584075L),
    NullableValue = new System.Numerics.BigInteger(4516916476613530483L),
},
    NullableValue = new System.Numerics.BigInteger(7867187656734887310L),
},
            new BigIntegernumeric0M
{
    Id = 37,
    Value = new System.Numerics.BigInteger(1360672575557744861L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1024450514292477546L),
},
            new BigIntegernumeric0M
{
    Id = 39,
    Value = new System.Numerics.BigInteger(9217825036803690719L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 18,
    Value = new System.Numerics.BigInteger(8053101023405484060L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(7270324614154088943L),
},
            new BigIntegernumeric0M
{
    Id = 46,
    Value = new System.Numerics.BigInteger(6885948157930435469L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5167779387002228305L),
},
            new BigIntegernumeric0M
{
    Id = 53,
    Value = new System.Numerics.BigInteger(258717502993712030L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 21,
    Value = new System.Numerics.BigInteger(4536375467563457418L),
    NullableValue = new System.Numerics.BigInteger(2466650683496872502L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 55,
    Value = new System.Numerics.BigInteger(1162151098470684723L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4917777608185167511L),
},
            new BigIntegernumeric0M
{
    Id = 64,
    Value = new System.Numerics.BigInteger(1801085884218593450L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 30,
    Value = new System.Numerics.BigInteger(4330487351713062365L),
    NullableValue = new System.Numerics.BigInteger(6813790577784997134L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 72,
    Value = new System.Numerics.BigInteger(368339363966334794L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(6766496019012057335L),
},
            new BigIntegernumeric0M
{
    Id = 76,
    Value = new System.Numerics.BigInteger(7737946405511821689L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 31,
    Value = new System.Numerics.BigInteger(8460246547448542863L),
    NullableValue = new System.Numerics.BigInteger(1847793059453827332L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 83,
    Value = new System.Numerics.BigInteger(4714347950724223651L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 88,
    Value = new System.Numerics.BigInteger(2612075860425324487L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 33,
    Value = new System.Numerics.BigInteger(8165172918228914611L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 90,
    Value = new System.Numerics.BigInteger(1338633381255194487L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(889155549510280974L),
},
            new BigIntegernumeric0M
{
    Id = 99,
    Value = new System.Numerics.BigInteger(2152982488473596094L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 35,
    Value = new System.Numerics.BigInteger(5642533212401344022L),
    NullableValue = new System.Numerics.BigInteger(6308536199216825338L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 108,
    Value = new System.Numerics.BigInteger(4783139360951898959L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 115,
    Value = new System.Numerics.BigInteger(5422532105562826322L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 38,
    Value = new System.Numerics.BigInteger(6753247625967311732L),
    NullableValue = new System.Numerics.BigInteger(2315067530836876567L),
},
    NullableValue = new System.Numerics.BigInteger(4226922260698418358L),
},
            new BigIntegernumeric0M
{
    Id = 124,
    Value = new System.Numerics.BigInteger(2625946083815485319L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8509222602920125887L),
},
            new BigIntegernumeric0M
{
    Id = 128,
    Value = new System.Numerics.BigInteger(8339627859665570521L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 43,
    Value = new System.Numerics.BigInteger(7663007939766647795L),
    NullableValue = new System.Numerics.BigInteger(6323930839833864059L),
},
    NullableValue = new System.Numerics.BigInteger(2873721173860090831L),
},
            new BigIntegernumeric0M
{
    Id = 137,
    Value = new System.Numerics.BigInteger(5029588353003964489L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(9103589085411193200L),
},
            new BigIntegernumeric0M
{
    Id = 146,
    Value = new System.Numerics.BigInteger(5913829425487494991L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 50,
    Value = new System.Numerics.BigInteger(8040296384199530820L),
    NullableValue = new System.Numerics.BigInteger(6487480405374825661L),
},
    NullableValue = null,
},
            new BigIntegernumeric0M
{
    Id = 148,
    Value = new System.Numerics.BigInteger(5420411013112430601L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8720617943149180426L),
},
            new BigIntegernumeric0M
{
    Id = 157,
    Value = new System.Numerics.BigInteger(5578832999467367417L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 58,
    Value = new System.Numerics.BigInteger(1791476249295448689L),
    NullableValue = new System.Numerics.BigInteger(4800056846768350641L),
},
    NullableValue = new System.Numerics.BigInteger(7089886174216732475L),
},
            new BigIntegernumeric0M
{
    Id = 163,
    Value = new System.Numerics.BigInteger(7498119610294251673L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1689634892202596077L),
},
            new BigIntegernumeric0M
{
    Id = 167,
    Value = new System.Numerics.BigInteger(7633508622879923530L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 64,
    Value = new System.Numerics.BigInteger(8734738981928727129L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(8338617085004633653L),
},
            new BigIntegernumeric0M
{
    Id = 174,
    Value = new System.Numerics.BigInteger(6930464098196705720L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1437924393027651066L),
},
            new BigIntegernumeric0M
{
    Id = 177,
    Value = new System.Numerics.BigInteger(8111490809003898037L),
    ModelInner = new BigIntegernumeric0MI
{
    Id = 66,
    Value = new System.Numerics.BigInteger(1946977432417653706L),
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr1.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[29], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[29], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[29], false);
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[29], false);
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[29], false);
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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 157, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
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
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 137, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumeric0M.AssertModel(secondItems2[26],_testData[29], false);
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 53, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumeric0M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumeric0M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumeric0M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumeric0M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(models[19],_testData[29], false);
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
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumeric0M.AssertModel(firstItems1[16],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 99, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 163, 76))
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumeric0M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumeric0M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumeric0M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumeric0M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumeric0M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumeric0M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumeric0M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumeric0M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumeric0M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumeric0M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumeric0M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumeric0M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumeric0M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumeric0M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumeric0M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumeric0M.AssertModel(models[15],_testData[29], false);
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
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
BigIntegernumeric0M.AssertModel(models[0],_testData[7], false);BigIntegernumeric0M.AssertModel(models[1],_testData[8], false);BigIntegernumeric0M.AssertModel(models[2],_testData[9], false);BigIntegernumeric0M.AssertModel(models[3],_testData[10], false);BigIntegernumeric0M.AssertModel(models[4],_testData[11], false);BigIntegernumeric0M.AssertModel(models[5],_testData[12], false);BigIntegernumeric0M.AssertModel(models[6],_testData[13], false);BigIntegernumeric0M.AssertModel(models[7],_testData[14], false);BigIntegernumeric0M.AssertModel(models[8],_testData[15], false);BigIntegernumeric0M.AssertModel(models[9],_testData[16], false);BigIntegernumeric0M.AssertModel(models[10],_testData[17], false);BigIntegernumeric0M.AssertModel(models[11],_testData[18], false);BigIntegernumeric0M.AssertModel(models[12],_testData[19], false);BigIntegernumeric0M.AssertModel(models[13],_testData[20], false);BigIntegernumeric0M.AssertModel(models[14],_testData[21], false);BigIntegernumeric0M.AssertModel(models[15],_testData[22], false);BigIntegernumeric0M.AssertModel(models[16],_testData[23], false);BigIntegernumeric0M.AssertModel(models[17],_testData[24], false);BigIntegernumeric0M.AssertModel(models[18],_testData[25], false);BigIntegernumeric0M.AssertModel(models[19],_testData[26], false);BigIntegernumeric0M.AssertModel(models[20],_testData[27], false);BigIntegernumeric0M.AssertModel(models[21],_testData[28], false);BigIntegernumeric0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
BigIntegernumeric0M.AssertModel(models[0],_testData[18], false);BigIntegernumeric0M.AssertModel(models[1],_testData[19], false);BigIntegernumeric0M.AssertModel(models[2],_testData[20], false);BigIntegernumeric0M.AssertModel(models[3],_testData[21], false);BigIntegernumeric0M.AssertModel(models[4],_testData[22], false);BigIntegernumeric0M.AssertModel(models[5],_testData[23], false);BigIntegernumeric0M.AssertModel(models[6],_testData[24], false);BigIntegernumeric0M.AssertModel(models[7],_testData[25], false);BigIntegernumeric0M.AssertModel(models[8],_testData[26], false);BigIntegernumeric0M.AssertModel(models[9],_testData[27], false);BigIntegernumeric0M.AssertModel(models[10],_testData[28], false);BigIntegernumeric0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2462370273724112803L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5780155403361863566L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3477027756052329281L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2863709473249576342L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2112129806934673940L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7497717801470046447L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8052190514388846872L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6066733091861076713L))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7415940638375977712L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7322714954663891782L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1847238130422865606L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5391899521656584075L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4516916476613530483L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7867187656734887310L))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1360672575557744861L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1024450514292477546L))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9217825036803690719L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8053101023405484060L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7270324614154088943L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6885948157930435469L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5167779387002228305L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(258717502993712030L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4536375467563457418L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2466650683496872502L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1162151098470684723L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4917777608185167511L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1801085884218593450L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4330487351713062365L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6813790577784997134L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(368339363966334794L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6766496019012057335L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7737946405511821689L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8460246547448542863L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1847793059453827332L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4714347950724223651L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2612075860425324487L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8165172918228914611L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1338633381255194487L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(889155549510280974L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2152982488473596094L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5642533212401344022L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6308536199216825338L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4783139360951898959L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5422532105562826322L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6753247625967311732L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2315067530836876567L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4226922260698418358L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2625946083815485319L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8509222602920125887L))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8339627859665570521L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7663007939766647795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6323930839833864059L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2873721173860090831L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5029588353003964489L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9103589085411193200L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5913829425487494991L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8040296384199530820L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6487480405374825661L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5420411013112430601L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8720617943149180426L))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5578832999467367417L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1791476249295448689L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4800056846768350641L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7089886174216732475L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7498119610294251673L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1689634892202596077L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7633508622879923530L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8734738981928727129L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8338617085004633653L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6930464098196705720L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1437924393027651066L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8111490809003898037L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1946977432417653706L))));//InnerModel.Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2462370273724112803L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5780155403361863566L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3477027756052329281L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2863709473249576342L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2112129806934673940L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7497717801470046447L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8052190514388846872L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6066733091861076713L))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7415940638375977712L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7322714954663891782L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1847238130422865606L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5391899521656584075L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4516916476613530483L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7867187656734887310L))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1360672575557744861L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1024450514292477546L))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9217825036803690719L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8053101023405484060L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7270324614154088943L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6885948157930435469L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5167779387002228305L))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(258717502993712030L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4536375467563457418L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2466650683496872502L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1162151098470684723L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4917777608185167511L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1801085884218593450L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4330487351713062365L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6813790577784997134L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(368339363966334794L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6766496019012057335L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7737946405511821689L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8460246547448542863L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1847793059453827332L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4714347950724223651L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2612075860425324487L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8165172918228914611L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1338633381255194487L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(889155549510280974L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2152982488473596094L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5642533212401344022L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6308536199216825338L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4783139360951898959L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5422532105562826322L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6753247625967311732L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2315067530836876567L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4226922260698418358L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2625946083815485319L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8509222602920125887L))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8339627859665570521L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7663007939766647795L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6323930839833864059L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2873721173860090831L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5029588353003964489L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9103589085411193200L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5913829425487494991L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8040296384199530820L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6487480405374825661L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5420411013112430601L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8720617943149180426L))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5578832999467367417L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1791476249295448689L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4800056846768350641L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7089886174216732475L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7498119610294251673L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1689634892202596077L))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7633508622879923530L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8734738981928727129L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8338617085004633653L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6930464098196705720L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1437924393027651066L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8111490809003898037L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1946977432417653706L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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

