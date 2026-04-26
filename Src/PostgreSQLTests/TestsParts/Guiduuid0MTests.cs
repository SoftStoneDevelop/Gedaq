

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
    Id = 9,
    Value = Guid.Parse("9b83a26c-2062-4388-b703-c486fd24a561"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 10,
    Value = Guid.Parse("80c88d94-6244-440c-9213-ca290f989dd9"),
    ModelInner = new Guiduuid0MI
{
    Id = 2,
    Value = Guid.Parse("3f54fbde-bda7-4175-84c7-d7a328da9e61"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b8ed8030-6d20-468e-8cc5-db5fd9cc02d9"),
},
            new Guiduuid0M
{
    Id = 11,
    Value = Guid.Parse("941a375d-1115-45d1-8fad-9df220516a25"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 15,
    Value = Guid.Parse("ca193f21-f273-4d5f-a7a2-361a89d91cf4"),
    ModelInner = new Guiduuid0MI
{
    Id = 5,
    Value = Guid.Parse("875e9bbd-9766-49d7-8231-ede50e687ecc"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 20,
    Value = Guid.Parse("841c7803-09c6-4d65-96c3-51af384d51da"),
    ModelInner = null,
    NullableValue = Guid.Parse("efa2b8e3-0ce0-4e66-9afb-92c062dd51b0"),
},
            new Guiduuid0M
{
    Id = 26,
    Value = Guid.Parse("4ecd269c-001c-4966-bf42-1b626d7f12b7"),
    ModelInner = new Guiduuid0MI
{
    Id = 14,
    Value = Guid.Parse("cc4a3d94-6d7a-45f4-9fa4-bdfee859f2e0"),
    NullableValue = Guid.Parse("2b16e804-b757-4436-90cf-4d827d2664d7"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 31,
    Value = Guid.Parse("c4c0cb4b-4fbb-4d96-87ae-ff892c1ea900"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 32,
    Value = Guid.Parse("c0e2abe9-f374-4a1d-ad99-2d8fc61c7a02"),
    ModelInner = new Guiduuid0MI
{
    Id = 16,
    Value = Guid.Parse("74f0146e-935f-4d0b-9b5c-cfeca3c42c3f"),
    NullableValue = Guid.Parse("7f0e7b3e-3196-4511-8540-8acfe7a0ba86"),
},
    NullableValue = Guid.Parse("c30aafa0-d470-4b52-9b0a-c99e5b4fbe5a"),
},
            new Guiduuid0M
{
    Id = 40,
    Value = Guid.Parse("813686f3-af3c-45c9-9b6c-e9cf861310d6"),
    ModelInner = null,
    NullableValue = Guid.Parse("b820215c-7c35-4e65-ac20-a5febb883207"),
},
            new Guiduuid0M
{
    Id = 47,
    Value = Guid.Parse("1db16b9d-2d9a-45fb-8d45-dc71c1415fa8"),
    ModelInner = new Guiduuid0MI
{
    Id = 22,
    Value = Guid.Parse("42e7e0b5-fa76-4077-a40f-024af3ff8a61"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 52,
    Value = Guid.Parse("2505e380-cc23-4fbe-94be-a49b53bb9a62"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 59,
    Value = Guid.Parse("e43945c2-3c67-4020-b3a7-8bd31cbd2b44"),
    ModelInner = new Guiduuid0MI
{
    Id = 25,
    Value = Guid.Parse("50eaec8e-e8f4-43ce-adb2-80c0a172f6a1"),
    NullableValue = Guid.Parse("1ecdf6fb-6d95-4bd3-822d-a732d8f81009"),
},
    NullableValue = Guid.Parse("e8d698a8-3660-4e41-bc7f-dfbf7f375873"),
},
            new Guiduuid0M
{
    Id = 64,
    Value = Guid.Parse("b0ce42e4-8a49-42f5-9cc0-8fc78466bd14"),
    ModelInner = null,
    NullableValue = Guid.Parse("429df490-7fb5-4685-ab12-5e57e4464f6e"),
},
            new Guiduuid0M
{
    Id = 71,
    Value = Guid.Parse("70ecf9b7-63b2-497f-a807-35947e313bcf"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("b463096a-7083-406c-bfad-b81aaf98f38c"),
    NullableValue = Guid.Parse("48cce021-34f1-4538-807f-26260c5dfec8"),
},
    NullableValue = Guid.Parse("1edd02c7-0ed5-492f-93b2-12c46133ad7e"),
},
            new Guiduuid0M
{
    Id = 72,
    Value = Guid.Parse("a99e6e36-7541-47f6-a341-e15e74586dff"),
    ModelInner = null,
    NullableValue = Guid.Parse("6944b1aa-dbbd-4bf6-8e1a-393da8aa235b"),
},
            new Guiduuid0M
{
    Id = 75,
    Value = Guid.Parse("079a3e92-434d-4c59-ae74-155878e9d0ef"),
    ModelInner = new Guiduuid0MI
{
    Id = 42,
    Value = Guid.Parse("35386bd1-6907-4dee-ad8f-a69ff260ef9c"),
    NullableValue = Guid.Parse("9c362f8e-24f0-484a-9aa8-d65f8f52b29d"),
},
    NullableValue = Guid.Parse("6e31f991-585e-4e52-bc73-173c8cd5563c"),
},
            new Guiduuid0M
{
    Id = 80,
    Value = Guid.Parse("21dc92bb-052c-4fe2-a8c4-03c81fbcfcd8"),
    ModelInner = null,
    NullableValue = Guid.Parse("1d487d53-d362-4c35-aa31-ba4c99d204de"),
},
            new Guiduuid0M
{
    Id = 88,
    Value = Guid.Parse("a7462f8e-ba6c-4474-8c23-bb2166695d9e"),
    ModelInner = new Guiduuid0MI
{
    Id = 48,
    Value = Guid.Parse("a159bce7-ed6e-43d6-88b7-7c2a2c7fe010"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 92,
    Value = Guid.Parse("62417e94-be4e-4295-b659-36ddc5e0ea2c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 101,
    Value = Guid.Parse("77849dd6-d803-4ae4-8a5e-61c7b811328a"),
    ModelInner = new Guiduuid0MI
{
    Id = 57,
    Value = Guid.Parse("dc82c6eb-69bf-4483-90f7-f1d7cce3020f"),
    NullableValue = Guid.Parse("90a4e890-b0ca-4462-9bcd-64c608c75670"),
},
    NullableValue = Guid.Parse("0b2ba404-0a5d-4084-bea9-b87b9cfd5d7d"),
},
            new Guiduuid0M
{
    Id = 104,
    Value = Guid.Parse("d799ed64-f90e-4d03-a673-a75280f50fa2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("6555ee93-3d61-4644-8f97-820ef00c49de"),
    ModelInner = new Guiduuid0MI
{
    Id = 66,
    Value = Guid.Parse("3b7ad6e8-2cf4-4075-82ba-190fea8de7c3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("696dfae5-b7f4-4e91-9039-737934316248"),
},
            new Guiduuid0M
{
    Id = 117,
    Value = Guid.Parse("036347cf-2c16-4651-b9a9-421c052f98ee"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 118,
    Value = Guid.Parse("548cc63d-c052-484f-acdc-62f9456a4db9"),
    ModelInner = new Guiduuid0MI
{
    Id = 69,
    Value = Guid.Parse("58a0f17f-1079-497d-8520-f37b1ce7bbcf"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 120,
    Value = Guid.Parse("20503f0c-4a3a-4f2d-8dd3-be1d5f4fd082"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 121,
    Value = Guid.Parse("b7893b32-1e57-498d-a982-cbaa66e2957f"),
    ModelInner = new Guiduuid0MI
{
    Id = 74,
    Value = Guid.Parse("e59ff5c6-c90f-4288-9d37-ee1bc3703411"),
    NullableValue = Guid.Parse("448def98-bf37-41fd-a718-b22c7ff63544"),
},
    NullableValue = Guid.Parse("b530bafa-d004-4ed1-b2e4-54c647a4e363"),
},
            new Guiduuid0M
{
    Id = 129,
    Value = Guid.Parse("bdaae7ed-6f72-42fb-9095-fa1d77687c12"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 130,
    Value = Guid.Parse("360df8af-23c1-4061-8869-29d082f1c417"),
    ModelInner = new Guiduuid0MI
{
    Id = 79,
    Value = Guid.Parse("0f07445c-ea32-4eca-94d3-dd95dcd00d56"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9c64a3b9-6af0-4316-a1cb-a94c0dbac506"),
},
            new Guiduuid0M
{
    Id = 133,
    Value = Guid.Parse("0141dc8c-4ad4-4ee9-b4f4-b9f4afcf7213"),
    ModelInner = null,
    NullableValue = Guid.Parse("a282c2f8-57bb-441a-8bc2-4b55a0569725"),
},
            new Guiduuid0M
{
    Id = 141,
    Value = Guid.Parse("1a3ba728-308d-4c68-8e16-f89be63e60e0"),
    ModelInner = new Guiduuid0MI
{
    Id = 83,
    Value = Guid.Parse("fe4addf0-8730-41bc-8d7e-47311d28e8e4"),
    NullableValue = Guid.Parse("06bedc58-1d9c-40be-95fc-4d45d471f475"),
},
    NullableValue = Guid.Parse("6c76154d-f548-4a63-8321-a5d91081e413"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("efa2b8e3-0ce0-4e66-9afb-92c062dd51b0")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c30aafa0-d470-4b52-9b0a-c99e5b4fbe5a")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("b820215c-7c35-4e65-ac20-a5febb883207")));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("e8d698a8-3660-4e41-bc7f-dfbf7f375873")));
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IGuidSingleTypeuuid)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IGuidSingleTypeuuid)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuid0M.AssertModel(models[0],_testData[12], false);FlatGuiduuid0M.AssertModel(models[1],_testData[13], false);FlatGuiduuid0M.AssertModel(models[2],_testData[14], false);FlatGuiduuid0M.AssertModel(models[3],_testData[15], false);FlatGuiduuid0M.AssertModel(models[4],_testData[16], false);FlatGuiduuid0M.AssertModel(models[5],_testData[17], false);FlatGuiduuid0M.AssertModel(models[6],_testData[18], false);FlatGuiduuid0M.AssertModel(models[7],_testData[19], false);FlatGuiduuid0M.AssertModel(models[8],_testData[20], false);FlatGuiduuid0M.AssertModel(models[9],_testData[21], false);FlatGuiduuid0M.AssertModel(models[10],_testData[22], false);FlatGuiduuid0M.AssertModel(models[11],_testData[23], false);FlatGuiduuid0M.AssertModel(models[12],_testData[24], false);FlatGuiduuid0M.AssertModel(models[13],_testData[25], false);FlatGuiduuid0M.AssertModel(models[14],_testData[26], false);FlatGuiduuid0M.AssertModel(models[15],_testData[27], false);FlatGuiduuid0M.AssertModel(models[16],_testData[28], false);FlatGuiduuid0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuid0M.AssertModel(models[0],_testData[18], false);FlatGuiduuid0M.AssertModel(models[1],_testData[19], false);FlatGuiduuid0M.AssertModel(models[2],_testData[20], false);FlatGuiduuid0M.AssertModel(models[3],_testData[21], false);FlatGuiduuid0M.AssertModel(models[4],_testData[22], false);FlatGuiduuid0M.AssertModel(models[5],_testData[23], false);FlatGuiduuid0M.AssertModel(models[6],_testData[24], false);FlatGuiduuid0M.AssertModel(models[7],_testData[25], false);FlatGuiduuid0M.AssertModel(models[8],_testData[26], false);FlatGuiduuid0M.AssertModel(models[9],_testData[27], false);FlatGuiduuid0M.AssertModel(models[10],_testData[28], false);FlatGuiduuid0M.AssertModel(models[11],_testData[29], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuid0M.AssertModel(models[0],_testData[2], false);FlatGuiduuid0M.AssertModel(models[1],_testData[3], false);FlatGuiduuid0M.AssertModel(models[2],_testData[4], false);FlatGuiduuid0M.AssertModel(models[3],_testData[5], false);FlatGuiduuid0M.AssertModel(models[4],_testData[6], false);FlatGuiduuid0M.AssertModel(models[5],_testData[7], false);FlatGuiduuid0M.AssertModel(models[6],_testData[8], false);FlatGuiduuid0M.AssertModel(models[7],_testData[9], false);FlatGuiduuid0M.AssertModel(models[8],_testData[10], false);FlatGuiduuid0M.AssertModel(models[9],_testData[11], false);FlatGuiduuid0M.AssertModel(models[10],_testData[12], false);FlatGuiduuid0M.AssertModel(models[11],_testData[13], false);FlatGuiduuid0M.AssertModel(models[12],_testData[14], false);FlatGuiduuid0M.AssertModel(models[13],_testData[15], false);FlatGuiduuid0M.AssertModel(models[14],_testData[16], false);FlatGuiduuid0M.AssertModel(models[15],_testData[17], false);FlatGuiduuid0M.AssertModel(models[16],_testData[18], false);FlatGuiduuid0M.AssertModel(models[17],_testData[19], false);FlatGuiduuid0M.AssertModel(models[18],_testData[20], false);FlatGuiduuid0M.AssertModel(models[19],_testData[21], false);FlatGuiduuid0M.AssertModel(models[20],_testData[22], false);FlatGuiduuid0M.AssertModel(models[21],_testData[23], false);FlatGuiduuid0M.AssertModel(models[22],_testData[24], false);FlatGuiduuid0M.AssertModel(models[23],_testData[25], false);FlatGuiduuid0M.AssertModel(models[24],_testData[26], false);FlatGuiduuid0M.AssertModel(models[25],_testData[27], false);FlatGuiduuid0M.AssertModel(models[26],_testData[28], false);FlatGuiduuid0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Guiduuid0M.AssertModel(models[0],_testData[6], false);Guiduuid0M.AssertModel(models[1],_testData[7], false);Guiduuid0M.AssertModel(models[2],_testData[8], false);Guiduuid0M.AssertModel(models[3],_testData[9], false);Guiduuid0M.AssertModel(models[4],_testData[10], false);Guiduuid0M.AssertModel(models[5],_testData[11], false);Guiduuid0M.AssertModel(models[6],_testData[12], false);Guiduuid0M.AssertModel(models[7],_testData[13], false);Guiduuid0M.AssertModel(models[8],_testData[14], false);Guiduuid0M.AssertModel(models[9],_testData[15], false);Guiduuid0M.AssertModel(models[10],_testData[16], false);Guiduuid0M.AssertModel(models[11],_testData[17], false);Guiduuid0M.AssertModel(models[12],_testData[18], false);Guiduuid0M.AssertModel(models[13],_testData[19], false);Guiduuid0M.AssertModel(models[14],_testData[20], false);Guiduuid0M.AssertModel(models[15],_testData[21], false);Guiduuid0M.AssertModel(models[16],_testData[22], false);Guiduuid0M.AssertModel(models[17],_testData[23], false);Guiduuid0M.AssertModel(models[18],_testData[24], false);Guiduuid0M.AssertModel(models[19],_testData[25], false);Guiduuid0M.AssertModel(models[20],_testData[26], false);Guiduuid0M.AssertModel(models[21],_testData[27], false);Guiduuid0M.AssertModel(models[22],_testData[28], false);Guiduuid0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Guiduuid0M.AssertModel(models[0],_testData[20], false);Guiduuid0M.AssertModel(models[1],_testData[21], false);Guiduuid0M.AssertModel(models[2],_testData[22], false);Guiduuid0M.AssertModel(models[3],_testData[23], false);Guiduuid0M.AssertModel(models[4],_testData[24], false);Guiduuid0M.AssertModel(models[5],_testData[25], false);Guiduuid0M.AssertModel(models[6],_testData[26], false);Guiduuid0M.AssertModel(models[7],_testData[27], false);Guiduuid0M.AssertModel(models[8],_testData[28], false);Guiduuid0M.AssertModel(models[9],_testData[29], false);
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

                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Guiduuid0M.AssertModel(models[0],_testData[19], false);Guiduuid0M.AssertModel(models[1],_testData[20], false);Guiduuid0M.AssertModel(models[2],_testData[21], false);Guiduuid0M.AssertModel(models[3],_testData[22], false);Guiduuid0M.AssertModel(models[4],_testData[23], false);Guiduuid0M.AssertModel(models[5],_testData[24], false);Guiduuid0M.AssertModel(models[6],_testData[25], false);Guiduuid0M.AssertModel(models[7],_testData[26], false);Guiduuid0M.AssertModel(models[8],_testData[27], false);Guiduuid0M.AssertModel(models[9],_testData[28], false);Guiduuid0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
Guiduuid0M.AssertModel(models[0],_testData[26], false);Guiduuid0M.AssertModel(models[1],_testData[27], false);Guiduuid0M.AssertModel(models[2],_testData[28], false);Guiduuid0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatGuiduuid0M.AssertModel(models[0],_testData[3], false);FlatGuiduuid0M.AssertModel(models[1],_testData[4], false);FlatGuiduuid0M.AssertModel(models[2],_testData[5], false);FlatGuiduuid0M.AssertModel(models[3],_testData[6], false);FlatGuiduuid0M.AssertModel(models[4],_testData[7], false);FlatGuiduuid0M.AssertModel(models[5],_testData[8], false);FlatGuiduuid0M.AssertModel(models[6],_testData[9], false);FlatGuiduuid0M.AssertModel(models[7],_testData[10], false);FlatGuiduuid0M.AssertModel(models[8],_testData[11], false);FlatGuiduuid0M.AssertModel(models[9],_testData[12], false);FlatGuiduuid0M.AssertModel(models[10],_testData[13], false);FlatGuiduuid0M.AssertModel(models[11],_testData[14], false);FlatGuiduuid0M.AssertModel(models[12],_testData[15], false);FlatGuiduuid0M.AssertModel(models[13],_testData[16], false);FlatGuiduuid0M.AssertModel(models[14],_testData[17], false);FlatGuiduuid0M.AssertModel(models[15],_testData[18], false);FlatGuiduuid0M.AssertModel(models[16],_testData[19], false);FlatGuiduuid0M.AssertModel(models[17],_testData[20], false);FlatGuiduuid0M.AssertModel(models[18],_testData[21], false);FlatGuiduuid0M.AssertModel(models[19],_testData[22], false);FlatGuiduuid0M.AssertModel(models[20],_testData[23], false);FlatGuiduuid0M.AssertModel(models[21],_testData[24], false);FlatGuiduuid0M.AssertModel(models[22],_testData[25], false);FlatGuiduuid0M.AssertModel(models[23],_testData[26], false);FlatGuiduuid0M.AssertModel(models[24],_testData[27], false);FlatGuiduuid0M.AssertModel(models[25],_testData[28], false);FlatGuiduuid0M.AssertModel(models[26],_testData[29], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuid0M.AssertModel(models[0],_testData[18], false);FlatGuiduuid0M.AssertModel(models[1],_testData[19], false);FlatGuiduuid0M.AssertModel(models[2],_testData[20], false);FlatGuiduuid0M.AssertModel(models[3],_testData[21], false);FlatGuiduuid0M.AssertModel(models[4],_testData[22], false);FlatGuiduuid0M.AssertModel(models[5],_testData[23], false);FlatGuiduuid0M.AssertModel(models[6],_testData[24], false);FlatGuiduuid0M.AssertModel(models[7],_testData[25], false);FlatGuiduuid0M.AssertModel(models[8],_testData[26], false);FlatGuiduuid0M.AssertModel(models[9],_testData[27], false);FlatGuiduuid0M.AssertModel(models[10],_testData[28], false);FlatGuiduuid0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuid0M.AssertModel(models[0],_testData[12], false);FlatGuiduuid0M.AssertModel(models[1],_testData[13], false);FlatGuiduuid0M.AssertModel(models[2],_testData[14], false);FlatGuiduuid0M.AssertModel(models[3],_testData[15], false);FlatGuiduuid0M.AssertModel(models[4],_testData[16], false);FlatGuiduuid0M.AssertModel(models[5],_testData[17], false);FlatGuiduuid0M.AssertModel(models[6],_testData[18], false);FlatGuiduuid0M.AssertModel(models[7],_testData[19], false);FlatGuiduuid0M.AssertModel(models[8],_testData[20], false);FlatGuiduuid0M.AssertModel(models[9],_testData[21], false);FlatGuiduuid0M.AssertModel(models[10],_testData[22], false);FlatGuiduuid0M.AssertModel(models[11],_testData[23], false);FlatGuiduuid0M.AssertModel(models[12],_testData[24], false);FlatGuiduuid0M.AssertModel(models[13],_testData[25], false);FlatGuiduuid0M.AssertModel(models[14],_testData[26], false);FlatGuiduuid0M.AssertModel(models[15],_testData[27], false);FlatGuiduuid0M.AssertModel(models[16],_testData[28], false);FlatGuiduuid0M.AssertModel(models[17],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelBatchAsync(connection, 117, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Guiduuid0M.AssertModel(models[0],_testData[23], false);Guiduuid0M.AssertModel(models[1],_testData[24], false);Guiduuid0M.AssertModel(models[2],_testData[25], false);Guiduuid0M.AssertModel(models[3],_testData[26], false);Guiduuid0M.AssertModel(models[4],_testData[27], false);Guiduuid0M.AssertModel(models[5],_testData[28], false);Guiduuid0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Guiduuid0M.AssertModel(models[0],_testData[9], false);Guiduuid0M.AssertModel(models[1],_testData[10], false);Guiduuid0M.AssertModel(models[2],_testData[11], false);Guiduuid0M.AssertModel(models[3],_testData[12], false);Guiduuid0M.AssertModel(models[4],_testData[13], false);Guiduuid0M.AssertModel(models[5],_testData[14], false);Guiduuid0M.AssertModel(models[6],_testData[15], false);Guiduuid0M.AssertModel(models[7],_testData[16], false);Guiduuid0M.AssertModel(models[8],_testData[17], false);Guiduuid0M.AssertModel(models[9],_testData[18], false);Guiduuid0M.AssertModel(models[10],_testData[19], false);Guiduuid0M.AssertModel(models[11],_testData[20], false);Guiduuid0M.AssertModel(models[12],_testData[21], false);Guiduuid0M.AssertModel(models[13],_testData[22], false);Guiduuid0M.AssertModel(models[14],_testData[23], false);Guiduuid0M.AssertModel(models[15],_testData[24], false);Guiduuid0M.AssertModel(models[16],_testData[25], false);Guiduuid0M.AssertModel(models[17],_testData[26], false);Guiduuid0M.AssertModel(models[18],_testData[27], false);Guiduuid0M.AssertModel(models[19],_testData[28], false);Guiduuid0M.AssertModel(models[20],_testData[29], false);
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
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelBatch(connection, 40, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Guiduuid0M.AssertModel(models[0],_testData[9], false);Guiduuid0M.AssertModel(models[1],_testData[10], false);Guiduuid0M.AssertModel(models[2],_testData[11], false);Guiduuid0M.AssertModel(models[3],_testData[12], false);Guiduuid0M.AssertModel(models[4],_testData[13], false);Guiduuid0M.AssertModel(models[5],_testData[14], false);Guiduuid0M.AssertModel(models[6],_testData[15], false);Guiduuid0M.AssertModel(models[7],_testData[16], false);Guiduuid0M.AssertModel(models[8],_testData[17], false);Guiduuid0M.AssertModel(models[9],_testData[18], false);Guiduuid0M.AssertModel(models[10],_testData[19], false);Guiduuid0M.AssertModel(models[11],_testData[20], false);Guiduuid0M.AssertModel(models[12],_testData[21], false);Guiduuid0M.AssertModel(models[13],_testData[22], false);Guiduuid0M.AssertModel(models[14],_testData[23], false);Guiduuid0M.AssertModel(models[15],_testData[24], false);Guiduuid0M.AssertModel(models[16],_testData[25], false);Guiduuid0M.AssertModel(models[17],_testData[26], false);Guiduuid0M.AssertModel(models[18],_testData[27], false);Guiduuid0M.AssertModel(models[19],_testData[28], false);Guiduuid0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Guiduuid0M.AssertModel(models[0],_testData[10], false);Guiduuid0M.AssertModel(models[1],_testData[11], false);Guiduuid0M.AssertModel(models[2],_testData[12], false);Guiduuid0M.AssertModel(models[3],_testData[13], false);Guiduuid0M.AssertModel(models[4],_testData[14], false);Guiduuid0M.AssertModel(models[5],_testData[15], false);Guiduuid0M.AssertModel(models[6],_testData[16], false);Guiduuid0M.AssertModel(models[7],_testData[17], false);Guiduuid0M.AssertModel(models[8],_testData[18], false);Guiduuid0M.AssertModel(models[9],_testData[19], false);Guiduuid0M.AssertModel(models[10],_testData[20], false);Guiduuid0M.AssertModel(models[11],_testData[21], false);Guiduuid0M.AssertModel(models[12],_testData[22], false);Guiduuid0M.AssertModel(models[13],_testData[23], false);Guiduuid0M.AssertModel(models[14],_testData[24], false);Guiduuid0M.AssertModel(models[15],_testData[25], false);Guiduuid0M.AssertModel(models[16],_testData[26], false);Guiduuid0M.AssertModel(models[17],_testData[27], false);Guiduuid0M.AssertModel(models[18],_testData[28], false);Guiduuid0M.AssertModel(models[19],_testData[29], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Guiduuid0M.AssertModel(models[0],_testData[10], false);Guiduuid0M.AssertModel(models[1],_testData[11], false);Guiduuid0M.AssertModel(models[2],_testData[12], false);Guiduuid0M.AssertModel(models[3],_testData[13], false);Guiduuid0M.AssertModel(models[4],_testData[14], false);Guiduuid0M.AssertModel(models[5],_testData[15], false);Guiduuid0M.AssertModel(models[6],_testData[16], false);Guiduuid0M.AssertModel(models[7],_testData[17], false);Guiduuid0M.AssertModel(models[8],_testData[18], false);Guiduuid0M.AssertModel(models[9],_testData[19], false);Guiduuid0M.AssertModel(models[10],_testData[20], false);Guiduuid0M.AssertModel(models[11],_testData[21], false);Guiduuid0M.AssertModel(models[12],_testData[22], false);Guiduuid0M.AssertModel(models[13],_testData[23], false);Guiduuid0M.AssertModel(models[14],_testData[24], false);Guiduuid0M.AssertModel(models[15],_testData[25], false);Guiduuid0M.AssertModel(models[16],_testData[26], false);Guiduuid0M.AssertModel(models[17],_testData[27], false);Guiduuid0M.AssertModel(models[18],_testData[28], false);Guiduuid0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 110);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b83a26c-2062-4388-b703-c486fd24a561"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80c88d94-6244-440c-9213-ca290f989dd9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3f54fbde-bda7-4175-84c7-d7a328da9e61"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8ed8030-6d20-468e-8cc5-db5fd9cc02d9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("941a375d-1115-45d1-8fad-9df220516a25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca193f21-f273-4d5f-a7a2-361a89d91cf4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("875e9bbd-9766-49d7-8231-ede50e687ecc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("841c7803-09c6-4d65-96c3-51af384d51da"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("efa2b8e3-0ce0-4e66-9afb-92c062dd51b0"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ecd269c-001c-4966-bf42-1b626d7f12b7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cc4a3d94-6d7a-45f4-9fa4-bdfee859f2e0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2b16e804-b757-4436-90cf-4d827d2664d7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4c0cb4b-4fbb-4d96-87ae-ff892c1ea900"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c0e2abe9-f374-4a1d-ad99-2d8fc61c7a02"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74f0146e-935f-4d0b-9b5c-cfeca3c42c3f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7f0e7b3e-3196-4511-8540-8acfe7a0ba86"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c30aafa0-d470-4b52-9b0a-c99e5b4fbe5a"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("813686f3-af3c-45c9-9b6c-e9cf861310d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b820215c-7c35-4e65-ac20-a5febb883207"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1db16b9d-2d9a-45fb-8d45-dc71c1415fa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("42e7e0b5-fa76-4077-a40f-024af3ff8a61"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2505e380-cc23-4fbe-94be-a49b53bb9a62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e43945c2-3c67-4020-b3a7-8bd31cbd2b44"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("50eaec8e-e8f4-43ce-adb2-80c0a172f6a1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1ecdf6fb-6d95-4bd3-822d-a732d8f81009"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e8d698a8-3660-4e41-bc7f-dfbf7f375873"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0ce42e4-8a49-42f5-9cc0-8fc78466bd14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("429df490-7fb5-4685-ab12-5e57e4464f6e"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70ecf9b7-63b2-497f-a807-35947e313bcf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b463096a-7083-406c-bfad-b81aaf98f38c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("48cce021-34f1-4538-807f-26260c5dfec8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1edd02c7-0ed5-492f-93b2-12c46133ad7e"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a99e6e36-7541-47f6-a341-e15e74586dff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6944b1aa-dbbd-4bf6-8e1a-393da8aa235b"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("079a3e92-434d-4c59-ae74-155878e9d0ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35386bd1-6907-4dee-ad8f-a69ff260ef9c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9c362f8e-24f0-484a-9aa8-d65f8f52b29d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e31f991-585e-4e52-bc73-173c8cd5563c"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("21dc92bb-052c-4fe2-a8c4-03c81fbcfcd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d487d53-d362-4c35-aa31-ba4c99d204de"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7462f8e-ba6c-4474-8c23-bb2166695d9e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a159bce7-ed6e-43d6-88b7-7c2a2c7fe010"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62417e94-be4e-4295-b659-36ddc5e0ea2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77849dd6-d803-4ae4-8a5e-61c7b811328a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc82c6eb-69bf-4483-90f7-f1d7cce3020f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("90a4e890-b0ca-4462-9bcd-64c608c75670"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b2ba404-0a5d-4084-bea9-b87b9cfd5d7d"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d799ed64-f90e-4d03-a673-a75280f50fa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6555ee93-3d61-4644-8f97-820ef00c49de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3b7ad6e8-2cf4-4075-82ba-190fea8de7c3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("696dfae5-b7f4-4e91-9039-737934316248"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("036347cf-2c16-4651-b9a9-421c052f98ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("548cc63d-c052-484f-acdc-62f9456a4db9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("58a0f17f-1079-497d-8520-f37b1ce7bbcf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20503f0c-4a3a-4f2d-8dd3-be1d5f4fd082"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7893b32-1e57-498d-a982-cbaa66e2957f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e59ff5c6-c90f-4288-9d37-ee1bc3703411"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("448def98-bf37-41fd-a718-b22c7ff63544"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b530bafa-d004-4ed1-b2e4-54c647a4e363"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bdaae7ed-6f72-42fb-9095-fa1d77687c12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("360df8af-23c1-4061-8869-29d082f1c417"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0f07445c-ea32-4eca-94d3-dd95dcd00d56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c64a3b9-6af0-4316-a1cb-a94c0dbac506"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0141dc8c-4ad4-4ee9-b4f4-b9f4afcf7213"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a282c2f8-57bb-441a-8bc2-4b55a0569725"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a3ba728-308d-4c68-8e16-f89be63e60e0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe4addf0-8730-41bc-8d7e-47311d28e8e4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("06bedc58-1d9c-40be-95fc-4d45d471f475"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6c76154d-f548-4a63-8321-a5d91081e413"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b83a26c-2062-4388-b703-c486fd24a561"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80c88d94-6244-440c-9213-ca290f989dd9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3f54fbde-bda7-4175-84c7-d7a328da9e61"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8ed8030-6d20-468e-8cc5-db5fd9cc02d9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("941a375d-1115-45d1-8fad-9df220516a25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca193f21-f273-4d5f-a7a2-361a89d91cf4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("875e9bbd-9766-49d7-8231-ede50e687ecc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("841c7803-09c6-4d65-96c3-51af384d51da"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("efa2b8e3-0ce0-4e66-9afb-92c062dd51b0"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ecd269c-001c-4966-bf42-1b626d7f12b7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cc4a3d94-6d7a-45f4-9fa4-bdfee859f2e0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2b16e804-b757-4436-90cf-4d827d2664d7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4c0cb4b-4fbb-4d96-87ae-ff892c1ea900"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c0e2abe9-f374-4a1d-ad99-2d8fc61c7a02"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74f0146e-935f-4d0b-9b5c-cfeca3c42c3f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7f0e7b3e-3196-4511-8540-8acfe7a0ba86"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c30aafa0-d470-4b52-9b0a-c99e5b4fbe5a"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("813686f3-af3c-45c9-9b6c-e9cf861310d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b820215c-7c35-4e65-ac20-a5febb883207"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1db16b9d-2d9a-45fb-8d45-dc71c1415fa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("42e7e0b5-fa76-4077-a40f-024af3ff8a61"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2505e380-cc23-4fbe-94be-a49b53bb9a62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e43945c2-3c67-4020-b3a7-8bd31cbd2b44"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("50eaec8e-e8f4-43ce-adb2-80c0a172f6a1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1ecdf6fb-6d95-4bd3-822d-a732d8f81009"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e8d698a8-3660-4e41-bc7f-dfbf7f375873"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b0ce42e4-8a49-42f5-9cc0-8fc78466bd14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("429df490-7fb5-4685-ab12-5e57e4464f6e"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70ecf9b7-63b2-497f-a807-35947e313bcf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b463096a-7083-406c-bfad-b81aaf98f38c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("48cce021-34f1-4538-807f-26260c5dfec8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1edd02c7-0ed5-492f-93b2-12c46133ad7e"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a99e6e36-7541-47f6-a341-e15e74586dff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6944b1aa-dbbd-4bf6-8e1a-393da8aa235b"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("079a3e92-434d-4c59-ae74-155878e9d0ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35386bd1-6907-4dee-ad8f-a69ff260ef9c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9c362f8e-24f0-484a-9aa8-d65f8f52b29d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e31f991-585e-4e52-bc73-173c8cd5563c"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("21dc92bb-052c-4fe2-a8c4-03c81fbcfcd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d487d53-d362-4c35-aa31-ba4c99d204de"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a7462f8e-ba6c-4474-8c23-bb2166695d9e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a159bce7-ed6e-43d6-88b7-7c2a2c7fe010"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62417e94-be4e-4295-b659-36ddc5e0ea2c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("77849dd6-d803-4ae4-8a5e-61c7b811328a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc82c6eb-69bf-4483-90f7-f1d7cce3020f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("90a4e890-b0ca-4462-9bcd-64c608c75670"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b2ba404-0a5d-4084-bea9-b87b9cfd5d7d"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d799ed64-f90e-4d03-a673-a75280f50fa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6555ee93-3d61-4644-8f97-820ef00c49de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3b7ad6e8-2cf4-4075-82ba-190fea8de7c3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("696dfae5-b7f4-4e91-9039-737934316248"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("036347cf-2c16-4651-b9a9-421c052f98ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("548cc63d-c052-484f-acdc-62f9456a4db9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("58a0f17f-1079-497d-8520-f37b1ce7bbcf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20503f0c-4a3a-4f2d-8dd3-be1d5f4fd082"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7893b32-1e57-498d-a982-cbaa66e2957f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e59ff5c6-c90f-4288-9d37-ee1bc3703411"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("448def98-bf37-41fd-a718-b22c7ff63544"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b530bafa-d004-4ed1-b2e4-54c647a4e363"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bdaae7ed-6f72-42fb-9095-fa1d77687c12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("360df8af-23c1-4061-8869-29d082f1c417"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0f07445c-ea32-4eca-94d3-dd95dcd00d56"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c64a3b9-6af0-4316-a1cb-a94c0dbac506"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0141dc8c-4ad4-4ee9-b4f4-b9f4afcf7213"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a282c2f8-57bb-441a-8bc2-4b55a0569725"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a3ba728-308d-4c68-8e16-f89be63e60e0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe4addf0-8730-41bc-8d7e-47311d28e8e4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("06bedc58-1d9c-40be-95fc-4d45d471f475"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6c76154d-f548-4a63-8321-a5d91081e413"))));

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

