

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
    internal partial interface IGuidSingleTypeuuid
    {
    }
    
    internal partial class GuidSingleTypeuuid : IGuidSingleTypeuuid
    {


#region TestData

        private readonly Guiduuid0M[] _testData = new Guiduuid0M[]
        {
            new Guiduuid0M
{
    Id = 2,
    Value = Guid.Parse("a876b127-ccea-47a2-baad-02f447d37329"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 6,
    Value = Guid.Parse("bffcec6a-7bac-4923-9834-be6bb92540dc"),
    ModelInner = new Guiduuid0MI
{
    Id = 4,
    Value = Guid.Parse("de799c57-75c2-4a15-9d78-658e356c1823"),
    NullableValue = Guid.Parse("8d70f1c2-711c-4e4f-89b3-f996435e934d"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 12,
    Value = Guid.Parse("7d36d828-63b6-4ae7-b64c-033317aed7cc"),
    ModelInner = null,
    NullableValue = Guid.Parse("29a5afda-7986-4f24-a2fb-dc644992046f"),
},
            new Guiduuid0M
{
    Id = 13,
    Value = Guid.Parse("f1e30c27-3b90-4d4a-8240-dc7791bb799e"),
    ModelInner = new Guiduuid0MI
{
    Id = 11,
    Value = Guid.Parse("49eccc95-b9fb-4826-b670-1411acef692e"),
    NullableValue = Guid.Parse("e1060851-9316-4d07-b756-b187bd2506f2"),
},
    NullableValue = Guid.Parse("b187ab25-2a1d-4a01-852f-361657ac01d3"),
},
            new Guiduuid0M
{
    Id = 14,
    Value = Guid.Parse("0c37b427-981d-4082-b4f0-6f0805a23723"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 22,
    Value = Guid.Parse("3b54d820-c703-404e-8761-81c900b57473"),
    ModelInner = new Guiduuid0MI
{
    Id = 20,
    Value = Guid.Parse("bb0e162b-7b14-4431-acb4-c1b409b85489"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 26,
    Value = Guid.Parse("bc94f92a-e0ff-4292-81bd-0e12c514b108"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 29,
    Value = Guid.Parse("f4f47f40-b15b-444b-b69f-e66495d95f70"),
    ModelInner = new Guiduuid0MI
{
    Id = 27,
    Value = Guid.Parse("16941cc5-9ca2-474a-b6df-a8ca0ff36a8a"),
    NullableValue = Guid.Parse("bf881f6d-1e76-495b-8f22-a51779c2458a"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 37,
    Value = Guid.Parse("1cc31da7-89cb-44ae-9f61-ee1983b2cb10"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 45,
    Value = Guid.Parse("a4c30477-43ba-40d6-bc86-726766a4becf"),
    ModelInner = new Guiduuid0MI
{
    Id = 29,
    Value = Guid.Parse("d5a137df-b0a0-4022-a943-22527b546657"),
    NullableValue = Guid.Parse("d64fa66d-3be8-4e9e-9c8d-4d8ccacc5981"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 47,
    Value = Guid.Parse("b0af7693-811c-44ab-8fa7-6123a341fc14"),
    ModelInner = null,
    NullableValue = Guid.Parse("d59eecca-99f0-4b97-abc2-274fcdc51490"),
},
            new Guiduuid0M
{
    Id = 50,
    Value = Guid.Parse("5e05fcce-685e-4ed0-941d-4fe8c6678366"),
    ModelInner = new Guiduuid0MI
{
    Id = 37,
    Value = Guid.Parse("d4747bc9-b6dd-405a-9f19-0b19968ca281"),
    NullableValue = Guid.Parse("65ebc00a-f0df-404a-9bae-711ec8e1d662"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 59,
    Value = Guid.Parse("ed91f675-d946-42f5-a290-f879d96a2c99"),
    ModelInner = null,
    NullableValue = Guid.Parse("b7b35a7f-d3b2-4c52-b3a4-562e165196ed"),
},
            new Guiduuid0M
{
    Id = 63,
    Value = Guid.Parse("f4b77179-01df-43a4-9a8f-4066f98b1ea9"),
    ModelInner = new Guiduuid0MI
{
    Id = 45,
    Value = Guid.Parse("8840b60b-9947-469a-9474-c063e27c8948"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f697a7d5-191e-4ffb-b818-31c65eb6b766"),
},
            new Guiduuid0M
{
    Id = 66,
    Value = Guid.Parse("c089d823-bbde-4e0f-9369-af43adadddd1"),
    ModelInner = null,
    NullableValue = Guid.Parse("3f4aeaec-f46a-49e2-aee1-0895ad2befaf"),
},
            new Guiduuid0M
{
    Id = 72,
    Value = Guid.Parse("565e939f-c139-4e15-b2b2-c3f41bbf54b4"),
    ModelInner = new Guiduuid0MI
{
    Id = 53,
    Value = Guid.Parse("f0b4e2a8-2016-4471-a0ab-9b549c73d143"),
    NullableValue = Guid.Parse("7d8138e6-3e62-47ab-b530-0267f41199b4"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 78,
    Value = Guid.Parse("2a21b080-e892-4f06-a968-ea1a683bac1c"),
    ModelInner = null,
    NullableValue = Guid.Parse("23b79207-b887-4d13-ab5c-68ce3a3a72cf"),
},
            new Guiduuid0M
{
    Id = 82,
    Value = Guid.Parse("c5e67778-c4b8-4e7c-9315-248456140ce6"),
    ModelInner = new Guiduuid0MI
{
    Id = 55,
    Value = Guid.Parse("d14ace22-0355-4012-aeca-8914561bf07f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 91,
    Value = Guid.Parse("f450be9a-70a1-48fd-aa2b-9d42e1adf51a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 98,
    Value = Guid.Parse("b0f6a98e-93b3-4327-947b-d391de0be54f"),
    ModelInner = new Guiduuid0MI
{
    Id = 61,
    Value = Guid.Parse("a9551f9b-a5ac-4926-8032-65f15f38eb62"),
    NullableValue = Guid.Parse("72f778eb-3647-49a5-b9ac-cdfbdd97fb58"),
},
    NullableValue = Guid.Parse("73f74b59-baae-4dac-9949-0db5707057ba"),
},
            new Guiduuid0M
{
    Id = 102,
    Value = Guid.Parse("78f58b27-0ae5-42c5-a226-a5f23163abe0"),
    ModelInner = null,
    NullableValue = Guid.Parse("f2c9136e-be2e-48b0-8535-ce407ca50175"),
},
            new Guiduuid0M
{
    Id = 103,
    Value = Guid.Parse("3e0455ef-783e-41f3-8e70-ea7ae7fa0332"),
    ModelInner = new Guiduuid0MI
{
    Id = 65,
    Value = Guid.Parse("6ffb55d9-87dd-4699-a5b4-f2a1b935fc2b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d42323a6-9acc-41d5-b70c-6fc7c2910530"),
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("f30f35bf-f990-4825-b040-f159f0aa6fc9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 114,
    Value = Guid.Parse("5dbe7fa5-7b19-48a1-8906-806293add714"),
    ModelInner = new Guiduuid0MI
{
    Id = 66,
    Value = Guid.Parse("231394d2-aa64-4f67-a61a-c6ae0c4f9cd2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 123,
    Value = Guid.Parse("00ad1b47-2b0d-4314-aaa4-f90c7ae32575"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 125,
    Value = Guid.Parse("b623040b-6122-4653-aec1-eec7d4f9213c"),
    ModelInner = new Guiduuid0MI
{
    Id = 75,
    Value = Guid.Parse("4e293942-acae-41bb-ad81-6249f0fc1d37"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 130,
    Value = Guid.Parse("7a28898e-0ab8-4ae1-b5c1-05c988b41e99"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 138,
    Value = Guid.Parse("dbc60ac3-38f3-4fb3-9b79-4a1f859afc6d"),
    ModelInner = new Guiduuid0MI
{
    Id = 80,
    Value = Guid.Parse("e2637916-b853-44e7-8d73-416753bbde51"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("728f1159-8fde-44fe-8f8e-056569cc837a"),
},
            new Guiduuid0M
{
    Id = 145,
    Value = Guid.Parse("c78605ea-b08d-4b5c-9ced-55a86868abc7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 146,
    Value = Guid.Parse("a748bc0b-f30f-4f19-8a2c-38fdfaddc8db"),
    ModelInner = new Guiduuid0MI
{
    Id = 85,
    Value = Guid.Parse("a23e84d0-4963-4c4a-a753-4e68501001b9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("8cfd2c65-b63a-4c9a-950f-e10ed34bdae9"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
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

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9), 
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
    guiduuid0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
    guiduuid0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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
                System.Guid? nullable = null;
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("d59eecca-99f0-4b97-abc2-274fcdc51490")));
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuid0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Guid), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduuid0mi_id", 
                methodParametrName: "guiduuid0mi_id", 
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

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await ((IGuidSingleTypeuuid)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidSingleTypeuuid)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await ((IGuidSingleTypeuuid)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuuid)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[29], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[29], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[29], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduuid0M.AssertModel(models[0],_testData[2], false);
                        Guiduuid0M.AssertModel(models[1],_testData[3], false);
                        Guiduuid0M.AssertModel(models[2],_testData[4], false);
                        Guiduuid0M.AssertModel(models[3],_testData[5], false);
                        Guiduuid0M.AssertModel(models[4],_testData[6], false);
                        Guiduuid0M.AssertModel(models[5],_testData[7], false);
                        Guiduuid0M.AssertModel(models[6],_testData[8], false);
                        Guiduuid0M.AssertModel(models[7],_testData[9], false);
                        Guiduuid0M.AssertModel(models[8],_testData[10], false);
                        Guiduuid0M.AssertModel(models[9],_testData[11], false);
                        Guiduuid0M.AssertModel(models[10],_testData[12], false);
                        Guiduuid0M.AssertModel(models[11],_testData[13], false);
                        Guiduuid0M.AssertModel(models[12],_testData[14], false);
                        Guiduuid0M.AssertModel(models[13],_testData[15], false);
                        Guiduuid0M.AssertModel(models[14],_testData[16], false);
                        Guiduuid0M.AssertModel(models[15],_testData[17], false);
                        Guiduuid0M.AssertModel(models[16],_testData[18], false);
                        Guiduuid0M.AssertModel(models[17],_testData[19], false);
                        Guiduuid0M.AssertModel(models[18],_testData[20], false);
                        Guiduuid0M.AssertModel(models[19],_testData[21], false);
                        Guiduuid0M.AssertModel(models[20],_testData[22], false);
                        Guiduuid0M.AssertModel(models[21],_testData[23], false);
                        Guiduuid0M.AssertModel(models[22],_testData[24], false);
                        Guiduuid0M.AssertModel(models[23],_testData[25], false);
                        Guiduuid0M.AssertModel(models[24],_testData[26], false);
                        Guiduuid0M.AssertModel(models[25],_testData[27], false);
                        Guiduuid0M.AssertModel(models[26],_testData[28], false);
                        Guiduuid0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guiduuid0M.AssertModel(models[0],_testData[20], false);
                        Guiduuid0M.AssertModel(models[1],_testData[21], false);
                        Guiduuid0M.AssertModel(models[2],_testData[22], false);
                        Guiduuid0M.AssertModel(models[3],_testData[23], false);
                        Guiduuid0M.AssertModel(models[4],_testData[24], false);
                        Guiduuid0M.AssertModel(models[5],_testData[25], false);
                        Guiduuid0M.AssertModel(models[6],_testData[26], false);
                        Guiduuid0M.AssertModel(models[7],_testData[27], false);
                        Guiduuid0M.AssertModel(models[8],_testData[28], false);
                        Guiduuid0M.AssertModel(models[9],_testData[29], false);
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
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guiduuid0M.AssertModel(models[0],_testData[23], false);
                        Guiduuid0M.AssertModel(models[1],_testData[24], false);
                        Guiduuid0M.AssertModel(models[2],_testData[25], false);
                        Guiduuid0M.AssertModel(models[3],_testData[26], false);
                        Guiduuid0M.AssertModel(models[4],_testData[27], false);
                        Guiduuid0M.AssertModel(models[5],_testData[28], false);
                        Guiduuid0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guiduuid0M.AssertModel(models[0],_testData[8], false);
                        Guiduuid0M.AssertModel(models[1],_testData[9], false);
                        Guiduuid0M.AssertModel(models[2],_testData[10], false);
                        Guiduuid0M.AssertModel(models[3],_testData[11], false);
                        Guiduuid0M.AssertModel(models[4],_testData[12], false);
                        Guiduuid0M.AssertModel(models[5],_testData[13], false);
                        Guiduuid0M.AssertModel(models[6],_testData[14], false);
                        Guiduuid0M.AssertModel(models[7],_testData[15], false);
                        Guiduuid0M.AssertModel(models[8],_testData[16], false);
                        Guiduuid0M.AssertModel(models[9],_testData[17], false);
                        Guiduuid0M.AssertModel(models[10],_testData[18], false);
                        Guiduuid0M.AssertModel(models[11],_testData[19], false);
                        Guiduuid0M.AssertModel(models[12],_testData[20], false);
                        Guiduuid0M.AssertModel(models[13],_testData[21], false);
                        Guiduuid0M.AssertModel(models[14],_testData[22], false);
                        Guiduuid0M.AssertModel(models[15],_testData[23], false);
                        Guiduuid0M.AssertModel(models[16],_testData[24], false);
                        Guiduuid0M.AssertModel(models[17],_testData[25], false);
                        Guiduuid0M.AssertModel(models[18],_testData[26], false);
                        Guiduuid0M.AssertModel(models[19],_testData[27], false);
                        Guiduuid0M.AssertModel(models[20],_testData[28], false);
                        Guiduuid0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[29], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[29], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 103, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduuid0M.AssertModel(models[0],_testData[6], false);
                        Guiduuid0M.AssertModel(models[1],_testData[7], false);
                        Guiduuid0M.AssertModel(models[2],_testData[8], false);
                        Guiduuid0M.AssertModel(models[3],_testData[9], false);
                        Guiduuid0M.AssertModel(models[4],_testData[10], false);
                        Guiduuid0M.AssertModel(models[5],_testData[11], false);
                        Guiduuid0M.AssertModel(models[6],_testData[12], false);
                        Guiduuid0M.AssertModel(models[7],_testData[13], false);
                        Guiduuid0M.AssertModel(models[8],_testData[14], false);
                        Guiduuid0M.AssertModel(models[9],_testData[15], false);
                        Guiduuid0M.AssertModel(models[10],_testData[16], false);
                        Guiduuid0M.AssertModel(models[11],_testData[17], false);
                        Guiduuid0M.AssertModel(models[12],_testData[18], false);
                        Guiduuid0M.AssertModel(models[13],_testData[19], false);
                        Guiduuid0M.AssertModel(models[14],_testData[20], false);
                        Guiduuid0M.AssertModel(models[15],_testData[21], false);
                        Guiduuid0M.AssertModel(models[16],_testData[22], false);
                        Guiduuid0M.AssertModel(models[17],_testData[23], false);
                        Guiduuid0M.AssertModel(models[18],_testData[24], false);
                        Guiduuid0M.AssertModel(models[19],_testData[25], false);
                        Guiduuid0M.AssertModel(models[20],_testData[26], false);
                        Guiduuid0M.AssertModel(models[21],_testData[27], false);
                        Guiduuid0M.AssertModel(models[22],_testData[28], false);
                        Guiduuid0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduuid0M.AssertModel(models[0],_testData[6], false);
                        Guiduuid0M.AssertModel(models[1],_testData[7], false);
                        Guiduuid0M.AssertModel(models[2],_testData[8], false);
                        Guiduuid0M.AssertModel(models[3],_testData[9], false);
                        Guiduuid0M.AssertModel(models[4],_testData[10], false);
                        Guiduuid0M.AssertModel(models[5],_testData[11], false);
                        Guiduuid0M.AssertModel(models[6],_testData[12], false);
                        Guiduuid0M.AssertModel(models[7],_testData[13], false);
                        Guiduuid0M.AssertModel(models[8],_testData[14], false);
                        Guiduuid0M.AssertModel(models[9],_testData[15], false);
                        Guiduuid0M.AssertModel(models[10],_testData[16], false);
                        Guiduuid0M.AssertModel(models[11],_testData[17], false);
                        Guiduuid0M.AssertModel(models[12],_testData[18], false);
                        Guiduuid0M.AssertModel(models[13],_testData[19], false);
                        Guiduuid0M.AssertModel(models[14],_testData[20], false);
                        Guiduuid0M.AssertModel(models[15],_testData[21], false);
                        Guiduuid0M.AssertModel(models[16],_testData[22], false);
                        Guiduuid0M.AssertModel(models[17],_testData[23], false);
                        Guiduuid0M.AssertModel(models[18],_testData[24], false);
                        Guiduuid0M.AssertModel(models[19],_testData[25], false);
                        Guiduuid0M.AssertModel(models[20],_testData[26], false);
                        Guiduuid0M.AssertModel(models[21],_testData[27], false);
                        Guiduuid0M.AssertModel(models[22],_testData[28], false);
                        Guiduuid0M.AssertModel(models[23],_testData[29], false);
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
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 22, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduuid0M.AssertModel(models[0],_testData[6], false);
                        Guiduuid0M.AssertModel(models[1],_testData[7], false);
                        Guiduuid0M.AssertModel(models[2],_testData[8], false);
                        Guiduuid0M.AssertModel(models[3],_testData[9], false);
                        Guiduuid0M.AssertModel(models[4],_testData[10], false);
                        Guiduuid0M.AssertModel(models[5],_testData[11], false);
                        Guiduuid0M.AssertModel(models[6],_testData[12], false);
                        Guiduuid0M.AssertModel(models[7],_testData[13], false);
                        Guiduuid0M.AssertModel(models[8],_testData[14], false);
                        Guiduuid0M.AssertModel(models[9],_testData[15], false);
                        Guiduuid0M.AssertModel(models[10],_testData[16], false);
                        Guiduuid0M.AssertModel(models[11],_testData[17], false);
                        Guiduuid0M.AssertModel(models[12],_testData[18], false);
                        Guiduuid0M.AssertModel(models[13],_testData[19], false);
                        Guiduuid0M.AssertModel(models[14],_testData[20], false);
                        Guiduuid0M.AssertModel(models[15],_testData[21], false);
                        Guiduuid0M.AssertModel(models[16],_testData[22], false);
                        Guiduuid0M.AssertModel(models[17],_testData[23], false);
                        Guiduuid0M.AssertModel(models[18],_testData[24], false);
                        Guiduuid0M.AssertModel(models[19],_testData[25], false);
                        Guiduuid0M.AssertModel(models[20],_testData[26], false);
                        Guiduuid0M.AssertModel(models[21],_testData[27], false);
                        Guiduuid0M.AssertModel(models[22],_testData[28], false);
                        Guiduuid0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Guiduuid0M.AssertModel(models[0],_testData[15], false);
                        Guiduuid0M.AssertModel(models[1],_testData[16], false);
                        Guiduuid0M.AssertModel(models[2],_testData[17], false);
                        Guiduuid0M.AssertModel(models[3],_testData[18], false);
                        Guiduuid0M.AssertModel(models[4],_testData[19], false);
                        Guiduuid0M.AssertModel(models[5],_testData[20], false);
                        Guiduuid0M.AssertModel(models[6],_testData[21], false);
                        Guiduuid0M.AssertModel(models[7],_testData[22], false);
                        Guiduuid0M.AssertModel(models[8],_testData[23], false);
                        Guiduuid0M.AssertModel(models[9],_testData[24], false);
                        Guiduuid0M.AssertModel(models[10],_testData[25], false);
                        Guiduuid0M.AssertModel(models[11],_testData[26], false);
                        Guiduuid0M.AssertModel(models[12],_testData[27], false);
                        Guiduuid0M.AssertModel(models[13],_testData[28], false);
                        Guiduuid0M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Guiduuid0M.AssertModel(models[0],_testData[15], false);Guiduuid0M.AssertModel(models[1],_testData[16], false);Guiduuid0M.AssertModel(models[2],_testData[17], false);Guiduuid0M.AssertModel(models[3],_testData[18], false);Guiduuid0M.AssertModel(models[4],_testData[19], false);Guiduuid0M.AssertModel(models[5],_testData[20], false);Guiduuid0M.AssertModel(models[6],_testData[21], false);Guiduuid0M.AssertModel(models[7],_testData[22], false);Guiduuid0M.AssertModel(models[8],_testData[23], false);Guiduuid0M.AssertModel(models[9],_testData[24], false);Guiduuid0M.AssertModel(models[10],_testData[25], false);Guiduuid0M.AssertModel(models[11],_testData[26], false);Guiduuid0M.AssertModel(models[12],_testData[27], false);Guiduuid0M.AssertModel(models[13],_testData[28], false);Guiduuid0M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Guiduuid0M.AssertModel(models[0],_testData[22], false);Guiduuid0M.AssertModel(models[1],_testData[23], false);Guiduuid0M.AssertModel(models[2],_testData[24], false);Guiduuid0M.AssertModel(models[3],_testData[25], false);Guiduuid0M.AssertModel(models[4],_testData[26], false);Guiduuid0M.AssertModel(models[5],_testData[27], false);Guiduuid0M.AssertModel(models[6],_testData[28], false);Guiduuid0M.AssertModel(models[7],_testData[29], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a876b127-ccea-47a2-baad-02f447d37329"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bffcec6a-7bac-4923-9834-be6bb92540dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de799c57-75c2-4a15-9d78-658e356c1823"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8d70f1c2-711c-4e4f-89b3-f996435e934d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d36d828-63b6-4ae7-b64c-033317aed7cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("29a5afda-7986-4f24-a2fb-dc644992046f"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1e30c27-3b90-4d4a-8240-dc7791bb799e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49eccc95-b9fb-4826-b670-1411acef692e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1060851-9316-4d07-b756-b187bd2506f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b187ab25-2a1d-4a01-852f-361657ac01d3"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0c37b427-981d-4082-b4f0-6f0805a23723"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b54d820-c703-404e-8761-81c900b57473"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bb0e162b-7b14-4431-acb4-c1b409b85489"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc94f92a-e0ff-4292-81bd-0e12c514b108"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4f47f40-b15b-444b-b69f-e66495d95f70"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16941cc5-9ca2-474a-b6df-a8ca0ff36a8a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bf881f6d-1e76-495b-8f22-a51779c2458a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1cc31da7-89cb-44ae-9f61-ee1983b2cb10"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a4c30477-43ba-40d6-bc86-726766a4becf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d5a137df-b0a0-4022-a943-22527b546657"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d64fa66d-3be8-4e9e-9c8d-4d8ccacc5981"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0af7693-811c-44ab-8fa7-6123a341fc14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d59eecca-99f0-4b97-abc2-274fcdc51490"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e05fcce-685e-4ed0-941d-4fe8c6678366"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d4747bc9-b6dd-405a-9f19-0b19968ca281"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65ebc00a-f0df-404a-9bae-711ec8e1d662"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed91f675-d946-42f5-a290-f879d96a2c99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7b35a7f-d3b2-4c52-b3a4-562e165196ed"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4b77179-01df-43a4-9a8f-4066f98b1ea9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8840b60b-9947-469a-9474-c063e27c8948"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f697a7d5-191e-4ffb-b818-31c65eb6b766"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c089d823-bbde-4e0f-9369-af43adadddd1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f4aeaec-f46a-49e2-aee1-0895ad2befaf"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("565e939f-c139-4e15-b2b2-c3f41bbf54b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f0b4e2a8-2016-4471-a0ab-9b549c73d143"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d8138e6-3e62-47ab-b530-0267f41199b4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a21b080-e892-4f06-a968-ea1a683bac1c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("23b79207-b887-4d13-ab5c-68ce3a3a72cf"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c5e67778-c4b8-4e7c-9315-248456140ce6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d14ace22-0355-4012-aeca-8914561bf07f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f450be9a-70a1-48fd-aa2b-9d42e1adf51a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0f6a98e-93b3-4327-947b-d391de0be54f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a9551f9b-a5ac-4926-8032-65f15f38eb62"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("72f778eb-3647-49a5-b9ac-cdfbdd97fb58"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("73f74b59-baae-4dac-9949-0db5707057ba"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78f58b27-0ae5-42c5-a226-a5f23163abe0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f2c9136e-be2e-48b0-8535-ce407ca50175"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3e0455ef-783e-41f3-8e70-ea7ae7fa0332"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6ffb55d9-87dd-4699-a5b4-f2a1b935fc2b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d42323a6-9acc-41d5-b70c-6fc7c2910530"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f30f35bf-f990-4825-b040-f159f0aa6fc9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5dbe7fa5-7b19-48a1-8906-806293add714"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("231394d2-aa64-4f67-a61a-c6ae0c4f9cd2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00ad1b47-2b0d-4314-aaa4-f90c7ae32575"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b623040b-6122-4653-aec1-eec7d4f9213c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4e293942-acae-41bb-ad81-6249f0fc1d37"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a28898e-0ab8-4ae1-b5c1-05c988b41e99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbc60ac3-38f3-4fb3-9b79-4a1f859afc6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2637916-b853-44e7-8d73-416753bbde51"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("728f1159-8fde-44fe-8f8e-056569cc837a"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c78605ea-b08d-4b5c-9ced-55a86868abc7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a748bc0b-f30f-4f19-8a2c-38fdfaddc8db"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a23e84d0-4963-4c4a-a753-4e68501001b9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8cfd2c65-b63a-4c9a-950f-e10ed34bdae9"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a876b127-ccea-47a2-baad-02f447d37329"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bffcec6a-7bac-4923-9834-be6bb92540dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de799c57-75c2-4a15-9d78-658e356c1823"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("8d70f1c2-711c-4e4f-89b3-f996435e934d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d36d828-63b6-4ae7-b64c-033317aed7cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("29a5afda-7986-4f24-a2fb-dc644992046f"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1e30c27-3b90-4d4a-8240-dc7791bb799e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49eccc95-b9fb-4826-b670-1411acef692e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1060851-9316-4d07-b756-b187bd2506f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b187ab25-2a1d-4a01-852f-361657ac01d3"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0c37b427-981d-4082-b4f0-6f0805a23723"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b54d820-c703-404e-8761-81c900b57473"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bb0e162b-7b14-4431-acb4-c1b409b85489"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc94f92a-e0ff-4292-81bd-0e12c514b108"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4f47f40-b15b-444b-b69f-e66495d95f70"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("16941cc5-9ca2-474a-b6df-a8ca0ff36a8a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bf881f6d-1e76-495b-8f22-a51779c2458a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1cc31da7-89cb-44ae-9f61-ee1983b2cb10"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a4c30477-43ba-40d6-bc86-726766a4becf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d5a137df-b0a0-4022-a943-22527b546657"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d64fa66d-3be8-4e9e-9c8d-4d8ccacc5981"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0af7693-811c-44ab-8fa7-6123a341fc14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d59eecca-99f0-4b97-abc2-274fcdc51490"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e05fcce-685e-4ed0-941d-4fe8c6678366"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d4747bc9-b6dd-405a-9f19-0b19968ca281"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("65ebc00a-f0df-404a-9bae-711ec8e1d662"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed91f675-d946-42f5-a290-f879d96a2c99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7b35a7f-d3b2-4c52-b3a4-562e165196ed"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4b77179-01df-43a4-9a8f-4066f98b1ea9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8840b60b-9947-469a-9474-c063e27c8948"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f697a7d5-191e-4ffb-b818-31c65eb6b766"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c089d823-bbde-4e0f-9369-af43adadddd1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f4aeaec-f46a-49e2-aee1-0895ad2befaf"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("565e939f-c139-4e15-b2b2-c3f41bbf54b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f0b4e2a8-2016-4471-a0ab-9b549c73d143"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d8138e6-3e62-47ab-b530-0267f41199b4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a21b080-e892-4f06-a968-ea1a683bac1c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("23b79207-b887-4d13-ab5c-68ce3a3a72cf"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c5e67778-c4b8-4e7c-9315-248456140ce6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d14ace22-0355-4012-aeca-8914561bf07f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f450be9a-70a1-48fd-aa2b-9d42e1adf51a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0f6a98e-93b3-4327-947b-d391de0be54f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a9551f9b-a5ac-4926-8032-65f15f38eb62"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("72f778eb-3647-49a5-b9ac-cdfbdd97fb58"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("73f74b59-baae-4dac-9949-0db5707057ba"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78f58b27-0ae5-42c5-a226-a5f23163abe0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f2c9136e-be2e-48b0-8535-ce407ca50175"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3e0455ef-783e-41f3-8e70-ea7ae7fa0332"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6ffb55d9-87dd-4699-a5b4-f2a1b935fc2b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d42323a6-9acc-41d5-b70c-6fc7c2910530"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f30f35bf-f990-4825-b040-f159f0aa6fc9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5dbe7fa5-7b19-48a1-8906-806293add714"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("231394d2-aa64-4f67-a61a-c6ae0c4f9cd2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("00ad1b47-2b0d-4314-aaa4-f90c7ae32575"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b623040b-6122-4653-aec1-eec7d4f9213c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4e293942-acae-41bb-ad81-6249f0fc1d37"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a28898e-0ab8-4ae1-b5c1-05c988b41e99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbc60ac3-38f3-4fb3-9b79-4a1f859afc6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2637916-b853-44e7-8d73-416753bbde51"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("728f1159-8fde-44fe-8f8e-056569cc837a"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c78605ea-b08d-4b5c-9ced-55a86868abc7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a748bc0b-f30f-4f19-8a2c-38fdfaddc8db"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a23e84d0-4963-4c4a-a753-4e68501001b9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8cfd2c65-b63a-4c9a-950f-e10ed34bdae9"))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Guiduuid0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
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
                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuid0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
FROM public.binary_guiduuid0m m
LEFT JOIN public.binary_guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Guiduuid0M>(15);

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
                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
                Guiduuid0M.AssertModel(models[15],_testData[15], false);
                Guiduuid0M.AssertModel(models[16],_testData[16], false);
                Guiduuid0M.AssertModel(models[17],_testData[17], false);
                Guiduuid0M.AssertModel(models[18],_testData[18], false);
                Guiduuid0M.AssertModel(models[19],_testData[19], false);
                Guiduuid0M.AssertModel(models[20],_testData[20], false);
                Guiduuid0M.AssertModel(models[21],_testData[21], false);
                Guiduuid0M.AssertModel(models[22],_testData[22], false);
                Guiduuid0M.AssertModel(models[23],_testData[23], false);
                Guiduuid0M.AssertModel(models[24],_testData[24], false);
                Guiduuid0M.AssertModel(models[25],_testData[25], false);
                Guiduuid0M.AssertModel(models[26],_testData[26], false);
                Guiduuid0M.AssertModel(models[27],_testData[27], false);
                Guiduuid0M.AssertModel(models[28],_testData[28], false);
                Guiduuid0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuid0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

