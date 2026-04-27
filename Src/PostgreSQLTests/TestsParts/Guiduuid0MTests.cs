

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
    Id = 8,
    Value = Guid.Parse("4fe0b95b-1bfb-4a86-bdc8-35dd57387998"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 10,
    Value = Guid.Parse("f2639d10-7246-48f6-8c80-f9bc04b927c1"),
    ModelInner = new Guiduuid0MI
{
    Id = 9,
    Value = Guid.Parse("c166fb04-0df4-40ae-8076-f443948efbfe"),
    NullableValue = Guid.Parse("956f69e4-a756-4f77-8521-ccbaf6b6d455"),
},
    NullableValue = Guid.Parse("7b913f77-4ab1-4c1c-bd00-c4b1171822a9"),
},
            new Guiduuid0M
{
    Id = 16,
    Value = Guid.Parse("19a3ff63-4b2c-45d5-a01d-93f122809b21"),
    ModelInner = null,
    NullableValue = Guid.Parse("0848c0ad-e394-400b-b2d1-601dc1478fda"),
},
            new Guiduuid0M
{
    Id = 23,
    Value = Guid.Parse("ae518969-9ebd-4bf4-ad3e-912bbad53f4b"),
    ModelInner = new Guiduuid0MI
{
    Id = 18,
    Value = Guid.Parse("544dff34-fa92-41ca-986a-115b2efef0c0"),
    NullableValue = Guid.Parse("abb01a16-9cc5-47b1-8a53-e541d27fadeb"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 32,
    Value = Guid.Parse("437d6074-d52f-4349-9081-25ef1ee49ba3"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 37,
    Value = Guid.Parse("4da78925-413e-4fdc-a195-d9684b8ff1dc"),
    ModelInner = new Guiduuid0MI
{
    Id = 21,
    Value = Guid.Parse("04ad3019-b294-4018-a24c-e8e49365fba7"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a4653756-40a3-462c-8556-7a9f37c62139"),
},
            new Guiduuid0M
{
    Id = 39,
    Value = Guid.Parse("30fab261-41a2-4e97-bb95-31b6c5781c55"),
    ModelInner = null,
    NullableValue = Guid.Parse("fd24bada-1b98-4f22-ba4a-9ccb04c7854c"),
},
            new Guiduuid0M
{
    Id = 45,
    Value = Guid.Parse("d172fb3c-1cbe-4517-8b64-eb3561e3d0f6"),
    ModelInner = new Guiduuid0MI
{
    Id = 27,
    Value = Guid.Parse("2e416e2b-90a2-4cd6-9baa-bd1e5ec2d3ed"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 46,
    Value = Guid.Parse("f509850f-895b-4548-88ad-2f694065925f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 51,
    Value = Guid.Parse("3bac211d-85b3-4fae-b6fd-6fceb3d0f0b4"),
    ModelInner = new Guiduuid0MI
{
    Id = 32,
    Value = Guid.Parse("5fabb763-2407-4c6f-9596-35c4eebcb760"),
    NullableValue = Guid.Parse("ea106aba-2527-4c27-8c06-bc7b8e625f62"),
},
    NullableValue = Guid.Parse("ab09b13f-18ae-4470-b502-a269d934d45a"),
},
            new Guiduuid0M
{
    Id = 55,
    Value = Guid.Parse("a5d63317-508f-4556-917b-0817e0b99b54"),
    ModelInner = null,
    NullableValue = Guid.Parse("7abf2569-cc2d-43fc-97e2-e60eff631f9e"),
},
            new Guiduuid0M
{
    Id = 63,
    Value = Guid.Parse("474d84ab-68ee-4c8a-9229-fe5f9275ea6e"),
    ModelInner = new Guiduuid0MI
{
    Id = 37,
    Value = Guid.Parse("c8728202-d689-442e-bb98-b62cee32adaf"),
    NullableValue = Guid.Parse("6043a0e3-1237-4ce4-9267-a0799097e5a9"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 72,
    Value = Guid.Parse("f50bcb1e-01d4-48ed-af70-7739acd54f35"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 81,
    Value = Guid.Parse("96663d2a-b881-4743-9d28-edf2a30ea0cb"),
    ModelInner = new Guiduuid0MI
{
    Id = 45,
    Value = Guid.Parse("8578cfae-9b86-4bd7-93d9-c2cf8f7215f5"),
    NullableValue = Guid.Parse("39142cb9-d86a-4601-8dcf-45ab34e8f910"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 85,
    Value = Guid.Parse("b7ddecf1-165a-4a4d-b440-df53f5395ac9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 92,
    Value = Guid.Parse("4da157dc-534e-4870-8827-5f7180d87da7"),
    ModelInner = new Guiduuid0MI
{
    Id = 50,
    Value = Guid.Parse("4b6f02d7-b33f-482d-8b70-d195bfd8ebf7"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("8255a414-2a22-46ab-b5b1-4d73f0b56953"),
},
            new Guiduuid0M
{
    Id = 93,
    Value = Guid.Parse("b06838d3-e1e2-42bb-a46f-a3d45af98e67"),
    ModelInner = null,
    NullableValue = Guid.Parse("204c01dc-ac21-4ba7-8bfe-c0e553db6278"),
},
            new Guiduuid0M
{
    Id = 95,
    Value = Guid.Parse("b33e4b4c-44c5-4d76-bdcf-ce572ce3d303"),
    ModelInner = new Guiduuid0MI
{
    Id = 53,
    Value = Guid.Parse("b157aeb0-f71f-4bb0-ab7d-e01d24271ac5"),
    NullableValue = Guid.Parse("b9a63ba9-337d-4c02-b2b8-86566de1276f"),
},
    NullableValue = Guid.Parse("040b09c1-fc3d-4ac7-be34-5d3d0bd154db"),
},
            new Guiduuid0M
{
    Id = 104,
    Value = Guid.Parse("3e219140-b6e9-4d4c-bf4e-b166d81e8fd8"),
    ModelInner = null,
    NullableValue = Guid.Parse("435b8b18-b821-4f2b-9e1b-151888fd4fae"),
},
            new Guiduuid0M
{
    Id = 105,
    Value = Guid.Parse("b9113d9b-9c4d-404c-a19a-38fba93bcf0a"),
    ModelInner = new Guiduuid0MI
{
    Id = 60,
    Value = Guid.Parse("908cf4f8-e765-404a-893f-8c7d0e0daab9"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 113,
    Value = Guid.Parse("bf240804-14b5-4683-a996-fa601708e73e"),
    ModelInner = null,
    NullableValue = Guid.Parse("9df02096-8e2c-45fc-a1a7-17561238b42c"),
},
            new Guiduuid0M
{
    Id = 118,
    Value = Guid.Parse("9e56d0ff-5976-4127-9cb0-dcdd73d3310c"),
    ModelInner = new Guiduuid0MI
{
    Id = 68,
    Value = Guid.Parse("dcb24a44-1d80-4e04-97e3-92955f576496"),
    NullableValue = Guid.Parse("ddd1aaf9-0554-4229-af41-94d63573ce41"),
},
    NullableValue = Guid.Parse("cbf0ccf2-3e00-46cf-822e-9f05aaace220"),
},
            new Guiduuid0M
{
    Id = 122,
    Value = Guid.Parse("e6a20f89-6dbd-4b3e-b636-16f2ff34e0ba"),
    ModelInner = null,
    NullableValue = Guid.Parse("ab04d0f7-ffaf-42dc-b7c3-c5cf44b339f6"),
},
            new Guiduuid0M
{
    Id = 125,
    Value = Guid.Parse("55c81377-d387-4922-aa4d-67a2620f034a"),
    ModelInner = new Guiduuid0MI
{
    Id = 71,
    Value = Guid.Parse("fe6487f8-bafa-49c9-9f20-22903f9329f0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 133,
    Value = Guid.Parse("8be8a188-3e03-4185-b07f-4b4c4e1dd085"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 138,
    Value = Guid.Parse("bfd27c00-a13e-4d33-810a-892e007c8589"),
    ModelInner = new Guiduuid0MI
{
    Id = 80,
    Value = Guid.Parse("a31f7f68-010d-4fa9-925e-74c614096be2"),
    NullableValue = Guid.Parse("9ad6df63-bc5c-4207-8162-c8eb3ee1e99b"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 146,
    Value = Guid.Parse("93d0837b-6bea-42b0-954f-9911e82986ff"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 149,
    Value = Guid.Parse("b7bbc6ba-fed1-4c8d-9e95-42e8a4e9eb43"),
    ModelInner = new Guiduuid0MI
{
    Id = 84,
    Value = Guid.Parse("4aa6a68a-c602-4d0c-8848-6688dcac6f09"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b82d97e3-26fe-4017-98f9-8ff1dc05a0cc"),
},
            new Guiduuid0M
{
    Id = 157,
    Value = Guid.Parse("ce287f15-9c66-46cf-a3ee-e980d52e8002"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 166,
    Value = Guid.Parse("fb70ae2c-466d-471e-998b-e35bcfe68555"),
    ModelInner = new Guiduuid0MI
{
    Id = 86,
    Value = Guid.Parse("a1bc17d9-ae72-429c-9569-657e3f47aa0c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2b20cfe0-0f22-430d-a833-bc1781ac53fd"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("a4653756-40a3-462c-8556-7a9f37c62139")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("fd24bada-1b98-4f22-ba4a-9ccb04c7854c")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("ab09b13f-18ae-4470-b502-a269d934d45a")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("7abf2569-cc2d-43fc-97e2-e60eff631f9e")));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduuid0M.AssertModel(models[0],_testData[24], false);
                        Guiduuid0M.AssertModel(models[1],_testData[25], false);
                        Guiduuid0M.AssertModel(models[2],_testData[26], false);
                        Guiduuid0M.AssertModel(models[3],_testData[27], false);
                        Guiduuid0M.AssertModel(models[4],_testData[28], false);
                        Guiduuid0M.AssertModel(models[5],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduuid0M.AssertModel(models[0],_testData[13], false);
                        Guiduuid0M.AssertModel(models[1],_testData[14], false);
                        Guiduuid0M.AssertModel(models[2],_testData[15], false);
                        Guiduuid0M.AssertModel(models[3],_testData[16], false);
                        Guiduuid0M.AssertModel(models[4],_testData[17], false);
                        Guiduuid0M.AssertModel(models[5],_testData[18], false);
                        Guiduuid0M.AssertModel(models[6],_testData[19], false);
                        Guiduuid0M.AssertModel(models[7],_testData[20], false);
                        Guiduuid0M.AssertModel(models[8],_testData[21], false);
                        Guiduuid0M.AssertModel(models[9],_testData[22], false);
                        Guiduuid0M.AssertModel(models[10],_testData[23], false);
                        Guiduuid0M.AssertModel(models[11],_testData[24], false);
                        Guiduuid0M.AssertModel(models[12],_testData[25], false);
                        Guiduuid0M.AssertModel(models[13],_testData[26], false);
                        Guiduuid0M.AssertModel(models[14],_testData[27], false);
                        Guiduuid0M.AssertModel(models[15],_testData[28], false);
                        Guiduuid0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduuid0M.AssertModel(models[0],_testData[27], false);
                        Guiduuid0M.AssertModel(models[1],_testData[28], false);
                        Guiduuid0M.AssertModel(models[2],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 149, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[29], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[29], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 95, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 81, query2))
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guiduuid0M.AssertModel(models[0],_testData[14], false);
                        Guiduuid0M.AssertModel(models[1],_testData[15], false);
                        Guiduuid0M.AssertModel(models[2],_testData[16], false);
                        Guiduuid0M.AssertModel(models[3],_testData[17], false);
                        Guiduuid0M.AssertModel(models[4],_testData[18], false);
                        Guiduuid0M.AssertModel(models[5],_testData[19], false);
                        Guiduuid0M.AssertModel(models[6],_testData[20], false);
                        Guiduuid0M.AssertModel(models[7],_testData[21], false);
                        Guiduuid0M.AssertModel(models[8],_testData[22], false);
                        Guiduuid0M.AssertModel(models[9],_testData[23], false);
                        Guiduuid0M.AssertModel(models[10],_testData[24], false);
                        Guiduuid0M.AssertModel(models[11],_testData[25], false);
                        Guiduuid0M.AssertModel(models[12],_testData[26], false);
                        Guiduuid0M.AssertModel(models[13],_testData[27], false);
                        Guiduuid0M.AssertModel(models[14],_testData[28], false);
                        Guiduuid0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guiduuid0M.AssertModel(models[0],_testData[9], false);
                        Guiduuid0M.AssertModel(models[1],_testData[10], false);
                        Guiduuid0M.AssertModel(models[2],_testData[11], false);
                        Guiduuid0M.AssertModel(models[3],_testData[12], false);
                        Guiduuid0M.AssertModel(models[4],_testData[13], false);
                        Guiduuid0M.AssertModel(models[5],_testData[14], false);
                        Guiduuid0M.AssertModel(models[6],_testData[15], false);
                        Guiduuid0M.AssertModel(models[7],_testData[16], false);
                        Guiduuid0M.AssertModel(models[8],_testData[17], false);
                        Guiduuid0M.AssertModel(models[9],_testData[18], false);
                        Guiduuid0M.AssertModel(models[10],_testData[19], false);
                        Guiduuid0M.AssertModel(models[11],_testData[20], false);
                        Guiduuid0M.AssertModel(models[12],_testData[21], false);
                        Guiduuid0M.AssertModel(models[13],_testData[22], false);
                        Guiduuid0M.AssertModel(models[14],_testData[23], false);
                        Guiduuid0M.AssertModel(models[15],_testData[24], false);
                        Guiduuid0M.AssertModel(models[16],_testData[25], false);
                        Guiduuid0M.AssertModel(models[17],_testData[26], false);
                        Guiduuid0M.AssertModel(models[18],_testData[27], false);
                        Guiduuid0M.AssertModel(models[19],_testData[28], false);
                        Guiduuid0M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 93, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Guiduuid0M.AssertModel(models[0],_testData[17], false);
                        Guiduuid0M.AssertModel(models[1],_testData[18], false);
                        Guiduuid0M.AssertModel(models[2],_testData[19], false);
                        Guiduuid0M.AssertModel(models[3],_testData[20], false);
                        Guiduuid0M.AssertModel(models[4],_testData[21], false);
                        Guiduuid0M.AssertModel(models[5],_testData[22], false);
                        Guiduuid0M.AssertModel(models[6],_testData[23], false);
                        Guiduuid0M.AssertModel(models[7],_testData[24], false);
                        Guiduuid0M.AssertModel(models[8],_testData[25], false);
                        Guiduuid0M.AssertModel(models[9],_testData[26], false);
                        Guiduuid0M.AssertModel(models[10],_testData[27], false);
                        Guiduuid0M.AssertModel(models[11],_testData[28], false);
                        Guiduuid0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guiduuid0M.AssertModel(models[0],_testData[9], false);
                        Guiduuid0M.AssertModel(models[1],_testData[10], false);
                        Guiduuid0M.AssertModel(models[2],_testData[11], false);
                        Guiduuid0M.AssertModel(models[3],_testData[12], false);
                        Guiduuid0M.AssertModel(models[4],_testData[13], false);
                        Guiduuid0M.AssertModel(models[5],_testData[14], false);
                        Guiduuid0M.AssertModel(models[6],_testData[15], false);
                        Guiduuid0M.AssertModel(models[7],_testData[16], false);
                        Guiduuid0M.AssertModel(models[8],_testData[17], false);
                        Guiduuid0M.AssertModel(models[9],_testData[18], false);
                        Guiduuid0M.AssertModel(models[10],_testData[19], false);
                        Guiduuid0M.AssertModel(models[11],_testData[20], false);
                        Guiduuid0M.AssertModel(models[12],_testData[21], false);
                        Guiduuid0M.AssertModel(models[13],_testData[22], false);
                        Guiduuid0M.AssertModel(models[14],_testData[23], false);
                        Guiduuid0M.AssertModel(models[15],_testData[24], false);
                        Guiduuid0M.AssertModel(models[16],_testData[25], false);
                        Guiduuid0M.AssertModel(models[17],_testData[26], false);
                        Guiduuid0M.AssertModel(models[18],_testData[27], false);
                        Guiduuid0M.AssertModel(models[19],_testData[28], false);
                        Guiduuid0M.AssertModel(models[20],_testData[29], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Guiduuid0M.AssertModel(models[0],_testData[22], false);Guiduuid0M.AssertModel(models[1],_testData[23], false);Guiduuid0M.AssertModel(models[2],_testData[24], false);Guiduuid0M.AssertModel(models[3],_testData[25], false);Guiduuid0M.AssertModel(models[4],_testData[26], false);Guiduuid0M.AssertModel(models[5],_testData[27], false);Guiduuid0M.AssertModel(models[6],_testData[28], false);Guiduuid0M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Guiduuid0M.AssertModel(models[0],_testData[15], false);Guiduuid0M.AssertModel(models[1],_testData[16], false);Guiduuid0M.AssertModel(models[2],_testData[17], false);Guiduuid0M.AssertModel(models[3],_testData[18], false);Guiduuid0M.AssertModel(models[4],_testData[19], false);Guiduuid0M.AssertModel(models[5],_testData[20], false);Guiduuid0M.AssertModel(models[6],_testData[21], false);Guiduuid0M.AssertModel(models[7],_testData[22], false);Guiduuid0M.AssertModel(models[8],_testData[23], false);Guiduuid0M.AssertModel(models[9],_testData[24], false);Guiduuid0M.AssertModel(models[10],_testData[25], false);Guiduuid0M.AssertModel(models[11],_testData[26], false);Guiduuid0M.AssertModel(models[12],_testData[27], false);Guiduuid0M.AssertModel(models[13],_testData[28], false);Guiduuid0M.AssertModel(models[14],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fe0b95b-1bfb-4a86-bdc8-35dd57387998"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2639d10-7246-48f6-8c80-f9bc04b927c1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c166fb04-0df4-40ae-8076-f443948efbfe"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("956f69e4-a756-4f77-8521-ccbaf6b6d455"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7b913f77-4ab1-4c1c-bd00-c4b1171822a9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19a3ff63-4b2c-45d5-a01d-93f122809b21"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0848c0ad-e394-400b-b2d1-601dc1478fda"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae518969-9ebd-4bf4-ad3e-912bbad53f4b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("544dff34-fa92-41ca-986a-115b2efef0c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("abb01a16-9cc5-47b1-8a53-e541d27fadeb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("437d6074-d52f-4349-9081-25ef1ee49ba3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4da78925-413e-4fdc-a195-d9684b8ff1dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04ad3019-b294-4018-a24c-e8e49365fba7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a4653756-40a3-462c-8556-7a9f37c62139"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("30fab261-41a2-4e97-bb95-31b6c5781c55"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd24bada-1b98-4f22-ba4a-9ccb04c7854c"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d172fb3c-1cbe-4517-8b64-eb3561e3d0f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e416e2b-90a2-4cd6-9baa-bd1e5ec2d3ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f509850f-895b-4548-88ad-2f694065925f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bac211d-85b3-4fae-b6fd-6fceb3d0f0b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5fabb763-2407-4c6f-9596-35c4eebcb760"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ea106aba-2527-4c27-8c06-bc7b8e625f62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab09b13f-18ae-4470-b502-a269d934d45a"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5d63317-508f-4556-917b-0817e0b99b54"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7abf2569-cc2d-43fc-97e2-e60eff631f9e"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("474d84ab-68ee-4c8a-9229-fe5f9275ea6e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c8728202-d689-442e-bb98-b62cee32adaf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6043a0e3-1237-4ce4-9267-a0799097e5a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f50bcb1e-01d4-48ed-af70-7739acd54f35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("96663d2a-b881-4743-9d28-edf2a30ea0cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8578cfae-9b86-4bd7-93d9-c2cf8f7215f5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("39142cb9-d86a-4601-8dcf-45ab34e8f910"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7ddecf1-165a-4a4d-b440-df53f5395ac9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4da157dc-534e-4870-8827-5f7180d87da7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b6f02d7-b33f-482d-8b70-d195bfd8ebf7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8255a414-2a22-46ab-b5b1-4d73f0b56953"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b06838d3-e1e2-42bb-a46f-a3d45af98e67"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("204c01dc-ac21-4ba7-8bfe-c0e553db6278"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b33e4b4c-44c5-4d76-bdcf-ce572ce3d303"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b157aeb0-f71f-4bb0-ab7d-e01d24271ac5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b9a63ba9-337d-4c02-b2b8-86566de1276f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("040b09c1-fc3d-4ac7-be34-5d3d0bd154db"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3e219140-b6e9-4d4c-bf4e-b166d81e8fd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("435b8b18-b821-4f2b-9e1b-151888fd4fae"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9113d9b-9c4d-404c-a19a-38fba93bcf0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("908cf4f8-e765-404a-893f-8c7d0e0daab9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bf240804-14b5-4683-a996-fa601708e73e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9df02096-8e2c-45fc-a1a7-17561238b42c"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e56d0ff-5976-4127-9cb0-dcdd73d3310c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dcb24a44-1d80-4e04-97e3-92955f576496"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ddd1aaf9-0554-4229-af41-94d63573ce41"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbf0ccf2-3e00-46cf-822e-9f05aaace220"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6a20f89-6dbd-4b3e-b636-16f2ff34e0ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab04d0f7-ffaf-42dc-b7c3-c5cf44b339f6"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55c81377-d387-4922-aa4d-67a2620f034a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe6487f8-bafa-49c9-9f20-22903f9329f0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8be8a188-3e03-4185-b07f-4b4c4e1dd085"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bfd27c00-a13e-4d33-810a-892e007c8589"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a31f7f68-010d-4fa9-925e-74c614096be2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9ad6df63-bc5c-4207-8162-c8eb3ee1e99b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93d0837b-6bea-42b0-954f-9911e82986ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7bbc6ba-fed1-4c8d-9e95-42e8a4e9eb43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4aa6a68a-c602-4d0c-8848-6688dcac6f09"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b82d97e3-26fe-4017-98f9-8ff1dc05a0cc"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce287f15-9c66-46cf-a3ee-e980d52e8002"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb70ae2c-466d-471e-998b-e35bcfe68555"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1bc17d9-ae72-429c-9569-657e3f47aa0c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b20cfe0-0f22-430d-a833-bc1781ac53fd"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4fe0b95b-1bfb-4a86-bdc8-35dd57387998"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2639d10-7246-48f6-8c80-f9bc04b927c1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c166fb04-0df4-40ae-8076-f443948efbfe"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("956f69e4-a756-4f77-8521-ccbaf6b6d455"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7b913f77-4ab1-4c1c-bd00-c4b1171822a9"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19a3ff63-4b2c-45d5-a01d-93f122809b21"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0848c0ad-e394-400b-b2d1-601dc1478fda"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae518969-9ebd-4bf4-ad3e-912bbad53f4b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("544dff34-fa92-41ca-986a-115b2efef0c0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("abb01a16-9cc5-47b1-8a53-e541d27fadeb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("437d6074-d52f-4349-9081-25ef1ee49ba3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4da78925-413e-4fdc-a195-d9684b8ff1dc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04ad3019-b294-4018-a24c-e8e49365fba7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a4653756-40a3-462c-8556-7a9f37c62139"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("30fab261-41a2-4e97-bb95-31b6c5781c55"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd24bada-1b98-4f22-ba4a-9ccb04c7854c"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d172fb3c-1cbe-4517-8b64-eb3561e3d0f6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e416e2b-90a2-4cd6-9baa-bd1e5ec2d3ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f509850f-895b-4548-88ad-2f694065925f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bac211d-85b3-4fae-b6fd-6fceb3d0f0b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5fabb763-2407-4c6f-9596-35c4eebcb760"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ea106aba-2527-4c27-8c06-bc7b8e625f62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab09b13f-18ae-4470-b502-a269d934d45a"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a5d63317-508f-4556-917b-0817e0b99b54"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7abf2569-cc2d-43fc-97e2-e60eff631f9e"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("474d84ab-68ee-4c8a-9229-fe5f9275ea6e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c8728202-d689-442e-bb98-b62cee32adaf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6043a0e3-1237-4ce4-9267-a0799097e5a9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f50bcb1e-01d4-48ed-af70-7739acd54f35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("96663d2a-b881-4743-9d28-edf2a30ea0cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8578cfae-9b86-4bd7-93d9-c2cf8f7215f5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("39142cb9-d86a-4601-8dcf-45ab34e8f910"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7ddecf1-165a-4a4d-b440-df53f5395ac9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4da157dc-534e-4870-8827-5f7180d87da7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b6f02d7-b33f-482d-8b70-d195bfd8ebf7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8255a414-2a22-46ab-b5b1-4d73f0b56953"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b06838d3-e1e2-42bb-a46f-a3d45af98e67"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("204c01dc-ac21-4ba7-8bfe-c0e553db6278"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b33e4b4c-44c5-4d76-bdcf-ce572ce3d303"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b157aeb0-f71f-4bb0-ab7d-e01d24271ac5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b9a63ba9-337d-4c02-b2b8-86566de1276f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("040b09c1-fc3d-4ac7-be34-5d3d0bd154db"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3e219140-b6e9-4d4c-bf4e-b166d81e8fd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("435b8b18-b821-4f2b-9e1b-151888fd4fae"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9113d9b-9c4d-404c-a19a-38fba93bcf0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("908cf4f8-e765-404a-893f-8c7d0e0daab9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bf240804-14b5-4683-a996-fa601708e73e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9df02096-8e2c-45fc-a1a7-17561238b42c"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e56d0ff-5976-4127-9cb0-dcdd73d3310c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dcb24a44-1d80-4e04-97e3-92955f576496"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ddd1aaf9-0554-4229-af41-94d63573ce41"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbf0ccf2-3e00-46cf-822e-9f05aaace220"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e6a20f89-6dbd-4b3e-b636-16f2ff34e0ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab04d0f7-ffaf-42dc-b7c3-c5cf44b339f6"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55c81377-d387-4922-aa4d-67a2620f034a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fe6487f8-bafa-49c9-9f20-22903f9329f0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8be8a188-3e03-4185-b07f-4b4c4e1dd085"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bfd27c00-a13e-4d33-810a-892e007c8589"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a31f7f68-010d-4fa9-925e-74c614096be2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9ad6df63-bc5c-4207-8162-c8eb3ee1e99b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93d0837b-6bea-42b0-954f-9911e82986ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b7bbc6ba-fed1-4c8d-9e95-42e8a4e9eb43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4aa6a68a-c602-4d0c-8848-6688dcac6f09"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b82d97e3-26fe-4017-98f9-8ff1dc05a0cc"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ce287f15-9c66-46cf-a3ee-e980d52e8002"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb70ae2c-466d-471e-998b-e35bcfe68555"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1bc17d9-ae72-429c-9569-657e3f47aa0c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2b20cfe0-0f22-430d-a833-bc1781ac53fd"))));

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
            queryMapType: typeof(Guiduuid0MI),
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
            queryMapType: typeof(Guiduuid0M),
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

