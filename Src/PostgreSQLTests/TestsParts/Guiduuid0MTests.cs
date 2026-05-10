

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
    Id = 6,
    Value = Guid.Parse("f1f9a705-efab-4ac7-8380-dc683a1cbb77"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 10,
    Value = Guid.Parse("6a49f4b6-f7fa-4803-bda1-d1424741ac8b"),
    ModelInner = new Guiduuid0MI
{
    Id = 9,
    Value = Guid.Parse("8c32bfdf-7e9f-49fc-97fe-1b3f5f03c55d"),
    NullableValue = Guid.Parse("4ddc9fc6-6529-4314-ad25-dbb69e00f7da"),
},
    NullableValue = Guid.Parse("00b9536d-be2c-4e6b-9a9b-040567ad9b0f"),
},
            new Guiduuid0M
{
    Id = 17,
    Value = Guid.Parse("02543d7b-ba5f-4b44-b0b2-95f31206e08c"),
    ModelInner = null,
    NullableValue = Guid.Parse("9fed9c86-4a88-4249-b3ef-57fb622054ab"),
},
            new Guiduuid0M
{
    Id = 25,
    Value = Guid.Parse("0cbdcf59-e6f4-42f9-bc02-1b624989b097"),
    ModelInner = new Guiduuid0MI
{
    Id = 11,
    Value = Guid.Parse("a21eecb4-54ad-4521-a3bb-f34c01ab00e1"),
    NullableValue = Guid.Parse("70cdf40e-4845-428c-9825-4bfa1d35e8de"),
},
    NullableValue = Guid.Parse("19c1f2cf-481c-4c93-ae04-801faf9fa3ea"),
},
            new Guiduuid0M
{
    Id = 29,
    Value = Guid.Parse("f1a63449-34cc-4798-9385-80e41e0a0099"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 36,
    Value = Guid.Parse("2c83e4cf-7b18-43b4-adae-70804e5e6933"),
    ModelInner = new Guiduuid0MI
{
    Id = 20,
    Value = Guid.Parse("39385286-b7a3-49b9-a5b8-872c6d72dd14"),
    NullableValue = Guid.Parse("20da7c96-6cb5-470d-b152-781ceea291c1"),
},
    NullableValue = Guid.Parse("937f7af9-6690-4b3d-a4d0-4ed07b57dd05"),
},
            new Guiduuid0M
{
    Id = 41,
    Value = Guid.Parse("36130780-fd57-46aa-b202-273de8a744f2"),
    ModelInner = null,
    NullableValue = Guid.Parse("be6a9f61-d3a8-416c-980d-c93b27a11ae3"),
},
            new Guiduuid0M
{
    Id = 47,
    Value = Guid.Parse("ad5b77aa-dbf5-4883-b8d2-2f936fef1307"),
    ModelInner = new Guiduuid0MI
{
    Id = 24,
    Value = Guid.Parse("7db35307-8e30-46cc-b266-026ef1bb3b6b"),
    NullableValue = Guid.Parse("408485d1-f06e-470c-9c43-cf7b8c8100f2"),
},
    NullableValue = Guid.Parse("d12b06b3-cf6b-4e52-9cab-df13616d66a8"),
},
            new Guiduuid0M
{
    Id = 49,
    Value = Guid.Parse("2f96c5c6-239e-4288-a88f-6422f9f18f1f"),
    ModelInner = null,
    NullableValue = Guid.Parse("813fb37d-0c7d-4249-af49-febace4818fc"),
},
            new Guiduuid0M
{
    Id = 52,
    Value = Guid.Parse("8fab036a-f9a8-4ea3-82ee-ba030d889e6f"),
    ModelInner = new Guiduuid0MI
{
    Id = 30,
    Value = Guid.Parse("e04bb698-4075-4b2f-b259-fa80d9b52a9b"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 60,
    Value = Guid.Parse("e145ac81-92c6-402e-aa01-9b8b83bf95bb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 64,
    Value = Guid.Parse("fa6cdd4b-6d44-42a7-8e1b-4a6ef2832dd9"),
    ModelInner = new Guiduuid0MI
{
    Id = 35,
    Value = Guid.Parse("9e08b274-a261-469a-b83c-6d4172cc1fcf"),
    NullableValue = Guid.Parse("ea9213a1-ce0b-4896-87cd-f42b7f1c70e2"),
},
    NullableValue = Guid.Parse("0553301a-ed09-4a4f-9ade-d39551c87a86"),
},
            new Guiduuid0M
{
    Id = 67,
    Value = Guid.Parse("647783a4-9435-4377-b2d2-5c8cf2c4f5aa"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 71,
    Value = Guid.Parse("75075b8b-5cfa-4b72-8a5f-a58a116dc57d"),
    ModelInner = new Guiduuid0MI
{
    Id = 37,
    Value = Guid.Parse("742ac94b-183b-4bd4-9a9d-857dde840831"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 76,
    Value = Guid.Parse("a286502b-f3fc-4540-bc93-50d4d688595e"),
    ModelInner = null,
    NullableValue = Guid.Parse("5e08b3a2-56c6-4ffd-9959-89d43f09729c"),
},
            new Guiduuid0M
{
    Id = 82,
    Value = Guid.Parse("c6127ea6-280e-4ba4-84ea-d393f050fce6"),
    ModelInner = new Guiduuid0MI
{
    Id = 44,
    Value = Guid.Parse("0d14118d-e8f2-4cd0-a1fa-fa2cb4fbe0f9"),
    NullableValue = Guid.Parse("ed7145c8-495e-4c00-9ad4-9221c76c3fdf"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 87,
    Value = Guid.Parse("eb1e76ed-8274-4870-a852-6b34be236572"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 89,
    Value = Guid.Parse("f43758f1-3609-4c01-98b3-1a18343f9181"),
    ModelInner = new Guiduuid0MI
{
    Id = 48,
    Value = Guid.Parse("9146102e-d0e5-4f98-9434-b3e864b621bf"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("da517222-8813-41bf-801d-3659c0b136d0"),
},
            new Guiduuid0M
{
    Id = 90,
    Value = Guid.Parse("220b33a5-ea76-47ae-97a1-9e26d823d2e2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 98,
    Value = Guid.Parse("1064cfda-f2d8-41d0-9e92-c89e666ec5b5"),
    ModelInner = new Guiduuid0MI
{
    Id = 51,
    Value = Guid.Parse("1818cea4-90fe-4eb5-a59b-085c65d381d5"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 107,
    Value = Guid.Parse("ca93b4de-6424-4e92-b39d-77c6aa575738"),
    ModelInner = null,
    NullableValue = Guid.Parse("6a5ea5ae-dc6f-466e-bdb6-76588edf4a18"),
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("6b78f8e0-e495-43e8-9c24-9e522299f290"),
    ModelInner = new Guiduuid0MI
{
    Id = 54,
    Value = Guid.Parse("9d97e982-6a45-41a9-8f6a-07375d805144"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ab735bef-2d54-4c3f-862b-7a24743e4cc8"),
},
            new Guiduuid0M
{
    Id = 113,
    Value = Guid.Parse("41bf02f5-daba-4ff3-9920-c44dc45425c3"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 115,
    Value = Guid.Parse("e94ce901-db71-4555-9a55-d65a5467eb37"),
    ModelInner = new Guiduuid0MI
{
    Id = 59,
    Value = Guid.Parse("80678804-29da-45f6-b49d-faedcf15506c"),
    NullableValue = Guid.Parse("b49de7b8-079d-4afa-a3a3-0d1c66a30195"),
},
    NullableValue = Guid.Parse("9f456564-5a7c-4daf-ae18-c5e6d5e179f1"),
},
            new Guiduuid0M
{
    Id = 118,
    Value = Guid.Parse("cde8f84a-8555-446a-85d9-913e26338fbd"),
    ModelInner = null,
    NullableValue = Guid.Parse("d06c4b11-b3ac-4e9c-876b-7dbf5651f978"),
},
            new Guiduuid0M
{
    Id = 124,
    Value = Guid.Parse("9212b56a-3a07-4d5d-bba7-79b2d4b063d0"),
    ModelInner = new Guiduuid0MI
{
    Id = 65,
    Value = Guid.Parse("0d0ec8e8-2641-4463-9524-ffef2882e029"),
    NullableValue = Guid.Parse("7d1e91eb-3e69-4c19-9cd7-c2a83b06045b"),
},
    NullableValue = Guid.Parse("b39b45f8-8e39-4d2c-98c5-d7ba93fd50f9"),
},
            new Guiduuid0M
{
    Id = 133,
    Value = Guid.Parse("caaae524-830f-4513-b70b-75c0b945c9f7"),
    ModelInner = null,
    NullableValue = Guid.Parse("a636903e-cc21-41dd-9d2f-08dda97cc36f"),
},
            new Guiduuid0M
{
    Id = 138,
    Value = Guid.Parse("310586a3-3d06-455c-a74a-9b45414c7fa7"),
    ModelInner = new Guiduuid0MI
{
    Id = 67,
    Value = Guid.Parse("916efa81-6abd-42ce-a343-c4c3ad0b0882"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2745d720-72bf-4dc3-906b-debcd0f648fc"),
},
            new Guiduuid0M
{
    Id = 142,
    Value = Guid.Parse("289f3f33-f8f9-42c3-8287-813eeaa1f253"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 143,
    Value = Guid.Parse("770439a9-0541-41d2-93be-39f85c277553"),
    ModelInner = new Guiduuid0MI
{
    Id = 76,
    Value = Guid.Parse("a84bc722-b3f7-4f7e-b370-a36c9f763767"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 144,
    Value = Guid.Parse("b81fc3fb-f41d-4091-a751-e0896dfd874f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 148,
    Value = Guid.Parse("57417ded-efba-4747-9a1d-2a64db77c3a2"),
    ModelInner = new Guiduuid0MI
{
    Id = 83,
    Value = Guid.Parse("d196ab04-9d0f-4b5c-be69-3a7ce2e954f8"),
    NullableValue = Guid.Parse("942711e5-9806-486f-8a2a-7ad7c57b82ed"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 155,
    Value = Guid.Parse("353ca30f-eeb0-45b4-802f-65060900e0a9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 157,
    Value = Guid.Parse("c7752a9f-055e-48fa-8a62-91c12a7943e1"),
    ModelInner = new Guiduuid0MI
{
    Id = 86,
    Value = Guid.Parse("36b3fe6d-431b-419d-9a07-266f86939540"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 165,
    Value = Guid.Parse("7a0293af-70fc-4222-bb4f-0932b94c3db8"),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("937f7af9-6690-4b3d-a4d0-4ed07b57dd05")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("be6a9f61-d3a8-416c-980d-c93b27a11ae3")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("d12b06b3-cf6b-4e52-9cab-df13616d66a8")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("813fb37d-0c7d-4249-af49-febace4818fc")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("0553301a-ed09-4a4f-9ade-d39551c87a86")));
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guiduuid0M.AssertModel(models[0],_testData[12], false);
                        Guiduuid0M.AssertModel(models[1],_testData[13], false);
                        Guiduuid0M.AssertModel(models[2],_testData[14], false);
                        Guiduuid0M.AssertModel(models[3],_testData[15], false);
                        Guiduuid0M.AssertModel(models[4],_testData[16], false);
                        Guiduuid0M.AssertModel(models[5],_testData[17], false);
                        Guiduuid0M.AssertModel(models[6],_testData[18], false);
                        Guiduuid0M.AssertModel(models[7],_testData[19], false);
                        Guiduuid0M.AssertModel(models[8],_testData[20], false);
                        Guiduuid0M.AssertModel(models[9],_testData[21], false);
                        Guiduuid0M.AssertModel(models[10],_testData[22], false);
                        Guiduuid0M.AssertModel(models[11],_testData[23], false);
                        Guiduuid0M.AssertModel(models[12],_testData[24], false);
                        Guiduuid0M.AssertModel(models[13],_testData[25], false);
                        Guiduuid0M.AssertModel(models[14],_testData[26], false);
                        Guiduuid0M.AssertModel(models[15],_testData[27], false);
                        Guiduuid0M.AssertModel(models[16],_testData[28], false);
                        Guiduuid0M.AssertModel(models[17],_testData[29], false);
                        Guiduuid0M.AssertModel(models[18],_testData[30], false);
                        Guiduuid0M.AssertModel(models[19],_testData[31], false);
                        Guiduuid0M.AssertModel(models[20],_testData[32], false);
                        Guiduuid0M.AssertModel(models[21],_testData[33], false);
                        Guiduuid0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guiduuid0M.AssertModel(models[0],_testData[10], false);
                        Guiduuid0M.AssertModel(models[1],_testData[11], false);
                        Guiduuid0M.AssertModel(models[2],_testData[12], false);
                        Guiduuid0M.AssertModel(models[3],_testData[13], false);
                        Guiduuid0M.AssertModel(models[4],_testData[14], false);
                        Guiduuid0M.AssertModel(models[5],_testData[15], false);
                        Guiduuid0M.AssertModel(models[6],_testData[16], false);
                        Guiduuid0M.AssertModel(models[7],_testData[17], false);
                        Guiduuid0M.AssertModel(models[8],_testData[18], false);
                        Guiduuid0M.AssertModel(models[9],_testData[19], false);
                        Guiduuid0M.AssertModel(models[10],_testData[20], false);
                        Guiduuid0M.AssertModel(models[11],_testData[21], false);
                        Guiduuid0M.AssertModel(models[12],_testData[22], false);
                        Guiduuid0M.AssertModel(models[13],_testData[23], false);
                        Guiduuid0M.AssertModel(models[14],_testData[24], false);
                        Guiduuid0M.AssertModel(models[15],_testData[25], false);
                        Guiduuid0M.AssertModel(models[16],_testData[26], false);
                        Guiduuid0M.AssertModel(models[17],_testData[27], false);
                        Guiduuid0M.AssertModel(models[18],_testData[28], false);
                        Guiduuid0M.AssertModel(models[19],_testData[29], false);
                        Guiduuid0M.AssertModel(models[20],_testData[30], false);
                        Guiduuid0M.AssertModel(models[21],_testData[31], false);
                        Guiduuid0M.AssertModel(models[22],_testData[32], false);
                        Guiduuid0M.AssertModel(models[23],_testData[33], false);
                        Guiduuid0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guiduuid0M.AssertModel(models[0],_testData[33], false);
                        Guiduuid0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Guiduuid0M.AssertModel(models[0],_testData[7], false);
                        Guiduuid0M.AssertModel(models[1],_testData[8], false);
                        Guiduuid0M.AssertModel(models[2],_testData[9], false);
                        Guiduuid0M.AssertModel(models[3],_testData[10], false);
                        Guiduuid0M.AssertModel(models[4],_testData[11], false);
                        Guiduuid0M.AssertModel(models[5],_testData[12], false);
                        Guiduuid0M.AssertModel(models[6],_testData[13], false);
                        Guiduuid0M.AssertModel(models[7],_testData[14], false);
                        Guiduuid0M.AssertModel(models[8],_testData[15], false);
                        Guiduuid0M.AssertModel(models[9],_testData[16], false);
                        Guiduuid0M.AssertModel(models[10],_testData[17], false);
                        Guiduuid0M.AssertModel(models[11],_testData[18], false);
                        Guiduuid0M.AssertModel(models[12],_testData[19], false);
                        Guiduuid0M.AssertModel(models[13],_testData[20], false);
                        Guiduuid0M.AssertModel(models[14],_testData[21], false);
                        Guiduuid0M.AssertModel(models[15],_testData[22], false);
                        Guiduuid0M.AssertModel(models[16],_testData[23], false);
                        Guiduuid0M.AssertModel(models[17],_testData[24], false);
                        Guiduuid0M.AssertModel(models[18],_testData[25], false);
                        Guiduuid0M.AssertModel(models[19],_testData[26], false);
                        Guiduuid0M.AssertModel(models[20],_testData[27], false);
                        Guiduuid0M.AssertModel(models[21],_testData[28], false);
                        Guiduuid0M.AssertModel(models[22],_testData[29], false);
                        Guiduuid0M.AssertModel(models[23],_testData[30], false);
                        Guiduuid0M.AssertModel(models[24],_testData[31], false);
                        Guiduuid0M.AssertModel(models[25],_testData[32], false);
                        Guiduuid0M.AssertModel(models[26],_testData[33], false);
                        Guiduuid0M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 144, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 90, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[30],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Guiduuid0M.AssertModel(models[0],_testData[3], false);
                        Guiduuid0M.AssertModel(models[1],_testData[4], false);
                        Guiduuid0M.AssertModel(models[2],_testData[5], false);
                        Guiduuid0M.AssertModel(models[3],_testData[6], false);
                        Guiduuid0M.AssertModel(models[4],_testData[7], false);
                        Guiduuid0M.AssertModel(models[5],_testData[8], false);
                        Guiduuid0M.AssertModel(models[6],_testData[9], false);
                        Guiduuid0M.AssertModel(models[7],_testData[10], false);
                        Guiduuid0M.AssertModel(models[8],_testData[11], false);
                        Guiduuid0M.AssertModel(models[9],_testData[12], false);
                        Guiduuid0M.AssertModel(models[10],_testData[13], false);
                        Guiduuid0M.AssertModel(models[11],_testData[14], false);
                        Guiduuid0M.AssertModel(models[12],_testData[15], false);
                        Guiduuid0M.AssertModel(models[13],_testData[16], false);
                        Guiduuid0M.AssertModel(models[14],_testData[17], false);
                        Guiduuid0M.AssertModel(models[15],_testData[18], false);
                        Guiduuid0M.AssertModel(models[16],_testData[19], false);
                        Guiduuid0M.AssertModel(models[17],_testData[20], false);
                        Guiduuid0M.AssertModel(models[18],_testData[21], false);
                        Guiduuid0M.AssertModel(models[19],_testData[22], false);
                        Guiduuid0M.AssertModel(models[20],_testData[23], false);
                        Guiduuid0M.AssertModel(models[21],_testData[24], false);
                        Guiduuid0M.AssertModel(models[22],_testData[25], false);
                        Guiduuid0M.AssertModel(models[23],_testData[26], false);
                        Guiduuid0M.AssertModel(models[24],_testData[27], false);
                        Guiduuid0M.AssertModel(models[25],_testData[28], false);
                        Guiduuid0M.AssertModel(models[26],_testData[29], false);
                        Guiduuid0M.AssertModel(models[27],_testData[30], false);
                        Guiduuid0M.AssertModel(models[28],_testData[31], false);
                        Guiduuid0M.AssertModel(models[29],_testData[32], false);
                        Guiduuid0M.AssertModel(models[30],_testData[33], false);
                        Guiduuid0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        Guiduuid0M.AssertModel(models[13],_testData[30], false);
                        Guiduuid0M.AssertModel(models[14],_testData[31], false);
                        Guiduuid0M.AssertModel(models[15],_testData[32], false);
                        Guiduuid0M.AssertModel(models[16],_testData[33], false);
                        Guiduuid0M.AssertModel(models[17],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 133, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduuid0M.AssertModel(models[0],_testData[27], false);
                        Guiduuid0M.AssertModel(models[1],_testData[28], false);
                        Guiduuid0M.AssertModel(models[2],_testData[29], false);
                        Guiduuid0M.AssertModel(models[3],_testData[30], false);
                        Guiduuid0M.AssertModel(models[4],_testData[31], false);
                        Guiduuid0M.AssertModel(models[5],_testData[32], false);
                        Guiduuid0M.AssertModel(models[6],_testData[33], false);
                        Guiduuid0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduuid0M.AssertModel(models[0],_testData[27], false);
                        Guiduuid0M.AssertModel(models[1],_testData[28], false);
                        Guiduuid0M.AssertModel(models[2],_testData[29], false);
                        Guiduuid0M.AssertModel(models[3],_testData[30], false);
                        Guiduuid0M.AssertModel(models[4],_testData[31], false);
                        Guiduuid0M.AssertModel(models[5],_testData[32], false);
                        Guiduuid0M.AssertModel(models[6],_testData[33], false);
                        Guiduuid0M.AssertModel(models[7],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Guiduuid0M.AssertModel(models[0],_testData[27], false);
                Guiduuid0M.AssertModel(models[1],_testData[28], false);
                Guiduuid0M.AssertModel(models[2],_testData[29], false);
                Guiduuid0M.AssertModel(models[3],_testData[30], false);
                Guiduuid0M.AssertModel(models[4],_testData[31], false);
                Guiduuid0M.AssertModel(models[5],_testData[32], false);
                Guiduuid0M.AssertModel(models[6],_testData[33], false);
                Guiduuid0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

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
                Guiduuid0M.AssertModel(models[21],_testData[30], false);
                Guiduuid0M.AssertModel(models[22],_testData[31], false);
                Guiduuid0M.AssertModel(models[23],_testData[32], false);
                Guiduuid0M.AssertModel(models[24],_testData[33], false);
                Guiduuid0M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1f9a705-efab-4ac7-8380-dc683a1cbb77"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a49f4b6-f7fa-4803-bda1-d1424741ac8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c32bfdf-7e9f-49fc-97fe-1b3f5f03c55d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4ddc9fc6-6529-4314-ad25-dbb69e00f7da"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("00b9536d-be2c-4e6b-9a9b-040567ad9b0f"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02543d7b-ba5f-4b44-b0b2-95f31206e08c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9fed9c86-4a88-4249-b3ef-57fb622054ab"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0cbdcf59-e6f4-42f9-bc02-1b624989b097"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a21eecb4-54ad-4521-a3bb-f34c01ab00e1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("70cdf40e-4845-428c-9825-4bfa1d35e8de"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("19c1f2cf-481c-4c93-ae04-801faf9fa3ea"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1a63449-34cc-4798-9385-80e41e0a0099"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c83e4cf-7b18-43b4-adae-70804e5e6933"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("39385286-b7a3-49b9-a5b8-872c6d72dd14"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("20da7c96-6cb5-470d-b152-781ceea291c1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("937f7af9-6690-4b3d-a4d0-4ed07b57dd05"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("36130780-fd57-46aa-b202-273de8a744f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be6a9f61-d3a8-416c-980d-c93b27a11ae3"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad5b77aa-dbf5-4883-b8d2-2f936fef1307"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7db35307-8e30-46cc-b266-026ef1bb3b6b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("408485d1-f06e-470c-9c43-cf7b8c8100f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d12b06b3-cf6b-4e52-9cab-df13616d66a8"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f96c5c6-239e-4288-a88f-6422f9f18f1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("813fb37d-0c7d-4249-af49-febace4818fc"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fab036a-f9a8-4ea3-82ee-ba030d889e6f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e04bb698-4075-4b2f-b259-fa80d9b52a9b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e145ac81-92c6-402e-aa01-9b8b83bf95bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fa6cdd4b-6d44-42a7-8e1b-4a6ef2832dd9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e08b274-a261-469a-b83c-6d4172cc1fcf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ea9213a1-ce0b-4896-87cd-f42b7f1c70e2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0553301a-ed09-4a4f-9ade-d39551c87a86"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("647783a4-9435-4377-b2d2-5c8cf2c4f5aa"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("75075b8b-5cfa-4b72-8a5f-a58a116dc57d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("742ac94b-183b-4bd4-9a9d-857dde840831"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a286502b-f3fc-4540-bc93-50d4d688595e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e08b3a2-56c6-4ffd-9959-89d43f09729c"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6127ea6-280e-4ba4-84ea-d393f050fce6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d14118d-e8f2-4cd0-a1fa-fa2cb4fbe0f9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ed7145c8-495e-4c00-9ad4-9221c76c3fdf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb1e76ed-8274-4870-a852-6b34be236572"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f43758f1-3609-4c01-98b3-1a18343f9181"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9146102e-d0e5-4f98-9434-b3e864b621bf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da517222-8813-41bf-801d-3659c0b136d0"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("220b33a5-ea76-47ae-97a1-9e26d823d2e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1064cfda-f2d8-41d0-9e92-c89e666ec5b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1818cea4-90fe-4eb5-a59b-085c65d381d5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca93b4de-6424-4e92-b39d-77c6aa575738"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6a5ea5ae-dc6f-466e-bdb6-76588edf4a18"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b78f8e0-e495-43e8-9c24-9e522299f290"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9d97e982-6a45-41a9-8f6a-07375d805144"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab735bef-2d54-4c3f-862b-7a24743e4cc8"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41bf02f5-daba-4ff3-9920-c44dc45425c3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e94ce901-db71-4555-9a55-d65a5467eb37"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("80678804-29da-45f6-b49d-faedcf15506c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b49de7b8-079d-4afa-a3a3-0d1c66a30195"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f456564-5a7c-4daf-ae18-c5e6d5e179f1"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cde8f84a-8555-446a-85d9-913e26338fbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d06c4b11-b3ac-4e9c-876b-7dbf5651f978"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9212b56a-3a07-4d5d-bba7-79b2d4b063d0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d0ec8e8-2641-4463-9524-ffef2882e029"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d1e91eb-3e69-4c19-9cd7-c2a83b06045b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b39b45f8-8e39-4d2c-98c5-d7ba93fd50f9"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("caaae524-830f-4513-b70b-75c0b945c9f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a636903e-cc21-41dd-9d2f-08dda97cc36f"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("310586a3-3d06-455c-a74a-9b45414c7fa7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("916efa81-6abd-42ce-a343-c4c3ad0b0882"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2745d720-72bf-4dc3-906b-debcd0f648fc"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("289f3f33-f8f9-42c3-8287-813eeaa1f253"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("770439a9-0541-41d2-93be-39f85c277553"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a84bc722-b3f7-4f7e-b370-a36c9f763767"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b81fc3fb-f41d-4091-a751-e0896dfd874f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57417ded-efba-4747-9a1d-2a64db77c3a2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d196ab04-9d0f-4b5c-be69-3a7ce2e954f8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("942711e5-9806-486f-8a2a-7ad7c57b82ed"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("353ca30f-eeb0-45b4-802f-65060900e0a9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c7752a9f-055e-48fa-8a62-91c12a7943e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36b3fe6d-431b-419d-9a07-266f86939540"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a0293af-70fc-4222-bb4f-0932b94c3db8"))));//Value

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
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1f9a705-efab-4ac7-8380-dc683a1cbb77"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a49f4b6-f7fa-4803-bda1-d1424741ac8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c32bfdf-7e9f-49fc-97fe-1b3f5f03c55d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4ddc9fc6-6529-4314-ad25-dbb69e00f7da"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("00b9536d-be2c-4e6b-9a9b-040567ad9b0f"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02543d7b-ba5f-4b44-b0b2-95f31206e08c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9fed9c86-4a88-4249-b3ef-57fb622054ab"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0cbdcf59-e6f4-42f9-bc02-1b624989b097"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a21eecb4-54ad-4521-a3bb-f34c01ab00e1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("70cdf40e-4845-428c-9825-4bfa1d35e8de"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("19c1f2cf-481c-4c93-ae04-801faf9fa3ea"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f1a63449-34cc-4798-9385-80e41e0a0099"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c83e4cf-7b18-43b4-adae-70804e5e6933"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("39385286-b7a3-49b9-a5b8-872c6d72dd14"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("20da7c96-6cb5-470d-b152-781ceea291c1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("937f7af9-6690-4b3d-a4d0-4ed07b57dd05"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("36130780-fd57-46aa-b202-273de8a744f2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be6a9f61-d3a8-416c-980d-c93b27a11ae3"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad5b77aa-dbf5-4883-b8d2-2f936fef1307"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7db35307-8e30-46cc-b266-026ef1bb3b6b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("408485d1-f06e-470c-9c43-cf7b8c8100f2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d12b06b3-cf6b-4e52-9cab-df13616d66a8"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f96c5c6-239e-4288-a88f-6422f9f18f1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("813fb37d-0c7d-4249-af49-febace4818fc"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fab036a-f9a8-4ea3-82ee-ba030d889e6f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e04bb698-4075-4b2f-b259-fa80d9b52a9b"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e145ac81-92c6-402e-aa01-9b8b83bf95bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fa6cdd4b-6d44-42a7-8e1b-4a6ef2832dd9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e08b274-a261-469a-b83c-6d4172cc1fcf"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ea9213a1-ce0b-4896-87cd-f42b7f1c70e2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0553301a-ed09-4a4f-9ade-d39551c87a86"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("647783a4-9435-4377-b2d2-5c8cf2c4f5aa"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("75075b8b-5cfa-4b72-8a5f-a58a116dc57d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("742ac94b-183b-4bd4-9a9d-857dde840831"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a286502b-f3fc-4540-bc93-50d4d688595e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e08b3a2-56c6-4ffd-9959-89d43f09729c"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c6127ea6-280e-4ba4-84ea-d393f050fce6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d14118d-e8f2-4cd0-a1fa-fa2cb4fbe0f9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ed7145c8-495e-4c00-9ad4-9221c76c3fdf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb1e76ed-8274-4870-a852-6b34be236572"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f43758f1-3609-4c01-98b3-1a18343f9181"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9146102e-d0e5-4f98-9434-b3e864b621bf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("da517222-8813-41bf-801d-3659c0b136d0"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("220b33a5-ea76-47ae-97a1-9e26d823d2e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1064cfda-f2d8-41d0-9e92-c89e666ec5b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1818cea4-90fe-4eb5-a59b-085c65d381d5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca93b4de-6424-4e92-b39d-77c6aa575738"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6a5ea5ae-dc6f-466e-bdb6-76588edf4a18"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b78f8e0-e495-43e8-9c24-9e522299f290"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9d97e982-6a45-41a9-8f6a-07375d805144"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab735bef-2d54-4c3f-862b-7a24743e4cc8"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41bf02f5-daba-4ff3-9920-c44dc45425c3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e94ce901-db71-4555-9a55-d65a5467eb37"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("80678804-29da-45f6-b49d-faedcf15506c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b49de7b8-079d-4afa-a3a3-0d1c66a30195"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f456564-5a7c-4daf-ae18-c5e6d5e179f1"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cde8f84a-8555-446a-85d9-913e26338fbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d06c4b11-b3ac-4e9c-876b-7dbf5651f978"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9212b56a-3a07-4d5d-bba7-79b2d4b063d0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d0ec8e8-2641-4463-9524-ffef2882e029"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d1e91eb-3e69-4c19-9cd7-c2a83b06045b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b39b45f8-8e39-4d2c-98c5-d7ba93fd50f9"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("caaae524-830f-4513-b70b-75c0b945c9f7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a636903e-cc21-41dd-9d2f-08dda97cc36f"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("310586a3-3d06-455c-a74a-9b45414c7fa7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("916efa81-6abd-42ce-a343-c4c3ad0b0882"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2745d720-72bf-4dc3-906b-debcd0f648fc"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("289f3f33-f8f9-42c3-8287-813eeaa1f253"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("770439a9-0541-41d2-93be-39f85c277553"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a84bc722-b3f7-4f7e-b370-a36c9f763767"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b81fc3fb-f41d-4091-a751-e0896dfd874f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57417ded-efba-4747-9a1d-2a64db77c3a2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d196ab04-9d0f-4b5c-be69-3a7ce2e954f8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("942711e5-9806-486f-8a2a-7ad7c57b82ed"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("353ca30f-eeb0-45b4-802f-65060900e0a9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c7752a9f-055e-48fa-8a62-91c12a7943e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36b3fe6d-431b-419d-9a07-266f86939540"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a0293af-70fc-4222-bb4f-0932b94c3db8"))));//Value

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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
            queryMapType: typeof(Guiduuid0MIWA),
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
            queryMapType: typeof(Guiduuid0MIWA),
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
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
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MI>(2);
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
                    Guiduuid0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MI>(2);
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
                    Guiduuid0MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guiduuid0MIWA),
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
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
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0M>();
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
                    Guiduuid0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0M>();
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
                    Guiduuid0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
                    Guiduuid0M.AssertModel(model, expectedModel, true);
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
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA), typeof(Guiduuid0MIWA)],
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA), typeof(Guiduuid0MIWA)],
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuid0mi
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI), typeof(Guiduuid0MI)],
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
                var models1 = new List<Guiduuid0MI>();
                var models2 = new List<Guiduuid0MI>();
                await ((IGuidSingleTypeuuid)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guiduuid0MI>();
                var models2 = new List<Guiduuid0MI>();
                ((IGuidSingleTypeuuid)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
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
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
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
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuid0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA), typeof(Guiduuid0MIWA)],
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Guiduuid0MIWA>();
                var models2 = new List<Guiduuid0MIWA>();
                ((IGuidSingleTypeuuid)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
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
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

