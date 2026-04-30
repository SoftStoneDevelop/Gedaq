

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

        private readonly Guiduniqueidentifier0M[] _testData = new Guiduniqueidentifier0M[]
        {
            new Guiduniqueidentifier0M
{
    Id = 2,
    Value = Guid.Parse("d304310f-d9d5-495e-9bc3-5f2e5f19ef8f"),
    ModelInner = null,
    NullableValue = Guid.Parse("32984941-ff99-4a8c-a3e0-4ed48b618488"),
},
            new Guiduniqueidentifier0M
{
    Id = 3,
    Value = Guid.Parse("02f9da20-cc27-4395-864b-c05565af6289"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 5,
    Value = Guid.Parse("ac34d1b4-a2ed-445e-92b1-908134f04ddf"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("03a6c24b-ce71-4f23-8cf1-745137e96117"),
},
            new Guiduniqueidentifier0M
{
    Id = 10,
    Value = Guid.Parse("e83af9a9-5efc-4ef5-a595-e6468d90f42e"),
    ModelInner = null,
    NullableValue = Guid.Parse("e10ed6ea-92a2-40d6-a5e8-cab9d10b04c4"),
},
            new Guiduniqueidentifier0M
{
    Id = 18,
    Value = Guid.Parse("76fe4152-7f07-49c8-bef7-c40739c98586"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 10,
    Value = Guid.Parse("31c63b62-0096-46a9-97a0-308cd098a457"),
    NullableValue = Guid.Parse("83c898e8-6950-4f53-afd8-d27ef5b5a5c9"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 23,
    Value = Guid.Parse("9a4c41dc-650e-4fe1-8cd8-580445b3e300"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 25,
    Value = Guid.Parse("df04360f-5761-4678-b8dc-9f968501c56e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 18,
    Value = Guid.Parse("50a5d43d-2309-4af4-86b0-63cea83296cf"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("cf61b85c-a03e-4946-869a-bd17d243bb88"),
},
            new Guiduniqueidentifier0M
{
    Id = 34,
    Value = Guid.Parse("fda9721d-7bf8-48d9-a6a2-0e10e789f102"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 38,
    Value = Guid.Parse("76931e21-3036-417a-a56f-bc7af6f6c208"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 22,
    Value = Guid.Parse("6f72f15a-dbc0-4947-ad2d-847f53260a7d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 44,
    Value = Guid.Parse("fe4ac8f8-3d8b-4f4f-9e11-a8169f32fb33"),
    ModelInner = null,
    NullableValue = Guid.Parse("a43fbf39-0f86-43b3-9756-a2577a62b7f9"),
},
            new Guiduniqueidentifier0M
{
    Id = 46,
    Value = Guid.Parse("e92b1a28-31a0-4423-a909-c9859f9e60c9"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 26,
    Value = Guid.Parse("585f36e0-c3f8-412d-aebd-493c10cdfd6a"),
    NullableValue = Guid.Parse("28b17d05-0d69-4967-85b5-3d67a35dcbc6"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 47,
    Value = Guid.Parse("8555f8fb-67a8-4d9c-844e-c1327f72216f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 56,
    Value = Guid.Parse("6ee222f1-d6f3-4780-99f3-a9170bb27458"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("49a697e1-39f4-4cf8-bcd1-d121799bf9b7"),
    NullableValue = Guid.Parse("633abb5c-4ef7-4a9e-861c-6cdd3b707cda"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("40d822bd-9395-42d8-9a98-3ce944fe408f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 64,
    Value = Guid.Parse("52d75979-9786-49b0-8434-0707e87bf6c5"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 31,
    Value = Guid.Parse("a6052538-a044-4e75-89e1-7dc2e89af96f"),
    NullableValue = Guid.Parse("a17facea-4684-4c88-b3a0-77794beb1dcb"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 65,
    Value = Guid.Parse("6776e9f1-dfba-4efd-895a-53a7e682953c"),
    ModelInner = null,
    NullableValue = Guid.Parse("d213f625-1ee9-47fb-a907-e68b20378648"),
},
            new Guiduniqueidentifier0M
{
    Id = 68,
    Value = Guid.Parse("8b42fa6e-8c53-4099-8f80-22708050e77f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 36,
    Value = Guid.Parse("9aea7f9f-d95c-4b83-a7f6-94a4aad574cb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("5c395798-eacb-4eb0-9e4d-6d3d121d8bc7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 81,
    Value = Guid.Parse("7645274e-f97e-4ef0-a263-c8ee0043f2e1"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 45,
    Value = Guid.Parse("c28d5e23-1eaa-40c9-b0b4-22de876e9691"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e98b8fb8-db33-48a9-afde-b0cd26c385fd"),
},
            new Guiduniqueidentifier0M
{
    Id = 84,
    Value = Guid.Parse("672a63ae-eda7-4206-b501-25560e82bf6b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 90,
    Value = Guid.Parse("093630d8-5857-4408-8d71-261051e66710"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 53,
    Value = Guid.Parse("1bf939f0-80bb-4217-84e9-960000557e24"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("84fd3f05-abf2-45b5-b4fb-88208eee83ab"),
},
            new Guiduniqueidentifier0M
{
    Id = 91,
    Value = Guid.Parse("b30a3a68-68ca-4df2-bcb6-74240568d688"),
    ModelInner = null,
    NullableValue = Guid.Parse("7621a36c-1dd7-4686-ab8d-01cccad4134f"),
},
            new Guiduniqueidentifier0M
{
    Id = 93,
    Value = Guid.Parse("b119d1b3-b019-4c87-a1dd-c5bc36022580"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 54,
    Value = Guid.Parse("9399ac93-c73e-4485-b933-82609b622ca9"),
    NullableValue = Guid.Parse("9809d62b-117d-424b-a766-3396e2a0d3e7"),
},
    NullableValue = Guid.Parse("fd784775-1f16-4712-b58a-5f80f001db06"),
},
            new Guiduniqueidentifier0M
{
    Id = 94,
    Value = Guid.Parse("136ad646-00fc-4959-8ecc-76dc0942ea28"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 100,
    Value = Guid.Parse("23a25798-71f0-45d6-bc69-effbef4c9d54"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 55,
    Value = Guid.Parse("19cc98b6-3b50-4bb8-ad0a-779d9d510f2c"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("54d8fb1e-5e3c-49e2-9a97-ca56a38e5537"),
    ModelInner = null,
    NullableValue = Guid.Parse("76dc4019-0984-4864-b918-159a747fa07c"),
},
            new Guiduniqueidentifier0M
{
    Id = 115,
    Value = Guid.Parse("6d2566ac-aba9-4b28-b93a-c70aa88816bc"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("bb7c33bb-1842-45f0-9ded-e623f1e163d6"),
    NullableValue = Guid.Parse("6ddfa000-b145-44f7-956f-5b59519af6c3"),
},
    NullableValue = Guid.Parse("e64d1343-8a61-45d6-be1f-72a3deb4eee8"),
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("5c6725cb-a112-4830-b240-2bbbf39854b7"),
    ModelInner = null,
    NullableValue = Guid.Parse("88c8b43f-5f23-4008-9410-d9f4a419326e"),
},
            new Guiduniqueidentifier0M
{
    Id = 125,
    Value = Guid.Parse("8448d08c-a169-41f5-969c-abfe3b931301"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 62,
    Value = Guid.Parse("e6dcc689-b363-44b3-8482-6e1c718872a8"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a8abe8a5-964f-41e6-b27e-c8974635253e"),
},
            new Guiduniqueidentifier0M
{
    Id = 134,
    Value = Guid.Parse("6f72ced4-f383-4ccc-9523-0e33ff6a2e2a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 139,
    Value = Guid.Parse("46df2deb-8c5a-4aa1-ba21-cc73c5f7cfb0"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 64,
    Value = Guid.Parse("5f65d78c-f58b-488f-83c5-07df7b637db1"),
    NullableValue = Guid.Parse("cf4e8918-9531-464d-a328-7af97e170e2c"),
},
    NullableValue = Guid.Parse("001b20d9-c10a-4cac-9f91-73584d226fe6"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifier0mi(
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
INSERT INTO dbo.guiduniqueidentifier0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.guiduniqueidentifier0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifier0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifier0mi_id
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
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
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
INSERT INTO dbo.guiduniqueidentifier0m(
	id,
    value,
    nullablevalue,
    guiduniqueidentifier0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduniqueidentifier0mi_id
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
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[29], false);
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
                parametr2.Value = 64;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M), typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                await((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduniqueidentifier0M>();
                var models2 = new List<FlatGuiduniqueidentifier0M>();
                ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 2, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var firstItems2 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 34, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 44, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
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
FROM dbo.guiduniqueidentifier0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems1 = new List<FlatGuiduniqueidentifier0M>();
                var secondItems2 = new List<FlatGuiduniqueidentifier0M>();
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guiduniqueidentifier0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 25, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[29], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d304310f-d9d5-495e-9bc3-5f2e5f19ef8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32984941-ff99-4a8c-a3e0-4ed48b618488"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02f9da20-cc27-4395-864b-c05565af6289"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac34d1b4-a2ed-445e-92b1-908134f04ddf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("03a6c24b-ce71-4f23-8cf1-745137e96117"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e83af9a9-5efc-4ef5-a595-e6468d90f42e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e10ed6ea-92a2-40d6-a5e8-cab9d10b04c4"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("76fe4152-7f07-49c8-bef7-c40739c98586"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("31c63b62-0096-46a9-97a0-308cd098a457"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("83c898e8-6950-4f53-afd8-d27ef5b5a5c9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a4c41dc-650e-4fe1-8cd8-580445b3e300"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df04360f-5761-4678-b8dc-9f968501c56e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("50a5d43d-2309-4af4-86b0-63cea83296cf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf61b85c-a03e-4946-869a-bd17d243bb88"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fda9721d-7bf8-48d9-a6a2-0e10e789f102"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("76931e21-3036-417a-a56f-bc7af6f6c208"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6f72f15a-dbc0-4947-ad2d-847f53260a7d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe4ac8f8-3d8b-4f4f-9e11-a8169f32fb33"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a43fbf39-0f86-43b3-9756-a2577a62b7f9"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e92b1a28-31a0-4423-a909-c9859f9e60c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("585f36e0-c3f8-412d-aebd-493c10cdfd6a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("28b17d05-0d69-4967-85b5-3d67a35dcbc6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8555f8fb-67a8-4d9c-844e-c1327f72216f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ee222f1-d6f3-4780-99f3-a9170bb27458"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49a697e1-39f4-4cf8-bcd1-d121799bf9b7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("633abb5c-4ef7-4a9e-861c-6cdd3b707cda"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40d822bd-9395-42d8-9a98-3ce944fe408f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52d75979-9786-49b0-8434-0707e87bf6c5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a6052538-a044-4e75-89e1-7dc2e89af96f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a17facea-4684-4c88-b3a0-77794beb1dcb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6776e9f1-dfba-4efd-895a-53a7e682953c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d213f625-1ee9-47fb-a907-e68b20378648"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b42fa6e-8c53-4099-8f80-22708050e77f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9aea7f9f-d95c-4b83-a7f6-94a4aad574cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c395798-eacb-4eb0-9e4d-6d3d121d8bc7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7645274e-f97e-4ef0-a263-c8ee0043f2e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c28d5e23-1eaa-40c9-b0b4-22de876e9691"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e98b8fb8-db33-48a9-afde-b0cd26c385fd"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("672a63ae-eda7-4206-b501-25560e82bf6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("093630d8-5857-4408-8d71-261051e66710"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1bf939f0-80bb-4217-84e9-960000557e24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("84fd3f05-abf2-45b5-b4fb-88208eee83ab"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b30a3a68-68ca-4df2-bcb6-74240568d688"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7621a36c-1dd7-4686-ab8d-01cccad4134f"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b119d1b3-b019-4c87-a1dd-c5bc36022580"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9399ac93-c73e-4485-b933-82609b622ca9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9809d62b-117d-424b-a766-3396e2a0d3e7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd784775-1f16-4712-b58a-5f80f001db06"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("136ad646-00fc-4959-8ecc-76dc0942ea28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23a25798-71f0-45d6-bc69-effbef4c9d54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19cc98b6-3b50-4bb8-ad0a-779d9d510f2c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54d8fb1e-5e3c-49e2-9a97-ca56a38e5537"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76dc4019-0984-4864-b918-159a747fa07c"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6d2566ac-aba9-4b28-b93a-c70aa88816bc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bb7c33bb-1842-45f0-9ded-e623f1e163d6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6ddfa000-b145-44f7-956f-5b59519af6c3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e64d1343-8a61-45d6-be1f-72a3deb4eee8"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c6725cb-a112-4830-b240-2bbbf39854b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88c8b43f-5f23-4008-9410-d9f4a419326e"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8448d08c-a169-41f5-969c-abfe3b931301"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e6dcc689-b363-44b3-8482-6e1c718872a8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8abe8a5-964f-41e6-b27e-c8974635253e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f72ced4-f383-4ccc-9523-0e33ff6a2e2a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("46df2deb-8c5a-4aa1-ba21-cc73c5f7cfb0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5f65d78c-f58b-488f-83c5-07df7b637db1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cf4e8918-9531-464d-a328-7af97e170e2c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("001b20d9-c10a-4cac-9f91-73584d226fe6"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d304310f-d9d5-495e-9bc3-5f2e5f19ef8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32984941-ff99-4a8c-a3e0-4ed48b618488"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02f9da20-cc27-4395-864b-c05565af6289"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac34d1b4-a2ed-445e-92b1-908134f04ddf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("03a6c24b-ce71-4f23-8cf1-745137e96117"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e83af9a9-5efc-4ef5-a595-e6468d90f42e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e10ed6ea-92a2-40d6-a5e8-cab9d10b04c4"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("76fe4152-7f07-49c8-bef7-c40739c98586"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("31c63b62-0096-46a9-97a0-308cd098a457"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("83c898e8-6950-4f53-afd8-d27ef5b5a5c9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a4c41dc-650e-4fe1-8cd8-580445b3e300"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df04360f-5761-4678-b8dc-9f968501c56e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("50a5d43d-2309-4af4-86b0-63cea83296cf"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cf61b85c-a03e-4946-869a-bd17d243bb88"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fda9721d-7bf8-48d9-a6a2-0e10e789f102"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("76931e21-3036-417a-a56f-bc7af6f6c208"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6f72f15a-dbc0-4947-ad2d-847f53260a7d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe4ac8f8-3d8b-4f4f-9e11-a8169f32fb33"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a43fbf39-0f86-43b3-9756-a2577a62b7f9"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e92b1a28-31a0-4423-a909-c9859f9e60c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("585f36e0-c3f8-412d-aebd-493c10cdfd6a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("28b17d05-0d69-4967-85b5-3d67a35dcbc6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8555f8fb-67a8-4d9c-844e-c1327f72216f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6ee222f1-d6f3-4780-99f3-a9170bb27458"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49a697e1-39f4-4cf8-bcd1-d121799bf9b7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("633abb5c-4ef7-4a9e-861c-6cdd3b707cda"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40d822bd-9395-42d8-9a98-3ce944fe408f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("52d75979-9786-49b0-8434-0707e87bf6c5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a6052538-a044-4e75-89e1-7dc2e89af96f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a17facea-4684-4c88-b3a0-77794beb1dcb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6776e9f1-dfba-4efd-895a-53a7e682953c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d213f625-1ee9-47fb-a907-e68b20378648"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8b42fa6e-8c53-4099-8f80-22708050e77f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9aea7f9f-d95c-4b83-a7f6-94a4aad574cb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c395798-eacb-4eb0-9e4d-6d3d121d8bc7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7645274e-f97e-4ef0-a263-c8ee0043f2e1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c28d5e23-1eaa-40c9-b0b4-22de876e9691"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e98b8fb8-db33-48a9-afde-b0cd26c385fd"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("672a63ae-eda7-4206-b501-25560e82bf6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("093630d8-5857-4408-8d71-261051e66710"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1bf939f0-80bb-4217-84e9-960000557e24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("84fd3f05-abf2-45b5-b4fb-88208eee83ab"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b30a3a68-68ca-4df2-bcb6-74240568d688"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7621a36c-1dd7-4686-ab8d-01cccad4134f"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b119d1b3-b019-4c87-a1dd-c5bc36022580"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9399ac93-c73e-4485-b933-82609b622ca9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9809d62b-117d-424b-a766-3396e2a0d3e7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fd784775-1f16-4712-b58a-5f80f001db06"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("136ad646-00fc-4959-8ecc-76dc0942ea28"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23a25798-71f0-45d6-bc69-effbef4c9d54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("19cc98b6-3b50-4bb8-ad0a-779d9d510f2c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("54d8fb1e-5e3c-49e2-9a97-ca56a38e5537"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("76dc4019-0984-4864-b918-159a747fa07c"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6d2566ac-aba9-4b28-b93a-c70aa88816bc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bb7c33bb-1842-45f0-9ded-e623f1e163d6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6ddfa000-b145-44f7-956f-5b59519af6c3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e64d1343-8a61-45d6-be1f-72a3deb4eee8"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5c6725cb-a112-4830-b240-2bbbf39854b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("88c8b43f-5f23-4008-9410-d9f4a419326e"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8448d08c-a169-41f5-969c-abfe3b931301"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e6dcc689-b363-44b3-8482-6e1c718872a8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8abe8a5-964f-41e6-b27e-c8974635253e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f72ced4-f383-4ccc-9523-0e33ff6a2e2a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("46df2deb-8c5a-4aa1-ba21-cc73c5f7cfb0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5f65d78c-f58b-488f-83c5-07df7b637db1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cf4e8918-9531-464d-a328-7af97e170e2c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("001b20d9-c10a-4cac-9f91-73584d226fe6"))));

            }
        }

#endregion

    }
}

