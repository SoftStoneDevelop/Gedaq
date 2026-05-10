

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
    Id = 4,
    Value = Guid.Parse("c10dc7ee-896c-4787-8c61-e0791a335bed"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 6,
    Value = Guid.Parse("742341c2-82fc-4485-8ad4-da3ad0c0f2f7"),
    ModelInner = new Guiduuid0MI
{
    Id = 5,
    Value = Guid.Parse("6f4996e8-047a-4708-8fad-1dc2426447cd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 10,
    Value = Guid.Parse("fd8bf86c-3874-457e-aab3-292484a582a2"),
    ModelInner = null,
    NullableValue = Guid.Parse("0bffe43c-8fcd-472f-929f-6b2e9667d7e3"),
},
            new Guiduuid0M
{
    Id = 17,
    Value = Guid.Parse("7748203b-c543-4180-886e-6d708bf448ab"),
    ModelInner = new Guiduuid0MI
{
    Id = 9,
    Value = Guid.Parse("cb860dc5-66b9-40eb-8621-c166cf23ffc8"),
    NullableValue = Guid.Parse("a53bcc36-e4f7-41ff-9d59-b56b0b07d850"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 18,
    Value = Guid.Parse("34e0ad9e-f601-4dcd-9b1b-0a05495a1aeb"),
    ModelInner = null,
    NullableValue = Guid.Parse("f697b280-1b46-4055-8b32-46502f37b6a8"),
},
            new Guiduuid0M
{
    Id = 19,
    Value = Guid.Parse("d7b9b73c-b07d-4341-b7cd-90694072c927"),
    ModelInner = new Guiduuid0MI
{
    Id = 12,
    Value = Guid.Parse("ee71a0e3-c073-46ac-ac7d-3179eb0c2a10"),
    NullableValue = Guid.Parse("c6a6ac57-4004-4b07-8574-83767923226f"),
},
    NullableValue = Guid.Parse("5c459637-3ea9-454c-8cc5-64bad51eb673"),
},
            new Guiduuid0M
{
    Id = 22,
    Value = Guid.Parse("ae6e342f-4a05-4073-bef4-a3bea6f75f70"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 30,
    Value = Guid.Parse("c7b519a0-0348-4163-9edb-9f4f9b3a686e"),
    ModelInner = new Guiduuid0MI
{
    Id = 16,
    Value = Guid.Parse("de575c17-508f-46fe-8570-027a70d93b64"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5860f30a-dc1b-4cfb-8aad-0c6ba68c6e9e"),
},
            new Guiduuid0M
{
    Id = 39,
    Value = Guid.Parse("e79e455f-81bf-4651-bde6-387274a12727"),
    ModelInner = null,
    NullableValue = Guid.Parse("e62c61fe-8200-4f2c-8d8e-73ae24c00115"),
},
            new Guiduuid0M
{
    Id = 47,
    Value = Guid.Parse("d11b3b44-a4ba-4671-907e-8a6634ccead3"),
    ModelInner = new Guiduuid0MI
{
    Id = 20,
    Value = Guid.Parse("c4988868-3eec-4e2d-8d48-5eecd46c8e66"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("5b92a8f0-cda6-4ae3-a5f3-e99b6aa11d6e"),
},
            new Guiduuid0M
{
    Id = 54,
    Value = Guid.Parse("4099b5da-7e75-422d-af74-1fd5db7fc556"),
    ModelInner = null,
    NullableValue = Guid.Parse("f68e187a-d4c0-44ae-a860-a6610893fecf"),
},
            new Guiduuid0M
{
    Id = 59,
    Value = Guid.Parse("44fe558e-3e8a-4d3f-9f39-9e7bf77ba4f5"),
    ModelInner = new Guiduuid0MI
{
    Id = 25,
    Value = Guid.Parse("a740c0c1-529c-4964-9840-144a736047b5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("32c5ec42-0abd-40c8-9dfe-e1cb9d46b5f1"),
},
            new Guiduuid0M
{
    Id = 63,
    Value = Guid.Parse("e12778d4-c722-49fc-8ad5-0a02bbce21ce"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 65,
    Value = Guid.Parse("8b553810-43fc-447d-babc-3700f8048af7"),
    ModelInner = new Guiduuid0MI
{
    Id = 33,
    Value = Guid.Parse("1e034fd4-efbf-492a-b516-c2cd7df379fb"),
    NullableValue = Guid.Parse("009d92c6-45b4-4662-8215-07149bdda01b"),
},
    NullableValue = Guid.Parse("e984d5ee-f70e-4332-87f2-6c224390fa14"),
},
            new Guiduuid0M
{
    Id = 69,
    Value = Guid.Parse("1e2df611-0db0-40e5-8ff1-ff3a29ee8437"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 75,
    Value = Guid.Parse("74c9d8b9-2fe7-4a0c-928f-f2bdfc1128b5"),
    ModelInner = new Guiduuid0MI
{
    Id = 41,
    Value = Guid.Parse("396e9dc8-07b4-4778-b87c-73fd2ab5d056"),
    NullableValue = Guid.Parse("c684c281-78a2-4668-87dc-e7a415ac186b"),
},
    NullableValue = Guid.Parse("e614231d-cbc0-47ff-bf6c-1b728ff3568f"),
},
            new Guiduuid0M
{
    Id = 79,
    Value = Guid.Parse("80e9dba9-9538-40d4-b2d3-a635f42511ff"),
    ModelInner = null,
    NullableValue = Guid.Parse("6b4611f3-d3ea-4d9b-9db9-741c07c8543a"),
},
            new Guiduuid0M
{
    Id = 86,
    Value = Guid.Parse("03e17929-98fb-4d82-9f07-8d75a9b9beb9"),
    ModelInner = new Guiduuid0MI
{
    Id = 43,
    Value = Guid.Parse("556009a1-af7d-4573-b86f-92b4c3a6641a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 87,
    Value = Guid.Parse("bbd5ede3-c610-473e-b491-aae1122364c0"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 95,
    Value = Guid.Parse("df01b302-07d0-48de-a570-a2ab551ff49b"),
    ModelInner = new Guiduuid0MI
{
    Id = 51,
    Value = Guid.Parse("1307d76b-6180-4773-9f0b-8cf4fce00198"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 99,
    Value = Guid.Parse("1d41c7f7-b757-43b7-9307-e992486a033d"),
    ModelInner = null,
    NullableValue = Guid.Parse("1f0e2166-3e66-4c84-8e44-8e2d238a3a97"),
},
            new Guiduuid0M
{
    Id = 100,
    Value = Guid.Parse("c16a7ada-b85e-4565-8845-b79c91618c71"),
    ModelInner = new Guiduuid0MI
{
    Id = 55,
    Value = Guid.Parse("afdb0664-7435-453f-89ad-d3872092afbd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 101,
    Value = Guid.Parse("fac4e056-8684-4ec6-975f-650c580d39bb"),
    ModelInner = null,
    NullableValue = Guid.Parse("fbc2807f-92f6-48da-992a-1051cc86b17f"),
},
            new Guiduuid0M
{
    Id = 108,
    Value = Guid.Parse("6c270aa2-16ce-4639-9c5f-96f7baff4c6d"),
    ModelInner = new Guiduuid0MI
{
    Id = 59,
    Value = Guid.Parse("9094b4a3-77ee-43fa-b7c0-e60f605e0aed"),
    NullableValue = Guid.Parse("dc1c56d0-1b39-4874-8ef9-b987fdf04e4d"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 117,
    Value = Guid.Parse("93a81534-4887-42ef-b1af-3fc57142cd69"),
    ModelInner = null,
    NullableValue = Guid.Parse("dad94182-4646-4ae2-85ea-49cff48125ac"),
},
            new Guiduuid0M
{
    Id = 119,
    Value = Guid.Parse("a8213465-1bc6-4609-8efd-673672485bdc"),
    ModelInner = new Guiduuid0MI
{
    Id = 60,
    Value = Guid.Parse("9a846922-c449-4b34-acd2-f32fc3374e8c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("1d11a878-2329-4038-985c-22284ea1dccc"),
},
            new Guiduuid0M
{
    Id = 120,
    Value = Guid.Parse("c29b6707-78d5-4b20-b935-ac3414c6053a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 129,
    Value = Guid.Parse("ed5a0d69-0647-4f31-83dd-079b0b46c932"),
    ModelInner = new Guiduuid0MI
{
    Id = 69,
    Value = Guid.Parse("64c8b14b-db4d-4402-b3df-48ba8d90d1ea"),
    NullableValue = Guid.Parse("09cf960d-0a2f-4e70-929e-2ed13a98891e"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 138,
    Value = Guid.Parse("9e26efe3-9079-4e18-a76e-58141d2cc892"),
    ModelInner = null,
    NullableValue = Guid.Parse("cab10b06-9153-4d29-bee9-171e99ff08c4"),
},
            new Guiduuid0M
{
    Id = 140,
    Value = Guid.Parse("dc424c7b-966b-4dd3-b06e-78bf4fe5c501"),
    ModelInner = new Guiduuid0MI
{
    Id = 77,
    Value = Guid.Parse("cb1a9b73-840a-476b-83d2-91592e3fd7fa"),
    NullableValue = Guid.Parse("04e9e0fa-fb6f-4e46-9d29-0a0fac140377"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 142,
    Value = Guid.Parse("2bb60a5c-c08e-4e0d-9685-127a139ae085"),
    ModelInner = null,
    NullableValue = Guid.Parse("a6b0a650-fdb3-417c-be46-f1a1f0c3aaee"),
},
            new Guiduuid0M
{
    Id = 150,
    Value = Guid.Parse("98a88a01-ded5-4ec5-bcb8-33f738e137d4"),
    ModelInner = new Guiduuid0MI
{
    Id = 85,
    Value = Guid.Parse("c180e3ee-56bb-4f39-870a-b7de2b15c606"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 151,
    Value = Guid.Parse("99e74062-731f-4cc4-87c6-0a0da3e36aa2"),
    ModelInner = null,
    NullableValue = Guid.Parse("01f7e768-6e01-42bd-901b-e4072ff3d139"),
},
            new Guiduuid0M
{
    Id = 154,
    Value = Guid.Parse("f158e0e4-9a4c-438c-98f2-72b9f0bf7e0c"),
    ModelInner = new Guiduuid0MI
{
    Id = 89,
    Value = Guid.Parse("7de491bf-89f6-4613-a51a-09893b12790e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 163,
    Value = Guid.Parse("ab044a61-237e-453e-8bae-5c848c497772"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("f697b280-1b46-4055-8b32-46502f37b6a8")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("5c459637-3ea9-454c-8cc5-64bad51eb673")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("5860f30a-dc1b-4cfb-8aad-0c6ba68c6e9e")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("e62c61fe-8200-4f2c-8d8e-73ae24c00115")));
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("5b92a8f0-cda6-4ae3-a5f3-e99b6aa11d6e")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("f68e187a-d4c0-44ae-a860-a6610893fecf")));
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("32c5ec42-0abd-40c8-9dfe-e1cb9d46b5f1")));
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
                parametr1.Value = 117;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[34], false);
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
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Guiduuid0M.AssertModel(models[0],_testData[1], false);
                        Guiduuid0M.AssertModel(models[1],_testData[2], false);
                        Guiduuid0M.AssertModel(models[2],_testData[3], false);
                        Guiduuid0M.AssertModel(models[3],_testData[4], false);
                        Guiduuid0M.AssertModel(models[4],_testData[5], false);
                        Guiduuid0M.AssertModel(models[5],_testData[6], false);
                        Guiduuid0M.AssertModel(models[6],_testData[7], false);
                        Guiduuid0M.AssertModel(models[7],_testData[8], false);
                        Guiduuid0M.AssertModel(models[8],_testData[9], false);
                        Guiduuid0M.AssertModel(models[9],_testData[10], false);
                        Guiduuid0M.AssertModel(models[10],_testData[11], false);
                        Guiduuid0M.AssertModel(models[11],_testData[12], false);
                        Guiduuid0M.AssertModel(models[12],_testData[13], false);
                        Guiduuid0M.AssertModel(models[13],_testData[14], false);
                        Guiduuid0M.AssertModel(models[14],_testData[15], false);
                        Guiduuid0M.AssertModel(models[15],_testData[16], false);
                        Guiduuid0M.AssertModel(models[16],_testData[17], false);
                        Guiduuid0M.AssertModel(models[17],_testData[18], false);
                        Guiduuid0M.AssertModel(models[18],_testData[19], false);
                        Guiduuid0M.AssertModel(models[19],_testData[20], false);
                        Guiduuid0M.AssertModel(models[20],_testData[21], false);
                        Guiduuid0M.AssertModel(models[21],_testData[22], false);
                        Guiduuid0M.AssertModel(models[22],_testData[23], false);
                        Guiduuid0M.AssertModel(models[23],_testData[24], false);
                        Guiduuid0M.AssertModel(models[24],_testData[25], false);
                        Guiduuid0M.AssertModel(models[25],_testData[26], false);
                        Guiduuid0M.AssertModel(models[26],_testData[27], false);
                        Guiduuid0M.AssertModel(models[27],_testData[28], false);
                        Guiduuid0M.AssertModel(models[28],_testData[29], false);
                        Guiduuid0M.AssertModel(models[29],_testData[30], false);
                        Guiduuid0M.AssertModel(models[30],_testData[31], false);
                        Guiduuid0M.AssertModel(models[31],_testData[32], false);
                        Guiduuid0M.AssertModel(models[32],_testData[33], false);
                        Guiduuid0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guiduuid0M.AssertModel(models[0],_testData[28], false);
                        Guiduuid0M.AssertModel(models[1],_testData[29], false);
                        Guiduuid0M.AssertModel(models[2],_testData[30], false);
                        Guiduuid0M.AssertModel(models[3],_testData[31], false);
                        Guiduuid0M.AssertModel(models[4],_testData[32], false);
                        Guiduuid0M.AssertModel(models[5],_testData[33], false);
                        Guiduuid0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 95, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 10, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 19, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[31],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 39, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 101, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guiduuid0M.AssertModel(models[0],_testData[23], false);
                        Guiduuid0M.AssertModel(models[1],_testData[24], false);
                        Guiduuid0M.AssertModel(models[2],_testData[25], false);
                        Guiduuid0M.AssertModel(models[3],_testData[26], false);
                        Guiduuid0M.AssertModel(models[4],_testData[27], false);
                        Guiduuid0M.AssertModel(models[5],_testData[28], false);
                        Guiduuid0M.AssertModel(models[6],_testData[29], false);
                        Guiduuid0M.AssertModel(models[7],_testData[30], false);
                        Guiduuid0M.AssertModel(models[8],_testData[31], false);
                        Guiduuid0M.AssertModel(models[9],_testData[32], false);
                        Guiduuid0M.AssertModel(models[10],_testData[33], false);
                        Guiduuid0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        Guiduuid0M.AssertModel(models[28],_testData[30], false);
                        Guiduuid0M.AssertModel(models[29],_testData[31], false);
                        Guiduuid0M.AssertModel(models[30],_testData[32], false);
                        Guiduuid0M.AssertModel(models[31],_testData[33], false);
                        Guiduuid0M.AssertModel(models[32],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Guiduuid0M.AssertModel(models[0],_testData[1], false);
                Guiduuid0M.AssertModel(models[1],_testData[2], false);
                Guiduuid0M.AssertModel(models[2],_testData[3], false);
                Guiduuid0M.AssertModel(models[3],_testData[4], false);
                Guiduuid0M.AssertModel(models[4],_testData[5], false);
                Guiduuid0M.AssertModel(models[5],_testData[6], false);
                Guiduuid0M.AssertModel(models[6],_testData[7], false);
                Guiduuid0M.AssertModel(models[7],_testData[8], false);
                Guiduuid0M.AssertModel(models[8],_testData[9], false);
                Guiduuid0M.AssertModel(models[9],_testData[10], false);
                Guiduuid0M.AssertModel(models[10],_testData[11], false);
                Guiduuid0M.AssertModel(models[11],_testData[12], false);
                Guiduuid0M.AssertModel(models[12],_testData[13], false);
                Guiduuid0M.AssertModel(models[13],_testData[14], false);
                Guiduuid0M.AssertModel(models[14],_testData[15], false);
                Guiduuid0M.AssertModel(models[15],_testData[16], false);
                Guiduuid0M.AssertModel(models[16],_testData[17], false);
                Guiduuid0M.AssertModel(models[17],_testData[18], false);
                Guiduuid0M.AssertModel(models[18],_testData[19], false);
                Guiduuid0M.AssertModel(models[19],_testData[20], false);
                Guiduuid0M.AssertModel(models[20],_testData[21], false);
                Guiduuid0M.AssertModel(models[21],_testData[22], false);
                Guiduuid0M.AssertModel(models[22],_testData[23], false);
                Guiduuid0M.AssertModel(models[23],_testData[24], false);
                Guiduuid0M.AssertModel(models[24],_testData[25], false);
                Guiduuid0M.AssertModel(models[25],_testData[26], false);
                Guiduuid0M.AssertModel(models[26],_testData[27], false);
                Guiduuid0M.AssertModel(models[27],_testData[28], false);
                Guiduuid0M.AssertModel(models[28],_testData[29], false);
                Guiduuid0M.AssertModel(models[29],_testData[30], false);
                Guiduuid0M.AssertModel(models[30],_testData[31], false);
                Guiduuid0M.AssertModel(models[31],_testData[32], false);
                Guiduuid0M.AssertModel(models[32],_testData[33], false);
                Guiduuid0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

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
                Guiduuid0M.AssertModel(models[17],_testData[30], false);
                Guiduuid0M.AssertModel(models[18],_testData[31], false);
                Guiduuid0M.AssertModel(models[19],_testData[32], false);
                Guiduuid0M.AssertModel(models[20],_testData[33], false);
                Guiduuid0M.AssertModel(models[21],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10dc7ee-896c-4787-8c61-e0791a335bed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("742341c2-82fc-4485-8ad4-da3ad0c0f2f7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6f4996e8-047a-4708-8fad-1dc2426447cd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd8bf86c-3874-457e-aab3-292484a582a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0bffe43c-8fcd-472f-929f-6b2e9667d7e3"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7748203b-c543-4180-886e-6d708bf448ab"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cb860dc5-66b9-40eb-8621-c166cf23ffc8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a53bcc36-e4f7-41ff-9d59-b56b0b07d850"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("34e0ad9e-f601-4dcd-9b1b-0a05495a1aeb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f697b280-1b46-4055-8b32-46502f37b6a8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7b9b73c-b07d-4341-b7cd-90694072c927"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee71a0e3-c073-46ac-ac7d-3179eb0c2a10"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c6a6ac57-4004-4b07-8574-83767923226f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c459637-3ea9-454c-8cc5-64bad51eb673"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae6e342f-4a05-4073-bef4-a3bea6f75f70"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c7b519a0-0348-4163-9edb-9f4f9b3a686e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de575c17-508f-46fe-8570-027a70d93b64"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5860f30a-dc1b-4cfb-8aad-0c6ba68c6e9e"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e79e455f-81bf-4651-bde6-387274a12727"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e62c61fe-8200-4f2c-8d8e-73ae24c00115"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d11b3b44-a4ba-4671-907e-8a6634ccead3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c4988868-3eec-4e2d-8d48-5eecd46c8e66"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b92a8f0-cda6-4ae3-a5f3-e99b6aa11d6e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4099b5da-7e75-422d-af74-1fd5db7fc556"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f68e187a-d4c0-44ae-a860-a6610893fecf"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44fe558e-3e8a-4d3f-9f39-9e7bf77ba4f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a740c0c1-529c-4964-9840-144a736047b5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32c5ec42-0abd-40c8-9dfe-e1cb9d46b5f1"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e12778d4-c722-49fc-8ad5-0a02bbce21ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b553810-43fc-447d-babc-3700f8048af7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1e034fd4-efbf-492a-b516-c2cd7df379fb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("009d92c6-45b4-4662-8215-07149bdda01b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e984d5ee-f70e-4332-87f2-6c224390fa14"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1e2df611-0db0-40e5-8ff1-ff3a29ee8437"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74c9d8b9-2fe7-4a0c-928f-f2bdfc1128b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("396e9dc8-07b4-4778-b87c-73fd2ab5d056"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c684c281-78a2-4668-87dc-e7a415ac186b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e614231d-cbc0-47ff-bf6c-1b728ff3568f"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80e9dba9-9538-40d4-b2d3-a635f42511ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6b4611f3-d3ea-4d9b-9db9-741c07c8543a"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03e17929-98fb-4d82-9f07-8d75a9b9beb9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("556009a1-af7d-4573-b86f-92b4c3a6641a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bbd5ede3-c610-473e-b491-aae1122364c0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df01b302-07d0-48de-a570-a2ab551ff49b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1307d76b-6180-4773-9f0b-8cf4fce00198"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d41c7f7-b757-43b7-9307-e992486a033d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f0e2166-3e66-4c84-8e44-8e2d238a3a97"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c16a7ada-b85e-4565-8845-b79c91618c71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("afdb0664-7435-453f-89ad-d3872092afbd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fac4e056-8684-4ec6-975f-650c580d39bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fbc2807f-92f6-48da-992a-1051cc86b17f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6c270aa2-16ce-4639-9c5f-96f7baff4c6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9094b4a3-77ee-43fa-b7c0-e60f605e0aed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc1c56d0-1b39-4874-8ef9-b987fdf04e4d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93a81534-4887-42ef-b1af-3fc57142cd69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dad94182-4646-4ae2-85ea-49cff48125ac"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8213465-1bc6-4609-8efd-673672485bdc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a846922-c449-4b34-acd2-f32fc3374e8c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d11a878-2329-4038-985c-22284ea1dccc"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c29b6707-78d5-4b20-b935-ac3414c6053a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed5a0d69-0647-4f31-83dd-079b0b46c932"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("64c8b14b-db4d-4402-b3df-48ba8d90d1ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("09cf960d-0a2f-4e70-929e-2ed13a98891e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e26efe3-9079-4e18-a76e-58141d2cc892"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cab10b06-9153-4d29-bee9-171e99ff08c4"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc424c7b-966b-4dd3-b06e-78bf4fe5c501"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cb1a9b73-840a-476b-83d2-91592e3fd7fa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04e9e0fa-fb6f-4e46-9d29-0a0fac140377"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2bb60a5c-c08e-4e0d-9685-127a139ae085"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6b0a650-fdb3-417c-be46-f1a1f0c3aaee"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98a88a01-ded5-4ec5-bcb8-33f738e137d4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c180e3ee-56bb-4f39-870a-b7de2b15c606"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99e74062-731f-4cc4-87c6-0a0da3e36aa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01f7e768-6e01-42bd-901b-e4072ff3d139"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f158e0e4-9a4c-438c-98f2-72b9f0bf7e0c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7de491bf-89f6-4613-a51a-09893b12790e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ab044a61-237e-453e-8bae-5c848c497772"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c10dc7ee-896c-4787-8c61-e0791a335bed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("742341c2-82fc-4485-8ad4-da3ad0c0f2f7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6f4996e8-047a-4708-8fad-1dc2426447cd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd8bf86c-3874-457e-aab3-292484a582a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0bffe43c-8fcd-472f-929f-6b2e9667d7e3"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7748203b-c543-4180-886e-6d708bf448ab"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cb860dc5-66b9-40eb-8621-c166cf23ffc8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a53bcc36-e4f7-41ff-9d59-b56b0b07d850"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("34e0ad9e-f601-4dcd-9b1b-0a05495a1aeb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f697b280-1b46-4055-8b32-46502f37b6a8"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7b9b73c-b07d-4341-b7cd-90694072c927"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee71a0e3-c073-46ac-ac7d-3179eb0c2a10"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c6a6ac57-4004-4b07-8574-83767923226f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5c459637-3ea9-454c-8cc5-64bad51eb673"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae6e342f-4a05-4073-bef4-a3bea6f75f70"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c7b519a0-0348-4163-9edb-9f4f9b3a686e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("de575c17-508f-46fe-8570-027a70d93b64"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5860f30a-dc1b-4cfb-8aad-0c6ba68c6e9e"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e79e455f-81bf-4651-bde6-387274a12727"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e62c61fe-8200-4f2c-8d8e-73ae24c00115"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d11b3b44-a4ba-4671-907e-8a6634ccead3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c4988868-3eec-4e2d-8d48-5eecd46c8e66"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b92a8f0-cda6-4ae3-a5f3-e99b6aa11d6e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4099b5da-7e75-422d-af74-1fd5db7fc556"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f68e187a-d4c0-44ae-a860-a6610893fecf"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44fe558e-3e8a-4d3f-9f39-9e7bf77ba4f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a740c0c1-529c-4964-9840-144a736047b5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32c5ec42-0abd-40c8-9dfe-e1cb9d46b5f1"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e12778d4-c722-49fc-8ad5-0a02bbce21ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b553810-43fc-447d-babc-3700f8048af7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1e034fd4-efbf-492a-b516-c2cd7df379fb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("009d92c6-45b4-4662-8215-07149bdda01b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e984d5ee-f70e-4332-87f2-6c224390fa14"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1e2df611-0db0-40e5-8ff1-ff3a29ee8437"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74c9d8b9-2fe7-4a0c-928f-f2bdfc1128b5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("396e9dc8-07b4-4778-b87c-73fd2ab5d056"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c684c281-78a2-4668-87dc-e7a415ac186b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e614231d-cbc0-47ff-bf6c-1b728ff3568f"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80e9dba9-9538-40d4-b2d3-a635f42511ff"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6b4611f3-d3ea-4d9b-9db9-741c07c8543a"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03e17929-98fb-4d82-9f07-8d75a9b9beb9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("556009a1-af7d-4573-b86f-92b4c3a6641a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bbd5ede3-c610-473e-b491-aae1122364c0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df01b302-07d0-48de-a570-a2ab551ff49b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1307d76b-6180-4773-9f0b-8cf4fce00198"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d41c7f7-b757-43b7-9307-e992486a033d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1f0e2166-3e66-4c84-8e44-8e2d238a3a97"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c16a7ada-b85e-4565-8845-b79c91618c71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("afdb0664-7435-453f-89ad-d3872092afbd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fac4e056-8684-4ec6-975f-650c580d39bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fbc2807f-92f6-48da-992a-1051cc86b17f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6c270aa2-16ce-4639-9c5f-96f7baff4c6d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9094b4a3-77ee-43fa-b7c0-e60f605e0aed"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dc1c56d0-1b39-4874-8ef9-b987fdf04e4d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("93a81534-4887-42ef-b1af-3fc57142cd69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dad94182-4646-4ae2-85ea-49cff48125ac"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8213465-1bc6-4609-8efd-673672485bdc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9a846922-c449-4b34-acd2-f32fc3374e8c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d11a878-2329-4038-985c-22284ea1dccc"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c29b6707-78d5-4b20-b935-ac3414c6053a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ed5a0d69-0647-4f31-83dd-079b0b46c932"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("64c8b14b-db4d-4402-b3df-48ba8d90d1ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("09cf960d-0a2f-4e70-929e-2ed13a98891e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e26efe3-9079-4e18-a76e-58141d2cc892"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cab10b06-9153-4d29-bee9-171e99ff08c4"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc424c7b-966b-4dd3-b06e-78bf4fe5c501"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cb1a9b73-840a-476b-83d2-91592e3fd7fa"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("04e9e0fa-fb6f-4e46-9d29-0a0fac140377"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2bb60a5c-c08e-4e0d-9685-127a139ae085"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6b0a650-fdb3-417c-be46-f1a1f0c3aaee"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98a88a01-ded5-4ec5-bcb8-33f738e137d4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c180e3ee-56bb-4f39-870a-b7de2b15c606"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99e74062-731f-4cc4-87c6-0a0da3e36aa2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01f7e768-6e01-42bd-901b-e4072ff3d139"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f158e0e4-9a4c-438c-98f2-72b9f0bf7e0c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7de491bf-89f6-4613-a51a-09893b12790e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ab044a61-237e-453e-8bae-5c848c497772"))));//Value

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

