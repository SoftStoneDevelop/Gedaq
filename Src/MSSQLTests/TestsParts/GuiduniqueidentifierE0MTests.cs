

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidSingleTypeuniqueidentifier
    {
    }
    
    internal partial class GuidSingleTypeuniqueidentifier : IGuidSingleTypeuniqueidentifier
    {


#region TestData

        private readonly GuiduniqueidentifierE0M[] _testData = new GuiduniqueidentifierE0M[]
        {
            new GuiduniqueidentifierE0M
{
    Id = 1,
    Value = Guid.Parse("dee2ad4d-40f7-4c5f-92ac-b5a8dbc48209"),
    ModelInner = null,
    NullableValue = Guid.Parse("3aa353e9-97b4-4047-a3b9-93193bc569c4"),
},
            new GuiduniqueidentifierE0M
{
    Id = 4,
    Value = Guid.Parse("7b5c3f47-e629-43f4-b06e-9662b0380634"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 8,
    Value = Guid.Parse("a1a92259-7700-4add-8491-d19603592556"),
    NullableValue = Guid.Parse("7ac2f0eb-7b79-4a96-b40e-ca9a98b0ad4d"),
},
    NullableValue = Guid.Parse("ac32f9df-c6c5-4aa4-9e52-de21462efbdb"),
},
            new GuiduniqueidentifierE0M
{
    Id = 10,
    Value = Guid.Parse("d493ce05-0451-4121-a505-3de5df9c5a5d"),
    ModelInner = null,
    NullableValue = Guid.Parse("99d5f1fc-31bb-489c-a638-3fcb9464e1c6"),
},
            new GuiduniqueidentifierE0M
{
    Id = 19,
    Value = Guid.Parse("3b1c24bd-d8eb-4bce-a53f-0cfe2990909f"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 16,
    Value = Guid.Parse("c5b25885-030a-4f4f-90be-b89cf41396d2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 27,
    Value = Guid.Parse("f97b9d00-010f-460d-be5c-657a55aef034"),
    ModelInner = null,
    NullableValue = Guid.Parse("edd12d59-f09e-4b40-804f-f015cae7ee22"),
},
            new GuiduniqueidentifierE0M
{
    Id = 29,
    Value = Guid.Parse("cc36bff3-0d16-44e1-b809-19085c4b7b3b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 19,
    Value = Guid.Parse("ad1871d5-4798-49d7-a50e-eba8bad809eb"),
    NullableValue = Guid.Parse("a4f6664d-8d99-4d10-921a-fdba8c9ed930"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 37,
    Value = Guid.Parse("ccd6a81e-f1c4-42c1-afa0-b5491eb020c8"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 42,
    Value = Guid.Parse("ca47ab8d-9f45-4fca-b47d-95063c903e51"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 26,
    Value = Guid.Parse("74aaf201-698e-4cc6-b2b2-901af735cefa"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("2ade3905-360c-4083-9f56-c7f38a3809da"),
},
            new GuiduniqueidentifierE0M
{
    Id = 45,
    Value = Guid.Parse("5a03da04-1cc0-42a5-b05e-db927f123fa8"),
    ModelInner = null,
    NullableValue = Guid.Parse("05101558-cc22-4749-93b7-c59beb040ac2"),
},
            new GuiduniqueidentifierE0M
{
    Id = 48,
    Value = Guid.Parse("b6e1e4e5-9986-4d94-b990-efbedc7c8aca"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 32,
    Value = Guid.Parse("5b0936cf-2f98-4584-b3bd-b75af06eeddb"),
    NullableValue = Guid.Parse("56631aa0-6cbc-4011-807e-32dbb668b6b1"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 56,
    Value = Guid.Parse("e286402d-15c6-404c-aaf0-8b2e215688a2"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 61,
    Value = Guid.Parse("0944e52b-af0c-428e-b3c6-caa837b8e000"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 36,
    Value = Guid.Parse("3655a0c7-f5e6-4f02-abb5-ed4dfa7a2254"),
    NullableValue = Guid.Parse("491de342-9dfc-4dc6-b3e8-c3ea2ebb15d5"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 68,
    Value = Guid.Parse("c9a519db-ebae-4b97-bdc4-ec19d6a6b949"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 70,
    Value = Guid.Parse("0aeeb054-bf3d-410e-a996-445447660e71"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 38,
    Value = Guid.Parse("d0d6633e-f3bf-4e65-9404-c3751eff7e91"),
    NullableValue = Guid.Parse("b52fdc34-c535-47d2-8dd0-0bbc3efb31ca"),
},
    NullableValue = Guid.Parse("874af915-6d74-4879-a4e5-89518578336a"),
},
            new GuiduniqueidentifierE0M
{
    Id = 74,
    Value = Guid.Parse("320fb675-c250-4477-83f1-f0e8487bdddb"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 80,
    Value = Guid.Parse("99921d84-4d4f-4fd3-a423-2636818927d3"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 43,
    Value = Guid.Parse("990adfec-7ad9-4939-a6a6-69eb882adf3f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 87,
    Value = Guid.Parse("60ceeb51-f010-4315-a41a-5e8ed27e8d96"),
    ModelInner = null,
    NullableValue = Guid.Parse("4fdf64a5-1c84-41f1-a152-03895548d71f"),
},
            new GuiduniqueidentifierE0M
{
    Id = 88,
    Value = Guid.Parse("729cba1c-05b3-4e69-8ea9-9c63366fcac9"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 46,
    Value = Guid.Parse("a8de8f3c-eb21-4084-85c5-314abca76065"),
    NullableValue = Guid.Parse("49e4cae1-6ae4-4e0c-b9da-6bc4b5d49347"),
},
    NullableValue = Guid.Parse("8793bc29-3dd6-4464-8433-01466e757134"),
},
            new GuiduniqueidentifierE0M
{
    Id = 89,
    Value = Guid.Parse("f16c0b48-83ca-46a8-8d96-1f515b35d421"),
    ModelInner = null,
    NullableValue = Guid.Parse("9fe0b45a-97d8-45f7-a2fb-77a1a077df62"),
},
            new GuiduniqueidentifierE0M
{
    Id = 90,
    Value = Guid.Parse("a6d7080f-0ca3-42c1-891c-c543d79339be"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 51,
    Value = Guid.Parse("cc32607c-7b34-48d8-8e5c-9d705d05a856"),
    NullableValue = Guid.Parse("4c90a42d-79db-4644-b182-27f57ccf324a"),
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 94,
    Value = Guid.Parse("7c6647e4-f632-4bcb-9dbb-d55bed36630b"),
    ModelInner = null,
    NullableValue = Guid.Parse("4dde5a0c-f85b-4d6f-ab16-6398b117bd67"),
},
            new GuiduniqueidentifierE0M
{
    Id = 96,
    Value = Guid.Parse("2b74847b-32ea-4696-87cd-6e6f015f5e2e"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 59,
    Value = Guid.Parse("da2d0af7-f3a0-40ad-a2c8-6aff4e805b07"),
    NullableValue = Guid.Parse("49d71318-704d-432c-9c8f-a87d68293ba5"),
},
    NullableValue = Guid.Parse("21b6d4d4-83bd-4531-b6d0-fc11e0b7dedc"),
},
            new GuiduniqueidentifierE0M
{
    Id = 102,
    Value = Guid.Parse("e86cb41b-6e7e-4944-a68c-20b5ee0ce223"),
    ModelInner = null,
    NullableValue = Guid.Parse("a8f3453b-a2aa-4e23-a270-1d1404f5677e"),
},
            new GuiduniqueidentifierE0M
{
    Id = 103,
    Value = Guid.Parse("e44d067a-5998-424a-a006-207d04fe7892"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 61,
    Value = Guid.Parse("dc72ce0e-d243-40a0-9ec6-1e9cd7154799"),
    NullableValue = Guid.Parse("5deb0713-e5c7-453d-8e2f-1493cc87c1bf"),
},
    NullableValue = Guid.Parse("1ba21971-a7ae-400a-9599-d68490016b2f"),
},
            new GuiduniqueidentifierE0M
{
    Id = 107,
    Value = Guid.Parse("83f59583-d3c9-4cd1-96f1-9dc1dde747ce"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 110,
    Value = Guid.Parse("0e52eb01-74bc-4a28-97c3-430726da98fd"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 63,
    Value = Guid.Parse("e534f980-84fb-44ef-8dec-8269a894f8db"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 116,
    Value = Guid.Parse("e53e17b7-4882-49d1-b929-903254badbf2"),
    ModelInner = null,
    NullableValue = Guid.Parse("7c4c2f13-6313-485a-8fb3-57c519dd4c73"),
},
            new GuiduniqueidentifierE0M
{
    Id = 122,
    Value = Guid.Parse("82125e83-5021-4422-97ee-d1d45ea58e5b"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 69,
    Value = Guid.Parse("47f6c6ce-87be-4eff-b0a4-13ce484b45c5"),
    NullableValue = Guid.Parse("4ce4f262-2f85-4f73-bace-01e6a675c4c4"),
},
    NullableValue = Guid.Parse("a6a48281-2b3e-4022-ba85-fb3b1878a489"),
},
            new GuiduniqueidentifierE0M
{
    Id = 123,
    Value = Guid.Parse("c24f91a2-b1f9-4bbd-bd36-53e7dfcac9be"),
    ModelInner = null,
    NullableValue = Guid.Parse("4fcc8151-d5a1-4c98-abeb-e742413dd766"),
},
            new GuiduniqueidentifierE0M
{
    Id = 127,
    Value = Guid.Parse("8ae580d6-82fd-4dbe-9874-7270594192e5"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 72,
    Value = Guid.Parse("110c948e-2922-4349-b8d2-ceca14ee9094"),
    NullableValue = Guid.Parse("1247512f-9ac8-43d9-bb97-606256f129ed"),
},
    NullableValue = Guid.Parse("78d373a1-afac-4113-b139-dcc6988aed22"),
},
            new GuiduniqueidentifierE0M
{
    Id = 134,
    Value = Guid.Parse("7e9e3724-c391-4a5c-a178-70715bb2427e"),
    ModelInner = null,
    NullableValue = Guid.Parse("7e716b3b-4b31-41b4-9366-c96fdd200873"),
},
            new GuiduniqueidentifierE0M
{
    Id = 141,
    Value = Guid.Parse("78f66cea-46c9-437f-98d6-a641d9bc5faa"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 77,
    Value = Guid.Parse("2b7503fd-1eda-4505-b855-bc4d7829543f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduniqueidentifierE0M
{
    Id = 146,
    Value = Guid.Parse("67fe9087-431c-4b11-9314-2fdc121d2876"),
    ModelInner = null,
    NullableValue = Guid.Parse("1dcb9ff9-1397-4f63-9f85-413d4a65a370"),
},
            new GuiduniqueidentifierE0M
{
    Id = 152,
    Value = Guid.Parse("8c147493-dc3c-42f3-b728-6b3d97caf537"),
    ModelInner = new GuiduniqueidentifierE0MI
{
    Id = 84,
    Value = Guid.Parse("74d0720b-e831-44a3-b356-23beedb66ca5"),
    NullableValue = Guid.Parse("a05955f6-c30e-4b23-be8b-09297753701c"),
},
    NullableValue = Guid.Parse("701ba1d0-9c7d-4a1f-be5b-ba3805c614f7"),
},
            new GuiduniqueidentifierE0M
{
    Id = 160,
    Value = Guid.Parse("1a3cc958-12ab-43b8-8c1e-58a371c2c9df"),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(14))
            ]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)9),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)9, 
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifiere0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifiere0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(14),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifiere0mi_id", 
                methodParametrName: "guiduniqueidentifiere0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
                nullable: true)]
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifiere0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifiere0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifiere0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Guid), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)9),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)9,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifiere0mi_id", 
                methodParametrName: "guiduniqueidentifiere0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidSingleTypeuniqueidentifier)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuniqueidentifier)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M), typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 10, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifierE0M>();
                var models2 = new List<FlatGuiduniqueidentifierE0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduniqueidentifierE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 110, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 87, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduniqueidentifierE0M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(models[30],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
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
FROM dbo.guiduniqueidentifiere0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifierE0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifierE0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduniqueidentifierE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduniqueidentifierE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
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
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[2], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[3], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[4], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[5], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[6], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[7], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[8], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[9], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[25],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[26],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[27],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[28],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[29],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[30],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[31],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[10], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[11], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[12], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[13], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[14], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[15], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[16], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[17], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[18], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[19], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[15],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[16],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[17],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[18],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[19],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[20],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[21],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[22],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[23],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[24],_testData[34], false);
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
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduniqueidentifierE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 110, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduniqueidentifierE0M.AssertModel(models[0],_testData[20], false);
                        GuiduniqueidentifierE0M.AssertModel(models[1],_testData[21], false);
                        GuiduniqueidentifierE0M.AssertModel(models[2],_testData[22], false);
                        GuiduniqueidentifierE0M.AssertModel(models[3],_testData[23], false);
                        GuiduniqueidentifierE0M.AssertModel(models[4],_testData[24], false);
                        GuiduniqueidentifierE0M.AssertModel(models[5],_testData[25], false);
                        GuiduniqueidentifierE0M.AssertModel(models[6],_testData[26], false);
                        GuiduniqueidentifierE0M.AssertModel(models[7],_testData[27], false);
                        GuiduniqueidentifierE0M.AssertModel(models[8],_testData[28], false);
                        GuiduniqueidentifierE0M.AssertModel(models[9],_testData[29], false);
                        GuiduniqueidentifierE0M.AssertModel(models[10],_testData[30], false);
                        GuiduniqueidentifierE0M.AssertModel(models[11],_testData[31], false);
                        GuiduniqueidentifierE0M.AssertModel(models[12],_testData[32], false);
                        GuiduniqueidentifierE0M.AssertModel(models[13],_testData[33], false);
                        GuiduniqueidentifierE0M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[1], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[2], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[3], false);
                GuiduniqueidentifierE0M.AssertModel(models[3],_testData[4], false);
                GuiduniqueidentifierE0M.AssertModel(models[4],_testData[5], false);
                GuiduniqueidentifierE0M.AssertModel(models[5],_testData[6], false);
                GuiduniqueidentifierE0M.AssertModel(models[6],_testData[7], false);
                GuiduniqueidentifierE0M.AssertModel(models[7],_testData[8], false);
                GuiduniqueidentifierE0M.AssertModel(models[8],_testData[9], false);
                GuiduniqueidentifierE0M.AssertModel(models[9],_testData[10], false);
                GuiduniqueidentifierE0M.AssertModel(models[10],_testData[11], false);
                GuiduniqueidentifierE0M.AssertModel(models[11],_testData[12], false);
                GuiduniqueidentifierE0M.AssertModel(models[12],_testData[13], false);
                GuiduniqueidentifierE0M.AssertModel(models[13],_testData[14], false);
                GuiduniqueidentifierE0M.AssertModel(models[14],_testData[15], false);
                GuiduniqueidentifierE0M.AssertModel(models[15],_testData[16], false);
                GuiduniqueidentifierE0M.AssertModel(models[16],_testData[17], false);
                GuiduniqueidentifierE0M.AssertModel(models[17],_testData[18], false);
                GuiduniqueidentifierE0M.AssertModel(models[18],_testData[19], false);
                GuiduniqueidentifierE0M.AssertModel(models[19],_testData[20], false);
                GuiduniqueidentifierE0M.AssertModel(models[20],_testData[21], false);
                GuiduniqueidentifierE0M.AssertModel(models[21],_testData[22], false);
                GuiduniqueidentifierE0M.AssertModel(models[22],_testData[23], false);
                GuiduniqueidentifierE0M.AssertModel(models[23],_testData[24], false);
                GuiduniqueidentifierE0M.AssertModel(models[24],_testData[25], false);
                GuiduniqueidentifierE0M.AssertModel(models[25],_testData[26], false);
                GuiduniqueidentifierE0M.AssertModel(models[26],_testData[27], false);
                GuiduniqueidentifierE0M.AssertModel(models[27],_testData[28], false);
                GuiduniqueidentifierE0M.AssertModel(models[28],_testData[29], false);
                GuiduniqueidentifierE0M.AssertModel(models[29],_testData[30], false);
                GuiduniqueidentifierE0M.AssertModel(models[30],_testData[31], false);
                GuiduniqueidentifierE0M.AssertModel(models[31],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[32],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                GuiduniqueidentifierE0M.AssertModel(models[0],_testData[32], false);
                GuiduniqueidentifierE0M.AssertModel(models[1],_testData[33], false);
                GuiduniqueidentifierE0M.AssertModel(models[2],_testData[34], false);
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
FROM dbo.guiduniqueidentifiere0m m
LEFT JOIN dbo.guiduniqueidentifiere0mi mi ON mi.id = m.guiduniqueidentifiere0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dee2ad4d-40f7-4c5f-92ac-b5a8dbc48209"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3aa353e9-97b4-4047-a3b9-93193bc569c4"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b5c3f47-e629-43f4-b06e-9662b0380634"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1a92259-7700-4add-8491-d19603592556"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7ac2f0eb-7b79-4a96-b40e-ca9a98b0ad4d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ac32f9df-c6c5-4aa4-9e52-de21462efbdb"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d493ce05-0451-4121-a505-3de5df9c5a5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99d5f1fc-31bb-489c-a638-3fcb9464e1c6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b1c24bd-d8eb-4bce-a53f-0cfe2990909f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c5b25885-030a-4f4f-90be-b89cf41396d2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f97b9d00-010f-460d-be5c-657a55aef034"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("edd12d59-f09e-4b40-804f-f015cae7ee22"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc36bff3-0d16-44e1-b809-19085c4b7b3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ad1871d5-4798-49d7-a50e-eba8bad809eb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a4f6664d-8d99-4d10-921a-fdba8c9ed930"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccd6a81e-f1c4-42c1-afa0-b5491eb020c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca47ab8d-9f45-4fca-b47d-95063c903e51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74aaf201-698e-4cc6-b2b2-901af735cefa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ade3905-360c-4083-9f56-c7f38a3809da"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a03da04-1cc0-42a5-b05e-db927f123fa8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("05101558-cc22-4749-93b7-c59beb040ac2"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6e1e4e5-9986-4d94-b990-efbedc7c8aca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b0936cf-2f98-4584-b3bd-b75af06eeddb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("56631aa0-6cbc-4011-807e-32dbb668b6b1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e286402d-15c6-404c-aaf0-8b2e215688a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0944e52b-af0c-428e-b3c6-caa837b8e000"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3655a0c7-f5e6-4f02-abb5-ed4dfa7a2254"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("491de342-9dfc-4dc6-b3e8-c3ea2ebb15d5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a519db-ebae-4b97-bdc4-ec19d6a6b949"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0aeeb054-bf3d-410e-a996-445447660e71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0d6633e-f3bf-4e65-9404-c3751eff7e91"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b52fdc34-c535-47d2-8dd0-0bbc3efb31ca"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("874af915-6d74-4879-a4e5-89518578336a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("320fb675-c250-4477-83f1-f0e8487bdddb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99921d84-4d4f-4fd3-a423-2636818927d3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("990adfec-7ad9-4939-a6a6-69eb882adf3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("60ceeb51-f010-4315-a41a-5e8ed27e8d96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4fdf64a5-1c84-41f1-a152-03895548d71f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("729cba1c-05b3-4e69-8ea9-9c63366fcac9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a8de8f3c-eb21-4084-85c5-314abca76065"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("49e4cae1-6ae4-4e0c-b9da-6bc4b5d49347"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8793bc29-3dd6-4464-8433-01466e757134"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f16c0b48-83ca-46a8-8d96-1f515b35d421"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9fe0b45a-97d8-45f7-a2fb-77a1a077df62"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6d7080f-0ca3-42c1-891c-c543d79339be"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cc32607c-7b34-48d8-8e5c-9d705d05a856"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4c90a42d-79db-4644-b182-27f57ccf324a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c6647e4-f632-4bcb-9dbb-d55bed36630b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4dde5a0c-f85b-4d6f-ab16-6398b117bd67"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2b74847b-32ea-4696-87cd-6e6f015f5e2e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da2d0af7-f3a0-40ad-a2c8-6aff4e805b07"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("49d71318-704d-432c-9c8f-a87d68293ba5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21b6d4d4-83bd-4531-b6d0-fc11e0b7dedc"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e86cb41b-6e7e-4944-a68c-20b5ee0ce223"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8f3453b-a2aa-4e23-a270-1d1404f5677e"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e44d067a-5998-424a-a006-207d04fe7892"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc72ce0e-d243-40a0-9ec6-1e9cd7154799"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5deb0713-e5c7-453d-8e2f-1493cc87c1bf"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ba21971-a7ae-400a-9599-d68490016b2f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83f59583-d3c9-4cd1-96f1-9dc1dde747ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e52eb01-74bc-4a28-97c3-430726da98fd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e534f980-84fb-44ef-8dec-8269a894f8db"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e53e17b7-4882-49d1-b929-903254badbf2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7c4c2f13-6313-485a-8fb3-57c519dd4c73"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("82125e83-5021-4422-97ee-d1d45ea58e5b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47f6c6ce-87be-4eff-b0a4-13ce484b45c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4ce4f262-2f85-4f73-bace-01e6a675c4c4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6a48281-2b3e-4022-ba85-fb3b1878a489"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c24f91a2-b1f9-4bbd-bd36-53e7dfcac9be"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4fcc8151-d5a1-4c98-abeb-e742413dd766"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ae580d6-82fd-4dbe-9874-7270594192e5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("110c948e-2922-4349-b8d2-ceca14ee9094"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1247512f-9ac8-43d9-bb97-606256f129ed"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("78d373a1-afac-4113-b139-dcc6988aed22"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e9e3724-c391-4a5c-a178-70715bb2427e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7e716b3b-4b31-41b4-9366-c96fdd200873"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78f66cea-46c9-437f-98d6-a641d9bc5faa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b7503fd-1eda-4505-b855-bc4d7829543f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67fe9087-431c-4b11-9314-2fdc121d2876"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1dcb9ff9-1397-4f63-9f85-413d4a65a370"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8c147493-dc3c-42f3-b728-6b3d97caf537"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74d0720b-e831-44a3-b356-23beedb66ca5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a05955f6-c30e-4b23-be8b-09297753701c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("701ba1d0-9c7d-4a1f-be5b-ba3805c614f7"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a3cc958-12ab-43b8-8c1e-58a371c2c9df"))));//Value

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
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dee2ad4d-40f7-4c5f-92ac-b5a8dbc48209"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3aa353e9-97b4-4047-a3b9-93193bc569c4"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b5c3f47-e629-43f4-b06e-9662b0380634"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1a92259-7700-4add-8491-d19603592556"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7ac2f0eb-7b79-4a96-b40e-ca9a98b0ad4d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ac32f9df-c6c5-4aa4-9e52-de21462efbdb"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d493ce05-0451-4121-a505-3de5df9c5a5d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99d5f1fc-31bb-489c-a638-3fcb9464e1c6"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3b1c24bd-d8eb-4bce-a53f-0cfe2990909f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c5b25885-030a-4f4f-90be-b89cf41396d2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f97b9d00-010f-460d-be5c-657a55aef034"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("edd12d59-f09e-4b40-804f-f015cae7ee22"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc36bff3-0d16-44e1-b809-19085c4b7b3b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ad1871d5-4798-49d7-a50e-eba8bad809eb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a4f6664d-8d99-4d10-921a-fdba8c9ed930"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccd6a81e-f1c4-42c1-afa0-b5491eb020c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ca47ab8d-9f45-4fca-b47d-95063c903e51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74aaf201-698e-4cc6-b2b2-901af735cefa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ade3905-360c-4083-9f56-c7f38a3809da"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a03da04-1cc0-42a5-b05e-db927f123fa8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("05101558-cc22-4749-93b7-c59beb040ac2"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6e1e4e5-9986-4d94-b990-efbedc7c8aca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5b0936cf-2f98-4584-b3bd-b75af06eeddb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("56631aa0-6cbc-4011-807e-32dbb668b6b1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e286402d-15c6-404c-aaf0-8b2e215688a2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0944e52b-af0c-428e-b3c6-caa837b8e000"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3655a0c7-f5e6-4f02-abb5-ed4dfa7a2254"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("491de342-9dfc-4dc6-b3e8-c3ea2ebb15d5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a519db-ebae-4b97-bdc4-ec19d6a6b949"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0aeeb054-bf3d-410e-a996-445447660e71"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0d6633e-f3bf-4e65-9404-c3751eff7e91"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b52fdc34-c535-47d2-8dd0-0bbc3efb31ca"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("874af915-6d74-4879-a4e5-89518578336a"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("320fb675-c250-4477-83f1-f0e8487bdddb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99921d84-4d4f-4fd3-a423-2636818927d3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("990adfec-7ad9-4939-a6a6-69eb882adf3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("60ceeb51-f010-4315-a41a-5e8ed27e8d96"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4fdf64a5-1c84-41f1-a152-03895548d71f"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("729cba1c-05b3-4e69-8ea9-9c63366fcac9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a8de8f3c-eb21-4084-85c5-314abca76065"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("49e4cae1-6ae4-4e0c-b9da-6bc4b5d49347"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8793bc29-3dd6-4464-8433-01466e757134"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f16c0b48-83ca-46a8-8d96-1f515b35d421"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9fe0b45a-97d8-45f7-a2fb-77a1a077df62"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6d7080f-0ca3-42c1-891c-c543d79339be"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cc32607c-7b34-48d8-8e5c-9d705d05a856"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4c90a42d-79db-4644-b182-27f57ccf324a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c6647e4-f632-4bcb-9dbb-d55bed36630b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4dde5a0c-f85b-4d6f-ab16-6398b117bd67"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2b74847b-32ea-4696-87cd-6e6f015f5e2e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da2d0af7-f3a0-40ad-a2c8-6aff4e805b07"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("49d71318-704d-432c-9c8f-a87d68293ba5"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("21b6d4d4-83bd-4531-b6d0-fc11e0b7dedc"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e86cb41b-6e7e-4944-a68c-20b5ee0ce223"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8f3453b-a2aa-4e23-a270-1d1404f5677e"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e44d067a-5998-424a-a006-207d04fe7892"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("dc72ce0e-d243-40a0-9ec6-1e9cd7154799"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5deb0713-e5c7-453d-8e2f-1493cc87c1bf"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ba21971-a7ae-400a-9599-d68490016b2f"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("83f59583-d3c9-4cd1-96f1-9dc1dde747ce"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e52eb01-74bc-4a28-97c3-430726da98fd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e534f980-84fb-44ef-8dec-8269a894f8db"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e53e17b7-4882-49d1-b929-903254badbf2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7c4c2f13-6313-485a-8fb3-57c519dd4c73"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("82125e83-5021-4422-97ee-d1d45ea58e5b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("47f6c6ce-87be-4eff-b0a4-13ce484b45c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4ce4f262-2f85-4f73-bace-01e6a675c4c4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a6a48281-2b3e-4022-ba85-fb3b1878a489"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c24f91a2-b1f9-4bbd-bd36-53e7dfcac9be"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4fcc8151-d5a1-4c98-abeb-e742413dd766"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ae580d6-82fd-4dbe-9874-7270594192e5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("110c948e-2922-4349-b8d2-ceca14ee9094"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("1247512f-9ac8-43d9-bb97-606256f129ed"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("78d373a1-afac-4113-b139-dcc6988aed22"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e9e3724-c391-4a5c-a178-70715bb2427e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7e716b3b-4b31-41b4-9366-c96fdd200873"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("78f66cea-46c9-437f-98d6-a641d9bc5faa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b7503fd-1eda-4505-b855-bc4d7829543f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("67fe9087-431c-4b11-9314-2fdc121d2876"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1dcb9ff9-1397-4f63-9f85-413d4a65a370"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8c147493-dc3c-42f3-b728-6b3d97caf537"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("74d0720b-e831-44a3-b356-23beedb66ca5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a05955f6-c30e-4b23-be8b-09297753701c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("701ba1d0-9c7d-4a1f-be5b-ba3805c614f7"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1a3cc958-12ab-43b8-8c1e-58a371c2c9df"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

