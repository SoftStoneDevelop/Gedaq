

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

        private readonly GuiduuidE0M[] _testData = new GuiduuidE0M[]
        {
            new GuiduuidE0M
{
    Id = 1,
    Value = Guid.Parse("cd46d73c-3223-4a9d-9bb2-43c840a112c3"),
    ModelInner = null,
    NullableValue = Guid.Parse("f3ad0fa4-ad97-4238-8c96-061ecf574341"),
},
            new GuiduuidE0M
{
    Id = 7,
    Value = Guid.Parse("0a4f17a0-95eb-4791-b43e-cff9466a2a12"),
    ModelInner = new GuiduuidE0MI
{
    Id = 2,
    Value = Guid.Parse("dd192dad-9c8c-4fab-82c8-028ae65d319b"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1c4a3d6d-3619-476f-ac37-6e9c1dbc4b8e"),
},
            new GuiduuidE0M
{
    Id = 12,
    Value = Guid.Parse("f2b052f9-8e2e-4b21-8f91-7c4ae6359bb5"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 17,
    Value = Guid.Parse("18490879-d96d-4fcc-82fc-ee7b77334efa"),
    ModelInner = new GuiduuidE0MI
{
    Id = 7,
    Value = Guid.Parse("4f8f6b47-d87c-459f-930a-10ab6d7f60e8"),
    NullableValue = Guid.Parse("1d863058-be08-4151-9b3f-5a92f09f2997"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 24,
    Value = Guid.Parse("3310bada-b4ad-453c-a000-8238c76f770a"),
    ModelInner = null,
    NullableValue = Guid.Parse("820c9c65-25e5-478d-ba2a-6bd9a177e9c8"),
},
            new GuiduuidE0M
{
    Id = 33,
    Value = Guid.Parse("a3d6f71a-8307-47b1-9eb0-c57d00c1914d"),
    ModelInner = new GuiduuidE0MI
{
    Id = 14,
    Value = Guid.Parse("e9c3051a-1473-46e9-a06f-13f9b83cfe9f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 39,
    Value = Guid.Parse("45b45b4e-6065-4cf6-a108-d22186c3306d"),
    ModelInner = null,
    NullableValue = Guid.Parse("da352ae5-3cc8-4498-bb6b-1a36c1c3320e"),
},
            new GuiduuidE0M
{
    Id = 42,
    Value = Guid.Parse("9e08d254-c0fd-41a4-9657-dda11c9343f8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 22,
    Value = Guid.Parse("b9dd8417-0edc-4290-8615-7ad92fe9c60d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 47,
    Value = Guid.Parse("9b3152c1-a551-422f-95bd-48257c9cac0c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 48,
    Value = Guid.Parse("26b1f3a6-d1f1-4383-84c1-f8059a2f7cae"),
    ModelInner = new GuiduuidE0MI
{
    Id = 23,
    Value = Guid.Parse("65f70a20-6b5b-43db-bc8e-f86c3a5c6346"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("16d4362f-2118-4a83-98bc-03ab614cffc7"),
},
            new GuiduuidE0M
{
    Id = 56,
    Value = Guid.Parse("9dde471e-5ac2-4c58-a655-34b72a3c5fbb"),
    ModelInner = null,
    NullableValue = Guid.Parse("3d58d527-0d21-4da8-a99c-fcf0c7263f3b"),
},
            new GuiduuidE0M
{
    Id = 65,
    Value = Guid.Parse("e8b6d2a6-87ee-4174-a703-5477f2760e01"),
    ModelInner = new GuiduuidE0MI
{
    Id = 26,
    Value = Guid.Parse("21abe60e-d2fd-4d1f-bdb4-ec868ce77b90"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b8d522e8-7e90-4c53-8b4c-ac01a390bcb9"),
},
            new GuiduuidE0M
{
    Id = 73,
    Value = Guid.Parse("dbe78a0b-c263-42a7-b285-2adae5f14457"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 77,
    Value = Guid.Parse("29525270-5356-48d5-9e93-e28508102282"),
    ModelInner = new GuiduuidE0MI
{
    Id = 33,
    Value = Guid.Parse("ea5a8b77-f5f0-4455-b3eb-db27011a5b2b"),
    NullableValue = Guid.Parse("f8da51f3-12c1-4a42-9312-084a44297e09"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 86,
    Value = Guid.Parse("24b1993b-6a55-4a10-97fa-a2c8c8b07a15"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 94,
    Value = Guid.Parse("9f64895f-74bb-4498-ab53-509990f8438a"),
    ModelInner = new GuiduuidE0MI
{
    Id = 40,
    Value = Guid.Parse("07ef5ffe-1dc6-47d0-a0f5-2d6fbb6bd05c"),
    NullableValue = Guid.Parse("39564989-1c3d-44af-b6ae-0a2313a1b90d"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 96,
    Value = Guid.Parse("7b129a48-dde2-49c4-9065-016ff6fe4cf2"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 103,
    Value = Guid.Parse("5aa7108c-e36d-4a53-b075-58bc18a817c0"),
    ModelInner = new GuiduuidE0MI
{
    Id = 47,
    Value = Guid.Parse("328231fa-a2a3-4950-ba0f-4fc7d83695d9"),
    NullableValue = Guid.Parse("6c118965-48ab-4619-bf5c-dc867626cf62"),
},
    NullableValue = Guid.Parse("c869f5ce-7418-4d88-bb98-e1daece08012"),
},
            new GuiduuidE0M
{
    Id = 108,
    Value = Guid.Parse("886a92d5-ffc2-418f-a713-7c91deff386f"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 110,
    Value = Guid.Parse("b73f261d-1e01-4a0b-9a19-8aa88f92cb80"),
    ModelInner = new GuiduuidE0MI
{
    Id = 49,
    Value = Guid.Parse("dd356fee-6a27-405b-b58f-bba32d21b948"),
    NullableValue = Guid.Parse("f9d9b7c3-14e7-44f7-be45-68bb889080f2"),
},
    NullableValue = Guid.Parse("203bd4d8-8a53-4f84-bcd5-55bf237c5da6"),
},
            new GuiduuidE0M
{
    Id = 116,
    Value = Guid.Parse("e4ceb1ab-57f2-475c-98a9-dd1d599ba60d"),
    ModelInner = null,
    NullableValue = Guid.Parse("e4e74f9b-6871-46bf-8d0d-63271d062e5b"),
},
            new GuiduuidE0M
{
    Id = 121,
    Value = Guid.Parse("a6dd798d-5831-485e-b5f9-a945a0296ffc"),
    ModelInner = new GuiduuidE0MI
{
    Id = 56,
    Value = Guid.Parse("aa99c754-54e9-4a72-84a1-82351380f29f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 123,
    Value = Guid.Parse("201dc2fd-1c6c-4b62-85c6-dadbaac0a093"),
    ModelInner = null,
    NullableValue = Guid.Parse("073ae439-511b-47f3-a4b6-3c7ba23bea57"),
},
            new GuiduuidE0M
{
    Id = 126,
    Value = Guid.Parse("1c68333f-502a-46e7-bedd-9c167d443bb8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 65,
    Value = Guid.Parse("b2c8510d-90c4-41d0-92ad-7415cefd23ed"),
    NullableValue = Guid.Parse("9af57c61-2bb7-4edf-ac78-7062f51defb8"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 132,
    Value = Guid.Parse("725625bc-57d8-4565-9db2-19c7667f1cbd"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 134,
    Value = Guid.Parse("67f6123b-afe5-4720-9bdd-ccb364e91b6c"),
    ModelInner = new GuiduuidE0MI
{
    Id = 72,
    Value = Guid.Parse("78694b61-f684-447d-a0ae-a3ca216b3392"),
    NullableValue = Guid.Parse("532a8ee9-dc19-4b0c-b2ec-eadf95bf25f5"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 142,
    Value = Guid.Parse("06350614-364d-49b6-92d3-c48f5e0a9340"),
    ModelInner = null,
    NullableValue = Guid.Parse("da868bfa-5527-45ab-9bfa-b131556a6192"),
},
            new GuiduuidE0M
{
    Id = 147,
    Value = Guid.Parse("242076cc-e552-4be5-8b78-95cdfeb4ab23"),
    ModelInner = new GuiduuidE0MI
{
    Id = 81,
    Value = Guid.Parse("cf582959-146b-4a9a-af59-2f4c0a456068"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0ab8f9cf-905d-4ae7-9142-73deeb5cb283"),
},
            new GuiduuidE0M
{
    Id = 151,
    Value = Guid.Parse("84c9a661-f5af-434e-93e9-37ac3574ccce"),
    ModelInner = null,
    NullableValue = Guid.Parse("f2737fc1-2b8a-4e29-9157-03f94937ddb2"),
},
            new GuiduuidE0M
{
    Id = 156,
    Value = Guid.Parse("19bc1ab9-0614-46fb-9d33-a2f2fb5a190c"),
    ModelInner = new GuiduuidE0MI
{
    Id = 87,
    Value = Guid.Parse("b36200f4-dca2-45f7-8b22-e9c211ddb531"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ee552018-ac28-4152-a9aa-0f8ec6597ef4"),
},
            new GuiduuidE0M
{
    Id = 158,
    Value = Guid.Parse("c9f41dfc-6e12-4faf-babd-b6a886871b9e"),
    ModelInner = null,
    NullableValue = Guid.Parse("38e36e22-b637-4d72-988e-c0aa67303fc0"),
},
            new GuiduuidE0M
{
    Id = 161,
    Value = Guid.Parse("7db0d301-1d44-4d53-8d9c-01b14e0f7ce5"),
    ModelInner = new GuiduuidE0MI
{
    Id = 90,
    Value = Guid.Parse("8359eba9-4ffb-4455-8bd0-db8e0620c226"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 165,
    Value = Guid.Parse("3f739f41-34eb-45e6-a5c3-141a91c2a577"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 167,
    Value = Guid.Parse("936a93f1-7518-49d9-8d11-b53f2a8cb46d"),
    ModelInner = new GuiduuidE0MI
{
    Id = 94,
    Value = Guid.Parse("a3de160a-2f4d-4436-a8e0-52f6f7750ddc"),
    NullableValue = Guid.Parse("fcfdbc22-e5cc-4ec1-87e5-98e5828aa3a9"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 171,
    Value = Guid.Parse("5027c49b-f54e-4e5c-87d6-aad4bb3b10a8"),
    ModelInner = null,
    NullableValue = Guid.Parse("d6146954-a5eb-41e0-849c-6d274b3e2b8a"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0mi(
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
INSERT INTO public.guiduuide0mi(
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
            queryMapTypes: [typeof(GuiduuidE0MI)],
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
INSERT INTO public.guiduuide0mi(
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
                methodParametrName: "guiduuide0mi_id", 
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("820c9c65-25e5-478d-ba2a-6bd9a177e9c8")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("da352ae5-3cc8-4498-bb6b-1a36c1c3320e")));
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                methodParametrName: "guiduuide0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("16d4362f-2118-4a83-98bc-03ab614cffc7")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("3d58d527-0d21-4da8-a99c-fcf0c7263f3b")));
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("b8d522e8-7e90-4c53-8b4c-ac01a390bcb9")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidE0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidE0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuide0mi_id
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
                parametrName: "guiduuide0mi_id", 
                methodParametrName: "guiduuide0mi_id", 
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

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuide0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidE0M.AssertModel(models[0],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidE0M.AssertModel(models[0],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidE0M.AssertModel(models[0],_testData[5], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[6], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[28],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidE0M.AssertModel(models[0],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 1, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 165, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 165, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidE0M.AssertModel(models[0],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidE0M.AssertModel(models[0],_testData[3], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[4], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[5], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[6], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[28],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[29],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[30],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 121, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidE0M.AssertModel(models[0],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidE0M.AssertModel(models[0],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                GuiduuidE0M.AssertModel(models[0],_testData[32], false);
                GuiduuidE0M.AssertModel(models[1],_testData[33], false);
                GuiduuidE0M.AssertModel(models[2],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(17));

                GuiduuidE0M.AssertModel(models[0],_testData[18], false);
                GuiduuidE0M.AssertModel(models[1],_testData[19], false);
                GuiduuidE0M.AssertModel(models[2],_testData[20], false);
                GuiduuidE0M.AssertModel(models[3],_testData[21], false);
                GuiduuidE0M.AssertModel(models[4],_testData[22], false);
                GuiduuidE0M.AssertModel(models[5],_testData[23], false);
                GuiduuidE0M.AssertModel(models[6],_testData[24], false);
                GuiduuidE0M.AssertModel(models[7],_testData[25], false);
                GuiduuidE0M.AssertModel(models[8],_testData[26], false);
                GuiduuidE0M.AssertModel(models[9],_testData[27], false);
                GuiduuidE0M.AssertModel(models[10],_testData[28], false);
                GuiduuidE0M.AssertModel(models[11],_testData[29], false);
                GuiduuidE0M.AssertModel(models[12],_testData[30], false);
                GuiduuidE0M.AssertModel(models[13],_testData[31], false);
                GuiduuidE0M.AssertModel(models[14],_testData[32], false);
                GuiduuidE0M.AssertModel(models[15],_testData[33], false);
                GuiduuidE0M.AssertModel(models[16],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd46d73c-3223-4a9d-9bb2-43c840a112c3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f3ad0fa4-ad97-4238-8c96-061ecf574341"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0a4f17a0-95eb-4791-b43e-cff9466a2a12"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dd192dad-9c8c-4fab-82c8-028ae65d319b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1c4a3d6d-3619-476f-ac37-6e9c1dbc4b8e"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2b052f9-8e2e-4b21-8f91-7c4ae6359bb5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("18490879-d96d-4fcc-82fc-ee7b77334efa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4f8f6b47-d87c-459f-930a-10ab6d7f60e8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1d863058-be08-4151-9b3f-5a92f09f2997"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3310bada-b4ad-453c-a000-8238c76f770a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("820c9c65-25e5-478d-ba2a-6bd9a177e9c8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a3d6f71a-8307-47b1-9eb0-c57d00c1914d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9c3051a-1473-46e9-a06f-13f9b83cfe9f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("45b45b4e-6065-4cf6-a108-d22186c3306d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da352ae5-3cc8-4498-bb6b-1a36c1c3320e"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e08d254-c0fd-41a4-9657-dda11c9343f8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9dd8417-0edc-4290-8615-7ad92fe9c60d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b3152c1-a551-422f-95bd-48257c9cac0c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26b1f3a6-d1f1-4383-84c1-f8059a2f7cae"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65f70a20-6b5b-43db-bc8e-f86c3a5c6346"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("16d4362f-2118-4a83-98bc-03ab614cffc7"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9dde471e-5ac2-4c58-a655-34b72a3c5fbb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d58d527-0d21-4da8-a99c-fcf0c7263f3b"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8b6d2a6-87ee-4174-a703-5477f2760e01"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21abe60e-d2fd-4d1f-bdb4-ec868ce77b90"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8d522e8-7e90-4c53-8b4c-ac01a390bcb9"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbe78a0b-c263-42a7-b285-2adae5f14457"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29525270-5356-48d5-9e93-e28508102282"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ea5a8b77-f5f0-4455-b3eb-db27011a5b2b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8da51f3-12c1-4a42-9312-084a44297e09"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24b1993b-6a55-4a10-97fa-a2c8c8b07a15"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f64895f-74bb-4498-ab53-509990f8438a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07ef5ffe-1dc6-47d0-a0f5-2d6fbb6bd05c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("39564989-1c3d-44af-b6ae-0a2313a1b90d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b129a48-dde2-49c4-9065-016ff6fe4cf2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5aa7108c-e36d-4a53-b075-58bc18a817c0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("328231fa-a2a3-4950-ba0f-4fc7d83695d9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6c118965-48ab-4619-bf5c-dc867626cf62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c869f5ce-7418-4d88-bb98-e1daece08012"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("886a92d5-ffc2-418f-a713-7c91deff386f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b73f261d-1e01-4a0b-9a19-8aa88f92cb80"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dd356fee-6a27-405b-b58f-bba32d21b948"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f9d9b7c3-14e7-44f7-be45-68bb889080f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("203bd4d8-8a53-4f84-bcd5-55bf237c5da6"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e4ceb1ab-57f2-475c-98a9-dd1d599ba60d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4e74f9b-6871-46bf-8d0d-63271d062e5b"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6dd798d-5831-485e-b5f9-a945a0296ffc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa99c754-54e9-4a72-84a1-82351380f29f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("201dc2fd-1c6c-4b62-85c6-dadbaac0a093"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("073ae439-511b-47f3-a4b6-3c7ba23bea57"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c68333f-502a-46e7-bedd-9c167d443bb8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2c8510d-90c4-41d0-92ad-7415cefd23ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9af57c61-2bb7-4edf-ac78-7062f51defb8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("725625bc-57d8-4565-9db2-19c7667f1cbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67f6123b-afe5-4720-9bdd-ccb364e91b6c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78694b61-f684-447d-a0ae-a3ca216b3392"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("532a8ee9-dc19-4b0c-b2ec-eadf95bf25f5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("06350614-364d-49b6-92d3-c48f5e0a9340"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da868bfa-5527-45ab-9bfa-b131556a6192"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("242076cc-e552-4be5-8b78-95cdfeb4ab23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cf582959-146b-4a9a-af59-2f4c0a456068"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0ab8f9cf-905d-4ae7-9142-73deeb5cb283"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84c9a661-f5af-434e-93e9-37ac3574ccce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f2737fc1-2b8a-4e29-9157-03f94937ddb2"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19bc1ab9-0614-46fb-9d33-a2f2fb5a190c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b36200f4-dca2-45f7-8b22-e9c211ddb531"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ee552018-ac28-4152-a9aa-0f8ec6597ef4"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9f41dfc-6e12-4faf-babd-b6a886871b9e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("38e36e22-b637-4d72-988e-c0aa67303fc0"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7db0d301-1d44-4d53-8d9c-01b14e0f7ce5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8359eba9-4ffb-4455-8bd0-db8e0620c226"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f739f41-34eb-45e6-a5c3-141a91c2a577"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("936a93f1-7518-49d9-8d11-b53f2a8cb46d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a3de160a-2f4d-4436-a8e0-52f6f7750ddc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fcfdbc22-e5cc-4ec1-87e5-98e5828aa3a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5027c49b-f54e-4e5c-87d6-aad4bb3b10a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d6146954-a5eb-41e0-849c-6d274b3e2b8a"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd46d73c-3223-4a9d-9bb2-43c840a112c3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f3ad0fa4-ad97-4238-8c96-061ecf574341"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0a4f17a0-95eb-4791-b43e-cff9466a2a12"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dd192dad-9c8c-4fab-82c8-028ae65d319b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1c4a3d6d-3619-476f-ac37-6e9c1dbc4b8e"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2b052f9-8e2e-4b21-8f91-7c4ae6359bb5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("18490879-d96d-4fcc-82fc-ee7b77334efa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4f8f6b47-d87c-459f-930a-10ab6d7f60e8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1d863058-be08-4151-9b3f-5a92f09f2997"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3310bada-b4ad-453c-a000-8238c76f770a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("820c9c65-25e5-478d-ba2a-6bd9a177e9c8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a3d6f71a-8307-47b1-9eb0-c57d00c1914d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e9c3051a-1473-46e9-a06f-13f9b83cfe9f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("45b45b4e-6065-4cf6-a108-d22186c3306d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da352ae5-3cc8-4498-bb6b-1a36c1c3320e"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e08d254-c0fd-41a4-9657-dda11c9343f8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9dd8417-0edc-4290-8615-7ad92fe9c60d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b3152c1-a551-422f-95bd-48257c9cac0c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("26b1f3a6-d1f1-4383-84c1-f8059a2f7cae"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("65f70a20-6b5b-43db-bc8e-f86c3a5c6346"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("16d4362f-2118-4a83-98bc-03ab614cffc7"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9dde471e-5ac2-4c58-a655-34b72a3c5fbb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d58d527-0d21-4da8-a99c-fcf0c7263f3b"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e8b6d2a6-87ee-4174-a703-5477f2760e01"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21abe60e-d2fd-4d1f-bdb4-ec868ce77b90"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8d522e8-7e90-4c53-8b4c-ac01a390bcb9"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbe78a0b-c263-42a7-b285-2adae5f14457"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29525270-5356-48d5-9e93-e28508102282"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ea5a8b77-f5f0-4455-b3eb-db27011a5b2b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f8da51f3-12c1-4a42-9312-084a44297e09"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24b1993b-6a55-4a10-97fa-a2c8c8b07a15"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f64895f-74bb-4498-ab53-509990f8438a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07ef5ffe-1dc6-47d0-a0f5-2d6fbb6bd05c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("39564989-1c3d-44af-b6ae-0a2313a1b90d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b129a48-dde2-49c4-9065-016ff6fe4cf2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5aa7108c-e36d-4a53-b075-58bc18a817c0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("328231fa-a2a3-4950-ba0f-4fc7d83695d9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6c118965-48ab-4619-bf5c-dc867626cf62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c869f5ce-7418-4d88-bb98-e1daece08012"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("886a92d5-ffc2-418f-a713-7c91deff386f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b73f261d-1e01-4a0b-9a19-8aa88f92cb80"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dd356fee-6a27-405b-b58f-bba32d21b948"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f9d9b7c3-14e7-44f7-be45-68bb889080f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("203bd4d8-8a53-4f84-bcd5-55bf237c5da6"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e4ceb1ab-57f2-475c-98a9-dd1d599ba60d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e4e74f9b-6871-46bf-8d0d-63271d062e5b"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6dd798d-5831-485e-b5f9-a945a0296ffc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("aa99c754-54e9-4a72-84a1-82351380f29f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("201dc2fd-1c6c-4b62-85c6-dadbaac0a093"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("073ae439-511b-47f3-a4b6-3c7ba23bea57"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c68333f-502a-46e7-bedd-9c167d443bb8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b2c8510d-90c4-41d0-92ad-7415cefd23ed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9af57c61-2bb7-4edf-ac78-7062f51defb8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("725625bc-57d8-4565-9db2-19c7667f1cbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67f6123b-afe5-4720-9bdd-ccb364e91b6c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78694b61-f684-447d-a0ae-a3ca216b3392"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("532a8ee9-dc19-4b0c-b2ec-eadf95bf25f5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("06350614-364d-49b6-92d3-c48f5e0a9340"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da868bfa-5527-45ab-9bfa-b131556a6192"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("242076cc-e552-4be5-8b78-95cdfeb4ab23"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cf582959-146b-4a9a-af59-2f4c0a456068"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0ab8f9cf-905d-4ae7-9142-73deeb5cb283"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("84c9a661-f5af-434e-93e9-37ac3574ccce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f2737fc1-2b8a-4e29-9157-03f94937ddb2"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19bc1ab9-0614-46fb-9d33-a2f2fb5a190c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b36200f4-dca2-45f7-8b22-e9c211ddb531"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ee552018-ac28-4152-a9aa-0f8ec6597ef4"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9f41dfc-6e12-4faf-babd-b6a886871b9e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("38e36e22-b637-4d72-988e-c0aa67303fc0"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7db0d301-1d44-4d53-8d9c-01b14e0f7ce5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8359eba9-4ffb-4455-8bd0-db8e0620c226"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f739f41-34eb-45e6-a5c3-141a91c2a577"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("936a93f1-7518-49d9-8d11-b53f2a8cb46d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a3de160a-2f4d-4436-a8e0-52f6f7750ddc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fcfdbc22-e5cc-4ec1-87e5-98e5828aa3a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5027c49b-f54e-4e5c-87d6-aad4bb3b10a8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d6146954-a5eb-41e0-849c-6d274b3e2b8a"))));

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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidE0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuide0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidE0M),
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
FROM public.binary_guiduuide0m m
LEFT JOIN public.binary_guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuide0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
                var models =  ((IGuidSingleTypeuuid)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
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
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
                var models = await ((IGuidSingleTypeuuid)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidSingleTypeuuid)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
                var models = await ((IGuidSingleTypeuuid)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidSingleTypeuuid)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI), typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                await ((IGuidSingleTypeuuid)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                ((IGuidSingleTypeuuid)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
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
                var models = await ((IGuidSingleTypeuuid)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidSingleTypeuuid)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

