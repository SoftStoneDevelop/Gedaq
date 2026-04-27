

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
    Id = 9,
    Value = Guid.Parse("62ff6e9c-3733-44aa-a537-aab0a1cf6fb3"),
    ModelInner = null,
    NullableValue = Guid.Parse("bc2fd31b-523f-49cd-92f2-37e5bc15c824"),
},
            new Guiduniqueidentifier0M
{
    Id = 13,
    Value = Guid.Parse("abbc46e9-5de3-453a-8b6f-565fcb148e14"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 4,
    Value = Guid.Parse("3778c504-6ec7-47f3-a7e3-7d2810d3cf0d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 21,
    Value = Guid.Parse("2f922b64-2017-40f1-b34d-dea7b5b2e597"),
    ModelInner = null,
    NullableValue = Guid.Parse("e335d79d-9849-4cff-bf20-c60d88e0e513"),
},
            new Guiduniqueidentifier0M
{
    Id = 22,
    Value = Guid.Parse("b60b92a6-8d72-4188-935e-848033319bbd"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 7,
    Value = Guid.Parse("4889e7aa-e9c6-4d7b-a282-994ff3371b6f"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 27,
    Value = Guid.Parse("e1e87488-cc83-4938-b5d4-644c5857d8f3"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 29,
    Value = Guid.Parse("2e67d1a8-cbc5-4d54-a4dc-2cfdb9b5c523"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 11,
    Value = Guid.Parse("7d4d273c-0e0c-4472-9cc0-20a732c52816"),
    NullableValue = Guid.Parse("54fad993-0d1b-4bc2-8bb1-5435a1351fd4"),
},
    NullableValue = Guid.Parse("0fdaf285-1dcd-42d8-97dc-51911e6e4734"),
},
            new Guiduniqueidentifier0M
{
    Id = 34,
    Value = Guid.Parse("3f83ad04-6649-49fd-9b5a-47022b8a0e34"),
    ModelInner = null,
    NullableValue = Guid.Parse("31b2a8c3-ae53-4264-ab90-94ba335dd254"),
},
            new Guiduniqueidentifier0M
{
    Id = 38,
    Value = Guid.Parse("f60765a4-ecea-4171-91d6-7a57c8ab164d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 19,
    Value = Guid.Parse("865ffc88-55b4-4dc7-bce2-22aab623309c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a2e25850-c160-4c11-9b1e-1b8cd4caeff7"),
},
            new Guiduniqueidentifier0M
{
    Id = 43,
    Value = Guid.Parse("e0c42958-af88-4078-864b-cdf8a413dd5a"),
    ModelInner = null,
    NullableValue = Guid.Parse("8eadb5c7-69f5-426f-8072-a43012650497"),
},
            new Guiduniqueidentifier0M
{
    Id = 52,
    Value = Guid.Parse("db58ddb9-8ded-459a-8cda-1fdb33f1bc44"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 27,
    Value = Guid.Parse("14d61c1d-9820-4207-8aeb-681abf6bf9fc"),
    NullableValue = Guid.Parse("ceee3008-317d-49c6-b2d4-1bacd28978cf"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 56,
    Value = Guid.Parse("8a0dc15e-09df-4a9e-b327-81efc98f4b37"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 60,
    Value = Guid.Parse("b27d359d-3e7c-43d5-bfd8-8afd5c7cf8f2"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 34,
    Value = Guid.Parse("825ed55f-31a4-4848-a84a-c8d53ebc91bd"),
    NullableValue = Guid.Parse("07cf18a2-3335-425e-b304-e91b5f50f842"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 63,
    Value = Guid.Parse("9e064a2e-2a17-45ee-bc68-617b3f7c18e1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 67,
    Value = Guid.Parse("0ee8ad2f-8042-4b6f-8eca-707dd720ff8e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 36,
    Value = Guid.Parse("d3bb71c3-50f7-4b02-987a-2c82dcc022c6"),
    NullableValue = Guid.Parse("4bd1b340-d7aa-4b51-a64a-38a90dac2607"),
},
    NullableValue = Guid.Parse("a0991e71-1d2e-439f-87a0-9f0f0793a226"),
},
            new Guiduniqueidentifier0M
{
    Id = 73,
    Value = Guid.Parse("29f0af13-e455-44b5-80ac-7434611b53c1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("837aeb87-c863-4f1d-beaa-680620599d2c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 39,
    Value = Guid.Parse("48a826c0-f0ca-4efa-8fc8-bbeaf1ae1b70"),
    NullableValue = Guid.Parse("c0e678b2-0de2-4da9-8c19-2889b230f85f"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 82,
    Value = Guid.Parse("9f830601-24bb-4ec7-a590-f98c84e8ce9f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 85,
    Value = Guid.Parse("a19b1089-9ed7-4fad-ba63-59408177f00d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 43,
    Value = Guid.Parse("49086d9a-0050-47d1-a700-1e5bfa83ad79"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3f113a58-0859-4fc0-ad98-bd0aac042322"),
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("7de6a0b7-7688-482f-8f53-e30663df94d7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 96,
    Value = Guid.Parse("298b4ca9-81e0-4e72-97ff-e6f169b117ff"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 51,
    Value = Guid.Parse("1800e617-6b0c-4d02-975b-177aef2feb8f"),
    NullableValue = Guid.Parse("75fbfa7f-d590-4ca1-afbc-61002e83138c"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 99,
    Value = Guid.Parse("156f342e-939a-4cd5-ac03-697d87dc4470"),
    ModelInner = null,
    NullableValue = Guid.Parse("5d697b5a-4c9e-43e6-a0b9-50e41bb7f87f"),
},
            new Guiduniqueidentifier0M
{
    Id = 101,
    Value = Guid.Parse("9ec10dde-1cc8-4991-94e4-8bd73fafb5a3"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 54,
    Value = Guid.Parse("57387c4e-a86e-4de8-b82e-04cd567e4f77"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6bb79cb2-c964-4bac-9f49-b0962ee26ead"),
},
            new Guiduniqueidentifier0M
{
    Id = 104,
    Value = Guid.Parse("391a4918-ac37-4f34-9c85-c9984c863127"),
    ModelInner = null,
    NullableValue = Guid.Parse("bdbd1ab7-88a8-418d-94f9-102e000799d0"),
},
            new Guiduniqueidentifier0M
{
    Id = 110,
    Value = Guid.Parse("42bdc038-d16a-4d5d-8ddd-3c18be5931ce"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 57,
    Value = Guid.Parse("f4189c9e-a340-407a-9730-ef02a3fda071"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("72679106-442c-4b6c-af01-669ca9428df9"),
    ModelInner = null,
    NullableValue = Guid.Parse("e050ee85-175c-4ad5-8e6c-322e0c2c807e"),
},
            new Guiduniqueidentifier0M
{
    Id = 127,
    Value = Guid.Parse("4f3c00de-4d32-414c-8025-a00229a96ca4"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 58,
    Value = Guid.Parse("fec5c07e-0f71-4eb3-a9ed-8d37f71fd8b3"),
    NullableValue = Guid.Parse("0c43c5eb-ef45-479b-ab0e-d6b91a0bac1c"),
},
    NullableValue = Guid.Parse("aefb6830-64de-4d99-9c6c-09c75680a906"),
},
            new Guiduniqueidentifier0M
{
    Id = 133,
    Value = Guid.Parse("4d3675f5-6a11-4e35-a837-bed921984d80"),
    ModelInner = null,
    NullableValue = Guid.Parse("36d460d1-c752-4cbc-ab4b-6625917b672d"),
},
            new Guiduniqueidentifier0M
{
    Id = 139,
    Value = Guid.Parse("0e6964f4-98f1-46be-8fdc-9758572a7966"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 63,
    Value = Guid.Parse("6205c4b7-f036-4b26-bcc0-696d15916b2f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("52b83090-6d8f-4bb7-a286-1d1faa442d89"),
},
            new Guiduniqueidentifier0M
{
    Id = 141,
    Value = Guid.Parse("662476bc-4652-4841-80d8-02d39dbc34a1"),
    ModelInner = null,
    NullableValue = Guid.Parse("d75d9af2-e531-4993-a671-85c4d0036499"),
},
            new Guiduniqueidentifier0M
{
    Id = 149,
    Value = Guid.Parse("bc85c18b-984b-4381-a71e-3005a321b6ec"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 66,
    Value = Guid.Parse("c79afd05-69a6-4644-abdf-7fa4296dea80"),
    NullableValue = Guid.Parse("c96b3d0d-0d19-4fee-8ccc-86387953f1fc"),
},
    NullableValue = Guid.Parse("11ca10eb-9bc0-446b-bfdd-7a6dcc92c7e1"),
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[29], false);
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
                parametr1.Value = 67;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[29], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[29], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                parametr1.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[29], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[29], false);
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
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 67, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 139, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[29], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[29], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[4], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 67, 85))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[29], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[2], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[3], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[4], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[25],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[26],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62ff6e9c-3733-44aa-a537-aab0a1cf6fb3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bc2fd31b-523f-49cd-92f2-37e5bc15c824"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abbc46e9-5de3-453a-8b6f-565fcb148e14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3778c504-6ec7-47f3-a7e3-7d2810d3cf0d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f922b64-2017-40f1-b34d-dea7b5b2e597"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e335d79d-9849-4cff-bf20-c60d88e0e513"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b60b92a6-8d72-4188-935e-848033319bbd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4889e7aa-e9c6-4d7b-a282-994ff3371b6f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1e87488-cc83-4938-b5d4-644c5857d8f3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2e67d1a8-cbc5-4d54-a4dc-2cfdb9b5c523"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7d4d273c-0e0c-4472-9cc0-20a732c52816"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("54fad993-0d1b-4bc2-8bb1-5435a1351fd4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0fdaf285-1dcd-42d8-97dc-51911e6e4734"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f83ad04-6649-49fd-9b5a-47022b8a0e34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("31b2a8c3-ae53-4264-ab90-94ba335dd254"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f60765a4-ecea-4171-91d6-7a57c8ab164d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("865ffc88-55b4-4dc7-bce2-22aab623309c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2e25850-c160-4c11-9b1e-1b8cd4caeff7"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0c42958-af88-4078-864b-cdf8a413dd5a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8eadb5c7-69f5-426f-8072-a43012650497"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db58ddb9-8ded-459a-8cda-1fdb33f1bc44"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("14d61c1d-9820-4207-8aeb-681abf6bf9fc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ceee3008-317d-49c6-b2d4-1bacd28978cf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a0dc15e-09df-4a9e-b327-81efc98f4b37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b27d359d-3e7c-43d5-bfd8-8afd5c7cf8f2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("825ed55f-31a4-4848-a84a-c8d53ebc91bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("07cf18a2-3335-425e-b304-e91b5f50f842"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e064a2e-2a17-45ee-bc68-617b3f7c18e1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ee8ad2f-8042-4b6f-8eca-707dd720ff8e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3bb71c3-50f7-4b02-987a-2c82dcc022c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4bd1b340-d7aa-4b51-a64a-38a90dac2607"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a0991e71-1d2e-439f-87a0-9f0f0793a226"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29f0af13-e455-44b5-80ac-7434611b53c1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("837aeb87-c863-4f1d-beaa-680620599d2c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("48a826c0-f0ca-4efa-8fc8-bbeaf1ae1b70"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c0e678b2-0de2-4da9-8c19-2889b230f85f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f830601-24bb-4ec7-a590-f98c84e8ce9f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a19b1089-9ed7-4fad-ba63-59408177f00d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49086d9a-0050-47d1-a700-1e5bfa83ad79"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f113a58-0859-4fc0-ad98-bd0aac042322"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7de6a0b7-7688-482f-8f53-e30663df94d7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("298b4ca9-81e0-4e72-97ff-e6f169b117ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1800e617-6b0c-4d02-975b-177aef2feb8f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("75fbfa7f-d590-4ca1-afbc-61002e83138c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("156f342e-939a-4cd5-ac03-697d87dc4470"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d697b5a-4c9e-43e6-a0b9-50e41bb7f87f"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ec10dde-1cc8-4991-94e4-8bd73fafb5a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("57387c4e-a86e-4de8-b82e-04cd567e4f77"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6bb79cb2-c964-4bac-9f49-b0962ee26ead"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391a4918-ac37-4f34-9c85-c9984c863127"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdbd1ab7-88a8-418d-94f9-102e000799d0"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42bdc038-d16a-4d5d-8ddd-3c18be5931ce"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f4189c9e-a340-407a-9730-ef02a3fda071"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72679106-442c-4b6c-af01-669ca9428df9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e050ee85-175c-4ad5-8e6c-322e0c2c807e"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f3c00de-4d32-414c-8025-a00229a96ca4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fec5c07e-0f71-4eb3-a9ed-8d37f71fd8b3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0c43c5eb-ef45-479b-ab0e-d6b91a0bac1c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aefb6830-64de-4d99-9c6c-09c75680a906"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d3675f5-6a11-4e35-a837-bed921984d80"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("36d460d1-c752-4cbc-ab4b-6625917b672d"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e6964f4-98f1-46be-8fdc-9758572a7966"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6205c4b7-f036-4b26-bcc0-696d15916b2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("52b83090-6d8f-4bb7-a286-1d1faa442d89"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("662476bc-4652-4841-80d8-02d39dbc34a1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d75d9af2-e531-4993-a671-85c4d0036499"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc85c18b-984b-4381-a71e-3005a321b6ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c79afd05-69a6-4644-abdf-7fa4296dea80"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c96b3d0d-0d19-4fee-8ccc-86387953f1fc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("11ca10eb-9bc0-446b-bfdd-7a6dcc92c7e1"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62ff6e9c-3733-44aa-a537-aab0a1cf6fb3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bc2fd31b-523f-49cd-92f2-37e5bc15c824"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abbc46e9-5de3-453a-8b6f-565fcb148e14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3778c504-6ec7-47f3-a7e3-7d2810d3cf0d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f922b64-2017-40f1-b34d-dea7b5b2e597"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e335d79d-9849-4cff-bf20-c60d88e0e513"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b60b92a6-8d72-4188-935e-848033319bbd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4889e7aa-e9c6-4d7b-a282-994ff3371b6f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e1e87488-cc83-4938-b5d4-644c5857d8f3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2e67d1a8-cbc5-4d54-a4dc-2cfdb9b5c523"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7d4d273c-0e0c-4472-9cc0-20a732c52816"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("54fad993-0d1b-4bc2-8bb1-5435a1351fd4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0fdaf285-1dcd-42d8-97dc-51911e6e4734"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3f83ad04-6649-49fd-9b5a-47022b8a0e34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("31b2a8c3-ae53-4264-ab90-94ba335dd254"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f60765a4-ecea-4171-91d6-7a57c8ab164d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("865ffc88-55b4-4dc7-bce2-22aab623309c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2e25850-c160-4c11-9b1e-1b8cd4caeff7"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0c42958-af88-4078-864b-cdf8a413dd5a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8eadb5c7-69f5-426f-8072-a43012650497"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db58ddb9-8ded-459a-8cda-1fdb33f1bc44"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("14d61c1d-9820-4207-8aeb-681abf6bf9fc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ceee3008-317d-49c6-b2d4-1bacd28978cf"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a0dc15e-09df-4a9e-b327-81efc98f4b37"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b27d359d-3e7c-43d5-bfd8-8afd5c7cf8f2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("825ed55f-31a4-4848-a84a-c8d53ebc91bd"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("07cf18a2-3335-425e-b304-e91b5f50f842"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9e064a2e-2a17-45ee-bc68-617b3f7c18e1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ee8ad2f-8042-4b6f-8eca-707dd720ff8e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3bb71c3-50f7-4b02-987a-2c82dcc022c6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4bd1b340-d7aa-4b51-a64a-38a90dac2607"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a0991e71-1d2e-439f-87a0-9f0f0793a226"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("29f0af13-e455-44b5-80ac-7434611b53c1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("837aeb87-c863-4f1d-beaa-680620599d2c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("48a826c0-f0ca-4efa-8fc8-bbeaf1ae1b70"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c0e678b2-0de2-4da9-8c19-2889b230f85f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9f830601-24bb-4ec7-a590-f98c84e8ce9f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a19b1089-9ed7-4fad-ba63-59408177f00d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("49086d9a-0050-47d1-a700-1e5bfa83ad79"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3f113a58-0859-4fc0-ad98-bd0aac042322"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7de6a0b7-7688-482f-8f53-e30663df94d7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("298b4ca9-81e0-4e72-97ff-e6f169b117ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1800e617-6b0c-4d02-975b-177aef2feb8f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("75fbfa7f-d590-4ca1-afbc-61002e83138c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("156f342e-939a-4cd5-ac03-697d87dc4470"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5d697b5a-4c9e-43e6-a0b9-50e41bb7f87f"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ec10dde-1cc8-4991-94e4-8bd73fafb5a3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("57387c4e-a86e-4de8-b82e-04cd567e4f77"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6bb79cb2-c964-4bac-9f49-b0962ee26ead"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391a4918-ac37-4f34-9c85-c9984c863127"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdbd1ab7-88a8-418d-94f9-102e000799d0"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42bdc038-d16a-4d5d-8ddd-3c18be5931ce"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f4189c9e-a340-407a-9730-ef02a3fda071"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72679106-442c-4b6c-af01-669ca9428df9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e050ee85-175c-4ad5-8e6c-322e0c2c807e"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f3c00de-4d32-414c-8025-a00229a96ca4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fec5c07e-0f71-4eb3-a9ed-8d37f71fd8b3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("0c43c5eb-ef45-479b-ab0e-d6b91a0bac1c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aefb6830-64de-4d99-9c6c-09c75680a906"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d3675f5-6a11-4e35-a837-bed921984d80"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("36d460d1-c752-4cbc-ab4b-6625917b672d"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e6964f4-98f1-46be-8fdc-9758572a7966"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6205c4b7-f036-4b26-bcc0-696d15916b2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("52b83090-6d8f-4bb7-a286-1d1faa442d89"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("662476bc-4652-4841-80d8-02d39dbc34a1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d75d9af2-e531-4993-a671-85c4d0036499"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc85c18b-984b-4381-a71e-3005a321b6ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c79afd05-69a6-4644-abdf-7fa4296dea80"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c96b3d0d-0d19-4fee-8ccc-86387953f1fc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("11ca10eb-9bc0-446b-bfdd-7a6dcc92c7e1"))));

            }
        }

#endregion

    }
}

