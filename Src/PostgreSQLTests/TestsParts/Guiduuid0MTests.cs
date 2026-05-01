

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
    Id = 5,
    Value = Guid.Parse("d6dbc941-c830-4011-8bab-dc8b1502e256"),
    ModelInner = null,
    NullableValue = Guid.Parse("f883f919-1b4e-48ff-b419-25b25cb49197"),
},
            new Guiduuid0M
{
    Id = 7,
    Value = Guid.Parse("7a04d5d3-4522-4b8c-99b2-f7a6b537d8ee"),
    ModelInner = new Guiduuid0MI
{
    Id = 4,
    Value = Guid.Parse("0876730e-3f7a-4632-b9b7-0ab4621a3187"),
    NullableValue = Guid.Parse("3ca845d5-f52f-4a03-bd9e-3c86c52812c8"),
},
    NullableValue = Guid.Parse("ea377256-b5bc-459d-8765-f0c46cfe6ae2"),
},
            new Guiduuid0M
{
    Id = 8,
    Value = Guid.Parse("5ea5eb63-3fea-403e-a47f-be8c95ba1a16"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 15,
    Value = Guid.Parse("c4f019f0-0571-4273-8047-9b2e4fde9bca"),
    ModelInner = new Guiduuid0MI
{
    Id = 13,
    Value = Guid.Parse("0785fb5d-4a1a-4b8f-9e4c-14791188e539"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("685a9859-4e23-4986-9a8e-7b0d49f5f14b"),
},
            new Guiduuid0M
{
    Id = 20,
    Value = Guid.Parse("6a7db83f-790e-4f51-bacf-0e724afdaaa9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 23,
    Value = Guid.Parse("b9e26eb8-9cb9-4065-827b-caeab2a996a2"),
    ModelInner = new Guiduuid0MI
{
    Id = 19,
    Value = Guid.Parse("9ea52ffd-3018-4a79-a54b-292f6e5d723f"),
    NullableValue = Guid.Parse("5ef21f57-e8cd-49cf-adff-ea01208014f3"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 31,
    Value = Guid.Parse("48e3f9fe-5c66-45a9-b78d-22079b7d7146"),
    ModelInner = null,
    NullableValue = Guid.Parse("f9cc2133-d99d-4eb8-845c-849004f6001e"),
},
            new Guiduuid0M
{
    Id = 32,
    Value = Guid.Parse("fb42bd5d-709b-4f52-b901-7e6fc233c27a"),
    ModelInner = new Guiduuid0MI
{
    Id = 22,
    Value = Guid.Parse("9e979d26-9a8d-42e7-ab35-55eb18f65a80"),
    NullableValue = Guid.Parse("e9ff4bf0-0dbd-4e68-b639-5888c8e5e472"),
},
    NullableValue = Guid.Parse("88e7a33a-7632-46df-9a81-987400e27ac7"),
},
            new Guiduuid0M
{
    Id = 33,
    Value = Guid.Parse("f5bedeb9-9819-4767-9918-010254995318"),
    ModelInner = null,
    NullableValue = Guid.Parse("fb63a527-e8dd-4ff7-bafa-65a65f5116eb"),
},
            new Guiduuid0M
{
    Id = 36,
    Value = Guid.Parse("d3fbf5f0-67b4-40d2-927e-d0f122da3dd7"),
    ModelInner = new Guiduuid0MI
{
    Id = 27,
    Value = Guid.Parse("748783db-7983-4c8c-a5b7-16eba5010914"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 43,
    Value = Guid.Parse("3b639ae3-6d3e-4ad0-a3c9-9b2f46823b8e"),
    ModelInner = null,
    NullableValue = Guid.Parse("98fc324e-0a34-4758-b96f-4a7be2ba13f5"),
},
            new Guiduuid0M
{
    Id = 49,
    Value = Guid.Parse("bf5a4ccc-1949-436d-bdb3-d0ae4cb35455"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("d6bc921d-8b96-466b-ab71-a9429c7d8088"),
    NullableValue = Guid.Parse("5aa0f5ab-2373-4a58-b930-64198a0e42cf"),
},
    NullableValue = Guid.Parse("4e575228-861b-4e25-8023-b3b033aab052"),
},
            new Guiduuid0M
{
    Id = 55,
    Value = Guid.Parse("3243a843-c20e-4935-8226-3f1e642845cc"),
    ModelInner = null,
    NullableValue = Guid.Parse("d60f5ed4-2a44-4bfe-a311-d7c319211c67"),
},
            new Guiduuid0M
{
    Id = 62,
    Value = Guid.Parse("56e98891-53bd-4acf-be07-644a551aa3f3"),
    ModelInner = new Guiduuid0MI
{
    Id = 41,
    Value = Guid.Parse("c2c7adc2-f710-4a37-bbe9-44d1eeb5eb30"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9e28951c-1727-491d-a5db-913c310d1f7a"),
},
            new Guiduuid0M
{
    Id = 69,
    Value = Guid.Parse("211a8e6c-ad54-406f-ad4f-7cf621ee1b28"),
    ModelInner = null,
    NullableValue = Guid.Parse("719cbbe9-f35a-4170-8204-8971ce150111"),
},
            new Guiduuid0M
{
    Id = 77,
    Value = Guid.Parse("1ecf7d65-98f6-4c47-bfc3-a452ec49b441"),
    ModelInner = new Guiduuid0MI
{
    Id = 50,
    Value = Guid.Parse("0e85697a-5746-4818-9403-73b4e1a98e3d"),
    NullableValue = Guid.Parse("ae0120e5-f704-4fd4-9917-5c1e7f366aeb"),
},
    NullableValue = Guid.Parse("55a93d90-bf5a-481e-807e-fd892802713d"),
},
            new Guiduuid0M
{
    Id = 85,
    Value = Guid.Parse("919aabf5-1b94-4d70-bff5-4c56463a2dd8"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 87,
    Value = Guid.Parse("be150a4b-001c-4ce3-a216-94d74f7e40c6"),
    ModelInner = new Guiduuid0MI
{
    Id = 54,
    Value = Guid.Parse("3a0431c2-c78f-4106-87dc-895ff45e5567"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("85d7e669-163c-4215-a1e4-950795d98d2b"),
},
            new Guiduuid0M
{
    Id = 93,
    Value = Guid.Parse("af9a18b5-d669-4e3a-95e6-4dc8f5535099"),
    ModelInner = null,
    NullableValue = Guid.Parse("9075dab2-3ecb-4387-8017-22097086c3b3"),
},
            new Guiduuid0M
{
    Id = 97,
    Value = Guid.Parse("4c71e7f6-e6d5-4650-bf53-320cdcd1e898"),
    ModelInner = new Guiduuid0MI
{
    Id = 63,
    Value = Guid.Parse("b195e983-4d8e-4496-a287-b7fc8aea2d26"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 103,
    Value = Guid.Parse("b6128a6a-547e-4ef4-af1b-1a9479464f63"),
    ModelInner = null,
    NullableValue = Guid.Parse("893692c9-fdcb-4fd8-996c-47062e14e509"),
},
            new Guiduuid0M
{
    Id = 107,
    Value = Guid.Parse("4204d229-8144-40b9-971d-bb0bcc793d09"),
    ModelInner = new Guiduuid0MI
{
    Id = 65,
    Value = Guid.Parse("95911deb-30b3-4a07-9a99-91ae2e4615c2"),
    NullableValue = Guid.Parse("cebd6714-4d08-4fb8-a4ab-3a2e06c398fd"),
},
    NullableValue = Guid.Parse("1f916839-9eb7-4bd9-ac40-5a38e436bc36"),
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("c3ba610e-01a8-425b-bf7b-b07616e370f0"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 112,
    Value = Guid.Parse("3bd93399-4231-424e-9cb2-85a40d30303c"),
    ModelInner = new Guiduuid0MI
{
    Id = 71,
    Value = Guid.Parse("1c7c4ee2-2cfb-46ac-b334-7ccda7087527"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 114,
    Value = Guid.Parse("b4ea5da0-58df-46bd-ab20-0efee89c2d1e"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 121,
    Value = Guid.Parse("895455c1-7479-45cf-a8af-8b9395617635"),
    ModelInner = new Guiduuid0MI
{
    Id = 79,
    Value = Guid.Parse("6b2c3586-6469-4b35-b6c5-e15bf0ee415d"),
    NullableValue = Guid.Parse("5c6bfa5f-efa2-46f0-8655-bc72d7bb5b46"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 128,
    Value = Guid.Parse("afa78b1e-bab9-449b-97ce-985dc4458d62"),
    ModelInner = null,
    NullableValue = Guid.Parse("9691a258-968c-4f44-aee9-654acf032694"),
},
            new Guiduuid0M
{
    Id = 129,
    Value = Guid.Parse("67c9c159-4c69-4725-9679-83b661a83c42"),
    ModelInner = new Guiduuid0MI
{
    Id = 88,
    Value = Guid.Parse("41de7360-e32f-42f7-a9ef-dfb9bde40bcb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("36e4051c-6713-43a3-ab2a-899e12b0ac13"),
},
            new Guiduuid0M
{
    Id = 130,
    Value = Guid.Parse("d94f3ab7-e943-407a-ad77-47bd9f4dae12"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 137,
    Value = Guid.Parse("f9e6ae29-5074-44a8-9b0e-abd99688c3f2"),
    ModelInner = new Guiduuid0MI
{
    Id = 91,
    Value = Guid.Parse("821fdbff-731c-4bca-95e1-17e2a9ab025d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("20c6f99f-38cf-436f-bd14-150be6105ba2"),
},
            new Guiduuid0M
{
    Id = 142,
    Value = Guid.Parse("1943ca43-b7cb-4442-b373-297111b58ee1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 150,
    Value = Guid.Parse("63e81977-6ece-4af2-ba68-96afcc2e5b63"),
    ModelInner = new Guiduuid0MI
{
    Id = 94,
    Value = Guid.Parse("b38147e3-10ac-438a-b209-4cb8ddfae946"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 153,
    Value = Guid.Parse("cd92f48b-50f7-413b-a53e-60d69ca8ff44"),
    ModelInner = null,
    NullableValue = Guid.Parse("789ffa0f-47c1-45bb-ab85-6014e7e181f9"),
},
            new Guiduuid0M
{
    Id = 156,
    Value = Guid.Parse("7ebbc310-ece5-4d37-b84e-3178686249d5"),
    ModelInner = new Guiduuid0MI
{
    Id = 96,
    Value = Guid.Parse("2da58042-e221-4a58-a773-1f67b3cb1995"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d1ad1307-27a8-4587-8750-69c76dde49c3"),
},
            new Guiduuid0M
{
    Id = 165,
    Value = Guid.Parse("f585e26e-0605-42dc-806c-eec42ad6ef72"),
    ModelInner = null,
    NullableValue = Guid.Parse("be922a4f-dc6c-4bf4-a953-3c336d3c5eeb"),
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("f9cc2133-d99d-4eb8-845c-849004f6001e")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("88e7a33a-7632-46df-9a81-987400e27ac7")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("fb63a527-e8dd-4ff7-bafa-65a65f5116eb")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("98fc324e-0a34-4758-b96f-4a7be2ba13f5")));
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("4e575228-861b-4e25-8023-b3b033aab052")));
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatGuiduuid0M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduuid0M.AssertModel(models[0],_testData[29], false);
                        Guiduuid0M.AssertModel(models[1],_testData[30], false);
                        Guiduuid0M.AssertModel(models[2],_testData[31], false);
                        Guiduuid0M.AssertModel(models[3],_testData[32], false);
                        Guiduuid0M.AssertModel(models[4],_testData[33], false);
                        Guiduuid0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        Guiduuid0M.AssertModel(models[10],_testData[30], false);
                        Guiduuid0M.AssertModel(models[11],_testData[31], false);
                        Guiduuid0M.AssertModel(models[12],_testData[32], false);
                        Guiduuid0M.AssertModel(models[13],_testData[33], false);
                        Guiduuid0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guiduuid0M.AssertModel(models[0],_testData[19], false);
                        Guiduuid0M.AssertModel(models[1],_testData[20], false);
                        Guiduuid0M.AssertModel(models[2],_testData[21], false);
                        Guiduuid0M.AssertModel(models[3],_testData[22], false);
                        Guiduuid0M.AssertModel(models[4],_testData[23], false);
                        Guiduuid0M.AssertModel(models[5],_testData[24], false);
                        Guiduuid0M.AssertModel(models[6],_testData[25], false);
                        Guiduuid0M.AssertModel(models[7],_testData[26], false);
                        Guiduuid0M.AssertModel(models[8],_testData[27], false);
                        Guiduuid0M.AssertModel(models[9],_testData[28], false);
                        Guiduuid0M.AssertModel(models[10],_testData[29], false);
                        Guiduuid0M.AssertModel(models[11],_testData[30], false);
                        Guiduuid0M.AssertModel(models[12],_testData[31], false);
                        Guiduuid0M.AssertModel(models[13],_testData[32], false);
                        Guiduuid0M.AssertModel(models[14],_testData[33], false);
                        Guiduuid0M.AssertModel(models[15],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 32, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 36, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 15, query2))
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        FlatGuiduuid0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduuid0M.AssertModel(models[0],_testData[29], false);
                        Guiduuid0M.AssertModel(models[1],_testData[30], false);
                        Guiduuid0M.AssertModel(models[2],_testData[31], false);
                        Guiduuid0M.AssertModel(models[3],_testData[32], false);
                        Guiduuid0M.AssertModel(models[4],_testData[33], false);
                        Guiduuid0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Guiduuid0M.AssertModel(models[0],_testData[24], false);
                        Guiduuid0M.AssertModel(models[1],_testData[25], false);
                        Guiduuid0M.AssertModel(models[2],_testData[26], false);
                        Guiduuid0M.AssertModel(models[3],_testData[27], false);
                        Guiduuid0M.AssertModel(models[4],_testData[28], false);
                        Guiduuid0M.AssertModel(models[5],_testData[29], false);
                        Guiduuid0M.AssertModel(models[6],_testData[30], false);
                        Guiduuid0M.AssertModel(models[7],_testData[31], false);
                        Guiduuid0M.AssertModel(models[8],_testData[32], false);
                        Guiduuid0M.AssertModel(models[9],_testData[33], false);
                        Guiduuid0M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 121, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guiduuid0M.AssertModel(models[0],_testData[26], false);
                        Guiduuid0M.AssertModel(models[1],_testData[27], false);
                        Guiduuid0M.AssertModel(models[2],_testData[28], false);
                        Guiduuid0M.AssertModel(models[3],_testData[29], false);
                        Guiduuid0M.AssertModel(models[4],_testData[30], false);
                        Guiduuid0M.AssertModel(models[5],_testData[31], false);
                        Guiduuid0M.AssertModel(models[6],_testData[32], false);
                        Guiduuid0M.AssertModel(models[7],_testData[33], false);
                        Guiduuid0M.AssertModel(models[8],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 153);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Guiduuid0M.AssertModel(models[0],_testData[33], false);Guiduuid0M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Guiduuid0M.AssertModel(models[0],_testData[32], false);Guiduuid0M.AssertModel(models[1],_testData[33], false);Guiduuid0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6dbc941-c830-4011-8bab-dc8b1502e256"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f883f919-1b4e-48ff-b419-25b25cb49197"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a04d5d3-4522-4b8c-99b2-f7a6b537d8ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0876730e-3f7a-4632-b9b7-0ab4621a3187"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3ca845d5-f52f-4a03-bd9e-3c86c52812c8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea377256-b5bc-459d-8765-f0c46cfe6ae2"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ea5eb63-3fea-403e-a47f-be8c95ba1a16"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4f019f0-0571-4273-8047-9b2e4fde9bca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0785fb5d-4a1a-4b8f-9e4c-14791188e539"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("685a9859-4e23-4986-9a8e-7b0d49f5f14b"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a7db83f-790e-4f51-bacf-0e724afdaaa9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9e26eb8-9cb9-4065-827b-caeab2a996a2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9ea52ffd-3018-4a79-a54b-292f6e5d723f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5ef21f57-e8cd-49cf-adff-ea01208014f3"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("48e3f9fe-5c66-45a9-b78d-22079b7d7146"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f9cc2133-d99d-4eb8-845c-849004f6001e"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb42bd5d-709b-4f52-b901-7e6fc233c27a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e979d26-9a8d-42e7-ab35-55eb18f65a80"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9ff4bf0-0dbd-4e68-b639-5888c8e5e472"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88e7a33a-7632-46df-9a81-987400e27ac7"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5bedeb9-9819-4767-9918-010254995318"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb63a527-e8dd-4ff7-bafa-65a65f5116eb"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d3fbf5f0-67b4-40d2-927e-d0f122da3dd7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("748783db-7983-4c8c-a5b7-16eba5010914"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b639ae3-6d3e-4ad0-a3c9-9b2f46823b8e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("98fc324e-0a34-4758-b96f-4a7be2ba13f5"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bf5a4ccc-1949-436d-bdb3-d0ae4cb35455"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d6bc921d-8b96-466b-ab71-a9429c7d8088"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5aa0f5ab-2373-4a58-b930-64198a0e42cf"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e575228-861b-4e25-8023-b3b033aab052"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3243a843-c20e-4935-8226-3f1e642845cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d60f5ed4-2a44-4bfe-a311-d7c319211c67"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56e98891-53bd-4acf-be07-644a551aa3f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c2c7adc2-f710-4a37-bbe9-44d1eeb5eb30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9e28951c-1727-491d-a5db-913c310d1f7a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("211a8e6c-ad54-406f-ad4f-7cf621ee1b28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("719cbbe9-f35a-4170-8204-8971ce150111"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ecf7d65-98f6-4c47-bfc3-a452ec49b441"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0e85697a-5746-4818-9403-73b4e1a98e3d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ae0120e5-f704-4fd4-9917-5c1e7f366aeb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("55a93d90-bf5a-481e-807e-fd892802713d"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("919aabf5-1b94-4d70-bff5-4c56463a2dd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be150a4b-001c-4ce3-a216-94d74f7e40c6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a0431c2-c78f-4106-87dc-895ff45e5567"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85d7e669-163c-4215-a1e4-950795d98d2b"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af9a18b5-d669-4e3a-95e6-4dc8f5535099"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9075dab2-3ecb-4387-8017-22097086c3b3"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c71e7f6-e6d5-4650-bf53-320cdcd1e898"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b195e983-4d8e-4496-a287-b7fc8aea2d26"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6128a6a-547e-4ef4-af1b-1a9479464f63"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("893692c9-fdcb-4fd8-996c-47062e14e509"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4204d229-8144-40b9-971d-bb0bcc793d09"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("95911deb-30b3-4a07-9a99-91ae2e4615c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cebd6714-4d08-4fb8-a4ab-3a2e06c398fd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f916839-9eb7-4bd9-ac40-5a38e436bc36"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c3ba610e-01a8-425b-bf7b-b07616e370f0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bd93399-4231-424e-9cb2-85a40d30303c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1c7c4ee2-2cfb-46ac-b334-7ccda7087527"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4ea5da0-58df-46bd-ab20-0efee89c2d1e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("895455c1-7479-45cf-a8af-8b9395617635"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6b2c3586-6469-4b35-b6c5-e15bf0ee415d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5c6bfa5f-efa2-46f0-8655-bc72d7bb5b46"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afa78b1e-bab9-449b-97ce-985dc4458d62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9691a258-968c-4f44-aee9-654acf032694"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67c9c159-4c69-4725-9679-83b661a83c42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("41de7360-e32f-42f7-a9ef-dfb9bde40bcb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("36e4051c-6713-43a3-ab2a-899e12b0ac13"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d94f3ab7-e943-407a-ad77-47bd9f4dae12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f9e6ae29-5074-44a8-9b0e-abd99688c3f2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("821fdbff-731c-4bca-95e1-17e2a9ab025d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20c6f99f-38cf-436f-bd14-150be6105ba2"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1943ca43-b7cb-4442-b373-297111b58ee1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63e81977-6ece-4af2-ba68-96afcc2e5b63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b38147e3-10ac-438a-b209-4cb8ddfae946"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd92f48b-50f7-413b-a53e-60d69ca8ff44"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("789ffa0f-47c1-45bb-ab85-6014e7e181f9"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ebbc310-ece5-4d37-b84e-3178686249d5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2da58042-e221-4a58-a773-1f67b3cb1995"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1ad1307-27a8-4587-8750-69c76dde49c3"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f585e26e-0605-42dc-806c-eec42ad6ef72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be922a4f-dc6c-4bf4-a953-3c336d3c5eeb"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6dbc941-c830-4011-8bab-dc8b1502e256"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f883f919-1b4e-48ff-b419-25b25cb49197"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a04d5d3-4522-4b8c-99b2-f7a6b537d8ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0876730e-3f7a-4632-b9b7-0ab4621a3187"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3ca845d5-f52f-4a03-bd9e-3c86c52812c8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea377256-b5bc-459d-8765-f0c46cfe6ae2"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ea5eb63-3fea-403e-a47f-be8c95ba1a16"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4f019f0-0571-4273-8047-9b2e4fde9bca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0785fb5d-4a1a-4b8f-9e4c-14791188e539"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("685a9859-4e23-4986-9a8e-7b0d49f5f14b"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a7db83f-790e-4f51-bacf-0e724afdaaa9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9e26eb8-9cb9-4065-827b-caeab2a996a2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9ea52ffd-3018-4a79-a54b-292f6e5d723f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5ef21f57-e8cd-49cf-adff-ea01208014f3"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("48e3f9fe-5c66-45a9-b78d-22079b7d7146"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f9cc2133-d99d-4eb8-845c-849004f6001e"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb42bd5d-709b-4f52-b901-7e6fc233c27a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e979d26-9a8d-42e7-ab35-55eb18f65a80"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9ff4bf0-0dbd-4e68-b639-5888c8e5e472"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88e7a33a-7632-46df-9a81-987400e27ac7"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5bedeb9-9819-4767-9918-010254995318"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fb63a527-e8dd-4ff7-bafa-65a65f5116eb"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d3fbf5f0-67b4-40d2-927e-d0f122da3dd7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("748783db-7983-4c8c-a5b7-16eba5010914"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b639ae3-6d3e-4ad0-a3c9-9b2f46823b8e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("98fc324e-0a34-4758-b96f-4a7be2ba13f5"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bf5a4ccc-1949-436d-bdb3-d0ae4cb35455"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d6bc921d-8b96-466b-ab71-a9429c7d8088"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5aa0f5ab-2373-4a58-b930-64198a0e42cf"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e575228-861b-4e25-8023-b3b033aab052"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3243a843-c20e-4935-8226-3f1e642845cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d60f5ed4-2a44-4bfe-a311-d7c319211c67"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("56e98891-53bd-4acf-be07-644a551aa3f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c2c7adc2-f710-4a37-bbe9-44d1eeb5eb30"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9e28951c-1727-491d-a5db-913c310d1f7a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("211a8e6c-ad54-406f-ad4f-7cf621ee1b28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("719cbbe9-f35a-4170-8204-8971ce150111"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ecf7d65-98f6-4c47-bfc3-a452ec49b441"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0e85697a-5746-4818-9403-73b4e1a98e3d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ae0120e5-f704-4fd4-9917-5c1e7f366aeb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("55a93d90-bf5a-481e-807e-fd892802713d"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("919aabf5-1b94-4d70-bff5-4c56463a2dd8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be150a4b-001c-4ce3-a216-94d74f7e40c6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a0431c2-c78f-4106-87dc-895ff45e5567"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85d7e669-163c-4215-a1e4-950795d98d2b"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af9a18b5-d669-4e3a-95e6-4dc8f5535099"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9075dab2-3ecb-4387-8017-22097086c3b3"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c71e7f6-e6d5-4650-bf53-320cdcd1e898"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b195e983-4d8e-4496-a287-b7fc8aea2d26"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6128a6a-547e-4ef4-af1b-1a9479464f63"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("893692c9-fdcb-4fd8-996c-47062e14e509"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4204d229-8144-40b9-971d-bb0bcc793d09"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("95911deb-30b3-4a07-9a99-91ae2e4615c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cebd6714-4d08-4fb8-a4ab-3a2e06c398fd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f916839-9eb7-4bd9-ac40-5a38e436bc36"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c3ba610e-01a8-425b-bf7b-b07616e370f0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bd93399-4231-424e-9cb2-85a40d30303c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1c7c4ee2-2cfb-46ac-b334-7ccda7087527"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4ea5da0-58df-46bd-ab20-0efee89c2d1e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("895455c1-7479-45cf-a8af-8b9395617635"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6b2c3586-6469-4b35-b6c5-e15bf0ee415d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5c6bfa5f-efa2-46f0-8655-bc72d7bb5b46"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afa78b1e-bab9-449b-97ce-985dc4458d62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9691a258-968c-4f44-aee9-654acf032694"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67c9c159-4c69-4725-9679-83b661a83c42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("41de7360-e32f-42f7-a9ef-dfb9bde40bcb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("36e4051c-6713-43a3-ab2a-899e12b0ac13"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d94f3ab7-e943-407a-ad77-47bd9f4dae12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f9e6ae29-5074-44a8-9b0e-abd99688c3f2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("821fdbff-731c-4bca-95e1-17e2a9ab025d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("20c6f99f-38cf-436f-bd14-150be6105ba2"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1943ca43-b7cb-4442-b373-297111b58ee1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63e81977-6ece-4af2-ba68-96afcc2e5b63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b38147e3-10ac-438a-b209-4cb8ddfae946"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd92f48b-50f7-413b-a53e-60d69ca8ff44"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("789ffa0f-47c1-45bb-ab85-6014e7e181f9"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ebbc310-ece5-4d37-b84e-3178686249d5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2da58042-e221-4a58-a773-1f67b3cb1995"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d1ad1307-27a8-4587-8750-69c76dde49c3"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f585e26e-0605-42dc-806c-eec42ad6ef72"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("be922a4f-dc6c-4bf4-a953-3c336d3c5eeb"))));

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

