

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
    Value = Guid.Parse("e3082dc3-189b-4366-b2d1-37f485a443ed"),
    ModelInner = null,
    NullableValue = Guid.Parse("8c935462-1fab-40b7-bb99-fccd99461de1"),
},
            new Guiduuid0M
{
    Id = 7,
    Value = Guid.Parse("2feacf0b-2bda-49fe-83ec-d86553299c8b"),
    ModelInner = new Guiduuid0MI
{
    Id = 4,
    Value = Guid.Parse("78275fc9-0351-4238-bd62-393785c3a58a"),
    NullableValue = Guid.Parse("5167bdf6-ee3c-4576-90f2-8e2a1077b818"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 9,
    Value = Guid.Parse("0ff3881c-a7df-4a47-8b06-157137dd0ea2"),
    ModelInner = null,
    NullableValue = Guid.Parse("8428f560-d3c3-427e-bcaa-529816949e97"),
},
            new Guiduuid0M
{
    Id = 17,
    Value = Guid.Parse("5f6ba1e3-397f-45c1-827d-7dd80e9d428d"),
    ModelInner = new Guiduuid0MI
{
    Id = 13,
    Value = Guid.Parse("47f2e56d-0929-4852-ab3b-8a0c751946dd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 24,
    Value = Guid.Parse("08677ba2-01a5-49dc-bfc6-ed6c78473fca"),
    ModelInner = null,
    NullableValue = Guid.Parse("d3182533-0e62-4c7b-b43e-2f1eaa15bb3a"),
},
            new Guiduuid0M
{
    Id = 30,
    Value = Guid.Parse("71359bc5-6fc2-48cc-b233-0c47f37a9ab3"),
    ModelInner = new Guiduuid0MI
{
    Id = 19,
    Value = Guid.Parse("bbb876f2-bd0a-47c3-9429-04d202d2ecf0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 35,
    Value = Guid.Parse("1479decb-5b03-465f-8262-11bb8d5ffb3d"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 39,
    Value = Guid.Parse("7dba44b4-6d57-4a83-a6e8-a4410f007083"),
    ModelInner = new Guiduuid0MI
{
    Id = 23,
    Value = Guid.Parse("153211be-9c67-4cf6-81e8-9c827af83669"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 41,
    Value = Guid.Parse("ddcac167-5e42-4ec0-8014-edcd304ade0d"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 48,
    Value = Guid.Parse("31f569c3-481e-4b32-a6fc-4543dfe6e0bf"),
    ModelInner = new Guiduuid0MI
{
    Id = 29,
    Value = Guid.Parse("4a8cc83f-aed3-46c6-8b84-7f4d38bbede6"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("678ebec2-b44c-47dd-ba15-6bad90fb875c"),
},
            new Guiduuid0M
{
    Id = 50,
    Value = Guid.Parse("a8aefc51-198e-4da3-a198-e4d3e2cfc103"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 57,
    Value = Guid.Parse("dcd29a06-4bde-484b-9d3d-899f2882f2ef"),
    ModelInner = new Guiduuid0MI
{
    Id = 30,
    Value = Guid.Parse("b3f82149-5e38-44eb-b1dc-9724359db11d"),
    NullableValue = Guid.Parse("ef0a98fe-5334-4282-a006-3872bab26568"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 59,
    Value = Guid.Parse("70a12165-7c38-4196-8662-6448553eac95"),
    ModelInner = null,
    NullableValue = Guid.Parse("f6893666-c0ab-4117-b523-32cee8748513"),
},
            new Guiduuid0M
{
    Id = 63,
    Value = Guid.Parse("688164af-9e3c-4aca-9cc5-2a10a7343aed"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("3a09de9e-f503-4a69-b302-1d2fd931c4c6"),
    NullableValue = Guid.Parse("7d50d9fb-0699-48bb-8653-290b8e327c61"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 64,
    Value = Guid.Parse("e171233b-25f8-4161-b084-857e24bc039a"),
    ModelInner = null,
    NullableValue = Guid.Parse("8667876a-ae60-483f-8e05-a6880faed7b3"),
},
            new Guiduuid0M
{
    Id = 66,
    Value = Guid.Parse("e030e704-fc35-4a82-8f70-e98d15811cbe"),
    ModelInner = new Guiduuid0MI
{
    Id = 43,
    Value = Guid.Parse("077e90e6-9d5a-4120-b1f0-bf74946031f8"),
    NullableValue = Guid.Parse("ecc0f55b-2017-4580-a901-7668afe03c81"),
},
    NullableValue = Guid.Parse("3c8399a4-c4ba-4e1d-ba2c-88da16c034c1"),
},
            new Guiduuid0M
{
    Id = 75,
    Value = Guid.Parse("c69e9d78-5893-4dc1-89f1-9b094b973999"),
    ModelInner = null,
    NullableValue = Guid.Parse("961bbf0a-afa6-49d6-bc8c-176a6b55be78"),
},
            new Guiduuid0M
{
    Id = 82,
    Value = Guid.Parse("86012ad3-d554-46dd-8403-1ddb94c846d0"),
    ModelInner = new Guiduuid0MI
{
    Id = 46,
    Value = Guid.Parse("35dce035-523b-4bbc-b1ac-269d6ff1f593"),
    NullableValue = Guid.Parse("512f8988-7988-4072-86af-372ee2eb6d24"),
},
    NullableValue = Guid.Parse("74feac23-e900-4e94-a1d4-df5ff5ff93f4"),
},
            new Guiduuid0M
{
    Id = 83,
    Value = Guid.Parse("57376114-a42e-4419-bee9-24d37edd4bd9"),
    ModelInner = null,
    NullableValue = Guid.Parse("fae43330-8b64-4f67-b8f5-e676c1156cf3"),
},
            new Guiduuid0M
{
    Id = 86,
    Value = Guid.Parse("50ceacde-14cf-4d41-942f-1b943bc225a8"),
    ModelInner = new Guiduuid0MI
{
    Id = 54,
    Value = Guid.Parse("a2c5029b-8662-4205-a8f2-774631be6351"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 91,
    Value = Guid.Parse("d8e56ccd-7d2b-4a4c-9bb5-8ec0bf0e3c62"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 99,
    Value = Guid.Parse("7fb51d9e-248e-47cb-8d05-5afce21ce658"),
    ModelInner = new Guiduuid0MI
{
    Id = 55,
    Value = Guid.Parse("cd14c8f5-5d9d-42ef-9a7c-427b94b299d7"),
    NullableValue = Guid.Parse("1a9a815f-9412-4b67-9c59-dfaf6b8ac301"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 104,
    Value = Guid.Parse("e10316e1-f570-4405-98af-392ba56e2f06"),
    ModelInner = null,
    NullableValue = Guid.Parse("4b0a9e84-03e5-42b0-a163-f4818926270e"),
},
            new Guiduuid0M
{
    Id = 107,
    Value = Guid.Parse("7a4d4818-778d-46fc-8383-a89d09fe4afe"),
    ModelInner = new Guiduuid0MI
{
    Id = 59,
    Value = Guid.Parse("7ef6af4e-1e5a-4522-8624-6b9b336c9d9e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 110,
    Value = Guid.Parse("acd6585e-bbf9-4045-857a-44af8083055a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 115,
    Value = Guid.Parse("e91dd78d-e805-4c0a-a9ba-b930b4050cef"),
    ModelInner = new Guiduuid0MI
{
    Id = 60,
    Value = Guid.Parse("2be80ac3-004a-4ffa-9c9d-ff08c27d5860"),
    NullableValue = Guid.Parse("6da70a17-6573-4248-b209-a6aea1e973e9"),
},
    NullableValue = Guid.Parse("75595057-3795-451b-921d-8fa23746387c"),
},
            new Guiduuid0M
{
    Id = 120,
    Value = Guid.Parse("0043eef6-bfa9-4579-a5d7-661361d431a0"),
    ModelInner = null,
    NullableValue = Guid.Parse("9231fc33-64c3-4496-accb-9af2ad1a4cea"),
},
            new Guiduuid0M
{
    Id = 126,
    Value = Guid.Parse("c8635f44-c375-4157-84cd-b40514384a9d"),
    ModelInner = new Guiduuid0MI
{
    Id = 62,
    Value = Guid.Parse("ccf0ab80-1d3f-45fd-999c-21884962cfe7"),
    NullableValue = Guid.Parse("32048fc9-67f4-4e5e-804f-3b94bf9581f6"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 129,
    Value = Guid.Parse("cf1373ae-5268-4e7b-b131-d6bf26ab1818"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 130,
    Value = Guid.Parse("934e5574-f097-4deb-b9fd-95b3c059c357"),
    ModelInner = new Guiduuid0MI
{
    Id = 65,
    Value = Guid.Parse("9e861123-6c35-4dd7-b5db-9be639d50801"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 131,
    Value = Guid.Parse("9b7be312-2f49-467b-9f2f-87554294ecaa"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 133,
    Value = Guid.Parse("601b0f1f-5a48-4ad0-82cd-03bfed0f0fa8"),
    ModelInner = new Guiduuid0MI
{
    Id = 71,
    Value = Guid.Parse("c3170622-affb-4796-99f3-47fb066516f6"),
    NullableValue = Guid.Parse("9266800d-c682-4c8c-99c9-5fd2c111bb62"),
},
    NullableValue = Guid.Parse("abd30aff-5c61-4e42-be85-ea2fc4070f53"),
},
            new Guiduuid0M
{
    Id = 141,
    Value = Guid.Parse("ad7ab838-4230-4a54-bc32-ca745522e22b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 143,
    Value = Guid.Parse("077346e5-b5dc-4c3e-a9a4-b0c874a984af"),
    ModelInner = new Guiduuid0MI
{
    Id = 74,
    Value = Guid.Parse("5161347c-c2e3-4633-baac-8990fc2e1bc1"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 150,
    Value = Guid.Parse("9beccfbd-f803-43c8-ac89-4ed7b8c62e92"),
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("d3182533-0e62-4c7b-b43e-2f1eaa15bb3a")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("678ebec2-b44c-47dd-ba15-6bad90fb875c")));
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
                parametr1.Value = 107;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
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
                parametr1.Value = 104;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduuid0M.AssertModel(models[0],_testData[32], false);
                        Guiduuid0M.AssertModel(models[1],_testData[33], false);
                        Guiduuid0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 115, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[30],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        FlatGuiduuid0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
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
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        Guiduuid0M.AssertModel(models[16],_testData[30], false);
                        Guiduuid0M.AssertModel(models[17],_testData[31], false);
                        Guiduuid0M.AssertModel(models[18],_testData[32], false);
                        Guiduuid0M.AssertModel(models[19],_testData[33], false);
                        Guiduuid0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduuid0M.AssertModel(models[0],_testData[11], false);
                        Guiduuid0M.AssertModel(models[1],_testData[12], false);
                        Guiduuid0M.AssertModel(models[2],_testData[13], false);
                        Guiduuid0M.AssertModel(models[3],_testData[14], false);
                        Guiduuid0M.AssertModel(models[4],_testData[15], false);
                        Guiduuid0M.AssertModel(models[5],_testData[16], false);
                        Guiduuid0M.AssertModel(models[6],_testData[17], false);
                        Guiduuid0M.AssertModel(models[7],_testData[18], false);
                        Guiduuid0M.AssertModel(models[8],_testData[19], false);
                        Guiduuid0M.AssertModel(models[9],_testData[20], false);
                        Guiduuid0M.AssertModel(models[10],_testData[21], false);
                        Guiduuid0M.AssertModel(models[11],_testData[22], false);
                        Guiduuid0M.AssertModel(models[12],_testData[23], false);
                        Guiduuid0M.AssertModel(models[13],_testData[24], false);
                        Guiduuid0M.AssertModel(models[14],_testData[25], false);
                        Guiduuid0M.AssertModel(models[15],_testData[26], false);
                        Guiduuid0M.AssertModel(models[16],_testData[27], false);
                        Guiduuid0M.AssertModel(models[17],_testData[28], false);
                        Guiduuid0M.AssertModel(models[18],_testData[29], false);
                        Guiduuid0M.AssertModel(models[19],_testData[30], false);
                        Guiduuid0M.AssertModel(models[20],_testData[31], false);
                        Guiduuid0M.AssertModel(models[21],_testData[32], false);
                        Guiduuid0M.AssertModel(models[22],_testData[33], false);
                        Guiduuid0M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 115, 63))
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
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        Guiduuid0M.AssertModel(models[16],_testData[30], false);
                        Guiduuid0M.AssertModel(models[17],_testData[31], false);
                        Guiduuid0M.AssertModel(models[18],_testData[32], false);
                        Guiduuid0M.AssertModel(models[19],_testData[33], false);
                        Guiduuid0M.AssertModel(models[20],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 120);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3082dc3-189b-4366-b2d1-37f485a443ed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8c935462-1fab-40b7-bb99-fccd99461de1"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2feacf0b-2bda-49fe-83ec-d86553299c8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78275fc9-0351-4238-bd62-393785c3a58a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5167bdf6-ee3c-4576-90f2-8e2a1077b818"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ff3881c-a7df-4a47-8b06-157137dd0ea2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8428f560-d3c3-427e-bcaa-529816949e97"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f6ba1e3-397f-45c1-827d-7dd80e9d428d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47f2e56d-0929-4852-ab3b-8a0c751946dd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("08677ba2-01a5-49dc-bfc6-ed6c78473fca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3182533-0e62-4c7b-b43e-2f1eaa15bb3a"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("71359bc5-6fc2-48cc-b233-0c47f37a9ab3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bbb876f2-bd0a-47c3-9429-04d202d2ecf0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1479decb-5b03-465f-8262-11bb8d5ffb3d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7dba44b4-6d57-4a83-a6e8-a4410f007083"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("153211be-9c67-4cf6-81e8-9c827af83669"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ddcac167-5e42-4ec0-8014-edcd304ade0d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("31f569c3-481e-4b32-a6fc-4543dfe6e0bf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4a8cc83f-aed3-46c6-8b84-7f4d38bbede6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("678ebec2-b44c-47dd-ba15-6bad90fb875c"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8aefc51-198e-4da3-a198-e4d3e2cfc103"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dcd29a06-4bde-484b-9d3d-899f2882f2ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b3f82149-5e38-44eb-b1dc-9724359db11d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef0a98fe-5334-4282-a006-3872bab26568"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70a12165-7c38-4196-8662-6448553eac95"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f6893666-c0ab-4117-b523-32cee8748513"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("688164af-9e3c-4aca-9cc5-2a10a7343aed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a09de9e-f503-4a69-b302-1d2fd931c4c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d50d9fb-0699-48bb-8653-290b8e327c61"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e171233b-25f8-4161-b084-857e24bc039a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8667876a-ae60-483f-8e05-a6880faed7b3"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e030e704-fc35-4a82-8f70-e98d15811cbe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("077e90e6-9d5a-4120-b1f0-bf74946031f8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ecc0f55b-2017-4580-a901-7668afe03c81"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c8399a4-c4ba-4e1d-ba2c-88da16c034c1"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c69e9d78-5893-4dc1-89f1-9b094b973999"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("961bbf0a-afa6-49d6-bc8c-176a6b55be78"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("86012ad3-d554-46dd-8403-1ddb94c846d0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35dce035-523b-4bbc-b1ac-269d6ff1f593"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("512f8988-7988-4072-86af-372ee2eb6d24"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74feac23-e900-4e94-a1d4-df5ff5ff93f4"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57376114-a42e-4419-bee9-24d37edd4bd9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fae43330-8b64-4f67-b8f5-e676c1156cf3"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("50ceacde-14cf-4d41-942f-1b943bc225a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2c5029b-8662-4205-a8f2-774631be6351"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8e56ccd-7d2b-4a4c-9bb5-8ec0bf0e3c62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7fb51d9e-248e-47cb-8d05-5afce21ce658"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cd14c8f5-5d9d-42ef-9a7c-427b94b299d7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1a9a815f-9412-4b67-9c59-dfaf6b8ac301"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e10316e1-f570-4405-98af-392ba56e2f06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4b0a9e84-03e5-42b0-a163-f4818926270e"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a4d4818-778d-46fc-8383-a89d09fe4afe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7ef6af4e-1e5a-4522-8624-6b9b336c9d9e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("acd6585e-bbf9-4045-857a-44af8083055a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e91dd78d-e805-4c0a-a9ba-b930b4050cef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2be80ac3-004a-4ffa-9c9d-ff08c27d5860"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6da70a17-6573-4248-b209-a6aea1e973e9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("75595057-3795-451b-921d-8fa23746387c"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0043eef6-bfa9-4579-a5d7-661361d431a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9231fc33-64c3-4496-accb-9af2ad1a4cea"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8635f44-c375-4157-84cd-b40514384a9d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ccf0ab80-1d3f-45fd-999c-21884962cfe7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("32048fc9-67f4-4e5e-804f-3b94bf9581f6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf1373ae-5268-4e7b-b131-d6bf26ab1818"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("934e5574-f097-4deb-b9fd-95b3c059c357"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e861123-6c35-4dd7-b5db-9be639d50801"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b7be312-2f49-467b-9f2f-87554294ecaa"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("601b0f1f-5a48-4ad0-82cd-03bfed0f0fa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c3170622-affb-4796-99f3-47fb066516f6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9266800d-c682-4c8c-99c9-5fd2c111bb62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("abd30aff-5c61-4e42-be85-ea2fc4070f53"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad7ab838-4230-4a54-bc32-ca745522e22b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("077346e5-b5dc-4c3e-a9a4-b0c874a984af"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5161347c-c2e3-4633-baac-8990fc2e1bc1"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9beccfbd-f803-43c8-ac89-4ed7b8c62e92"))));//Value

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e3082dc3-189b-4366-b2d1-37f485a443ed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8c935462-1fab-40b7-bb99-fccd99461de1"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2feacf0b-2bda-49fe-83ec-d86553299c8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("78275fc9-0351-4238-bd62-393785c3a58a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5167bdf6-ee3c-4576-90f2-8e2a1077b818"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ff3881c-a7df-4a47-8b06-157137dd0ea2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8428f560-d3c3-427e-bcaa-529816949e97"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f6ba1e3-397f-45c1-827d-7dd80e9d428d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47f2e56d-0929-4852-ab3b-8a0c751946dd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("08677ba2-01a5-49dc-bfc6-ed6c78473fca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3182533-0e62-4c7b-b43e-2f1eaa15bb3a"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("71359bc5-6fc2-48cc-b233-0c47f37a9ab3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bbb876f2-bd0a-47c3-9429-04d202d2ecf0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1479decb-5b03-465f-8262-11bb8d5ffb3d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7dba44b4-6d57-4a83-a6e8-a4410f007083"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("153211be-9c67-4cf6-81e8-9c827af83669"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ddcac167-5e42-4ec0-8014-edcd304ade0d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("31f569c3-481e-4b32-a6fc-4543dfe6e0bf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4a8cc83f-aed3-46c6-8b84-7f4d38bbede6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("678ebec2-b44c-47dd-ba15-6bad90fb875c"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8aefc51-198e-4da3-a198-e4d3e2cfc103"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dcd29a06-4bde-484b-9d3d-899f2882f2ef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b3f82149-5e38-44eb-b1dc-9724359db11d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef0a98fe-5334-4282-a006-3872bab26568"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70a12165-7c38-4196-8662-6448553eac95"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f6893666-c0ab-4117-b523-32cee8748513"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("688164af-9e3c-4aca-9cc5-2a10a7343aed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3a09de9e-f503-4a69-b302-1d2fd931c4c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d50d9fb-0699-48bb-8653-290b8e327c61"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e171233b-25f8-4161-b084-857e24bc039a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8667876a-ae60-483f-8e05-a6880faed7b3"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e030e704-fc35-4a82-8f70-e98d15811cbe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("077e90e6-9d5a-4120-b1f0-bf74946031f8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ecc0f55b-2017-4580-a901-7668afe03c81"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c8399a4-c4ba-4e1d-ba2c-88da16c034c1"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c69e9d78-5893-4dc1-89f1-9b094b973999"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("961bbf0a-afa6-49d6-bc8c-176a6b55be78"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("86012ad3-d554-46dd-8403-1ddb94c846d0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35dce035-523b-4bbc-b1ac-269d6ff1f593"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("512f8988-7988-4072-86af-372ee2eb6d24"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74feac23-e900-4e94-a1d4-df5ff5ff93f4"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57376114-a42e-4419-bee9-24d37edd4bd9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fae43330-8b64-4f67-b8f5-e676c1156cf3"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("50ceacde-14cf-4d41-942f-1b943bc225a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a2c5029b-8662-4205-a8f2-774631be6351"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8e56ccd-7d2b-4a4c-9bb5-8ec0bf0e3c62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7fb51d9e-248e-47cb-8d05-5afce21ce658"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cd14c8f5-5d9d-42ef-9a7c-427b94b299d7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1a9a815f-9412-4b67-9c59-dfaf6b8ac301"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e10316e1-f570-4405-98af-392ba56e2f06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4b0a9e84-03e5-42b0-a163-f4818926270e"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a4d4818-778d-46fc-8383-a89d09fe4afe"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7ef6af4e-1e5a-4522-8624-6b9b336c9d9e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("acd6585e-bbf9-4045-857a-44af8083055a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e91dd78d-e805-4c0a-a9ba-b930b4050cef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2be80ac3-004a-4ffa-9c9d-ff08c27d5860"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6da70a17-6573-4248-b209-a6aea1e973e9"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("75595057-3795-451b-921d-8fa23746387c"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0043eef6-bfa9-4579-a5d7-661361d431a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9231fc33-64c3-4496-accb-9af2ad1a4cea"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c8635f44-c375-4157-84cd-b40514384a9d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ccf0ab80-1d3f-45fd-999c-21884962cfe7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("32048fc9-67f4-4e5e-804f-3b94bf9581f6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf1373ae-5268-4e7b-b131-d6bf26ab1818"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("934e5574-f097-4deb-b9fd-95b3c059c357"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e861123-6c35-4dd7-b5db-9be639d50801"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9b7be312-2f49-467b-9f2f-87554294ecaa"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("601b0f1f-5a48-4ad0-82cd-03bfed0f0fa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c3170622-affb-4796-99f3-47fb066516f6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9266800d-c682-4c8c-99c9-5fd2c111bb62"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("abd30aff-5c61-4e42-be85-ea2fc4070f53"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad7ab838-4230-4a54-bc32-ca745522e22b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("077346e5-b5dc-4c3e-a9a4-b0c874a984af"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5161347c-c2e3-4633-baac-8990fc2e1bc1"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9beccfbd-f803-43c8-ac89-4ed7b8c62e92"))));//Value

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

