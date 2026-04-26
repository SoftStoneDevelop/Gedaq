

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
    Value = Guid.Parse("d7eeb2d9-9d5b-442d-ad96-bc65f86b3c7f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 10,
    Value = Guid.Parse("d34969a8-323a-4237-a1d8-197107c61100"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 9,
    Value = Guid.Parse("4c2dbd49-a081-463a-b0fd-bf4e57ef9bc3"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f85697a8-6032-422c-86f4-db11bf2ea4fe"),
},
            new Guiduniqueidentifier0M
{
    Id = 12,
    Value = Guid.Parse("116e21a0-4cbf-45dd-b6fc-544fcac879ee"),
    ModelInner = null,
    NullableValue = Guid.Parse("d3ddddf2-1721-41ef-98b7-ee7170ff4b11"),
},
            new Guiduniqueidentifier0M
{
    Id = 19,
    Value = Guid.Parse("c30735ba-1be3-424f-bea3-2a7a11acccfa"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 15,
    Value = Guid.Parse("ab700a57-dae6-40c2-b0b3-78dc08464f26"),
    NullableValue = Guid.Parse("7d960f6c-cc89-47c2-b4f0-3c31d9fdd457"),
},
    NullableValue = Guid.Parse("b5c46d0c-65a2-42c7-af7a-eedc54bd76d1"),
},
            new Guiduniqueidentifier0M
{
    Id = 20,
    Value = Guid.Parse("e2be6bf1-3a50-4b3e-ada3-8f15fb2e005d"),
    ModelInner = null,
    NullableValue = Guid.Parse("60f288f3-4558-4043-8ace-c8178d929ff5"),
},
            new Guiduniqueidentifier0M
{
    Id = 21,
    Value = Guid.Parse("d5ec2c22-b4b1-4801-96d1-112db0772289"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 16,
    Value = Guid.Parse("0de77911-215d-4623-a531-0f688b0066ef"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 24,
    Value = Guid.Parse("16829787-ba30-4a01-bfd9-445dc6a36694"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 28,
    Value = Guid.Parse("0c28d01c-8ac9-48ca-9955-b6d88e457fb2"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 24,
    Value = Guid.Parse("33133ec6-4f10-48c6-a2b5-e911191ac77a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("0b9c239b-8be0-464a-922d-71ed5d4f6d86"),
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("f63a5492-8a74-4078-ae5c-799d55fcb2a9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 42,
    Value = Guid.Parse("8ad9acce-9ffa-4a8b-9de2-763dfd3049d1"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 25,
    Value = Guid.Parse("24ac69e9-aecd-4087-b890-b255d7649d32"),
    NullableValue = Guid.Parse("67916a2d-d421-4a34-84fe-5609616ae25a"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 50,
    Value = Guid.Parse("f145f6fd-095c-484b-a12d-12a6f995c2e9"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 51,
    Value = Guid.Parse("d94604dc-eb96-4a49-8304-81f6749543a7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 34,
    Value = Guid.Parse("be71c0d8-9772-41fa-ba66-79663afee41e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ef715805-b87f-4168-84f3-8c4dd113688c"),
},
            new Guiduniqueidentifier0M
{
    Id = 59,
    Value = Guid.Parse("497b29eb-8637-4a8f-83ed-4bb11e581cf8"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 60,
    Value = Guid.Parse("9849073f-0edd-4c95-b4e1-aad2d7a4f956"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 38,
    Value = Guid.Parse("750bc1cf-1933-463e-ba79-3dc8f187ed7e"),
    NullableValue = Guid.Parse("b6a21164-950c-4edf-8574-d9a4fdb95509"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 67,
    Value = Guid.Parse("ef6e36a3-6be2-4fa3-bc14-98da5cd8fe75"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 70,
    Value = Guid.Parse("c504e449-0ced-4c13-8fef-03f4105d77fa"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 43,
    Value = Guid.Parse("4c25bca5-8237-4c66-95c4-66e5ea52a20a"),
    NullableValue = Guid.Parse("b50bdbd2-cb8e-4bcf-9a2f-210f70dd267d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 72,
    Value = Guid.Parse("2d8631ea-b6a1-4542-8720-826837c19b47"),
    ModelInner = null,
    NullableValue = Guid.Parse("bacf2266-b44a-4796-9759-ef5caec09dec"),
},
            new Guiduniqueidentifier0M
{
    Id = 76,
    Value = Guid.Parse("b05631e4-fd94-4839-bd2d-5ce2d5948d74"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 52,
    Value = Guid.Parse("531730c0-2436-40a6-899c-675852f5f4ea"),
    NullableValue = Guid.Parse("e31204c1-9308-45a8-a347-cdd28ca3f48e"),
},
    NullableValue = Guid.Parse("7ab0c950-a491-425f-b739-071564dcdade"),
},
            new Guiduniqueidentifier0M
{
    Id = 85,
    Value = Guid.Parse("59bee751-fc5e-4b43-9f18-1a505646bdb6"),
    ModelInner = null,
    NullableValue = Guid.Parse("f07eb0a6-fc8a-48dd-8611-6df1a7e4c0aa"),
},
            new Guiduniqueidentifier0M
{
    Id = 88,
    Value = Guid.Parse("0acdf51e-0cee-4e19-9882-535f136063eb"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 60,
    Value = Guid.Parse("0aed5212-47df-4c4c-8b1b-eec1b36512eb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 93,
    Value = Guid.Parse("2d2c9536-09e0-43e3-8854-ec4de97a5be5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 99,
    Value = Guid.Parse("0ec7af3d-c216-451a-bc28-a2a17bd78d51"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 67,
    Value = Guid.Parse("ee874c9b-87cc-4af7-b087-6bd84e0f605d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 105,
    Value = Guid.Parse("eb0bbcd8-c8de-4a76-bb1a-835ffc4e1777"),
    ModelInner = null,
    NullableValue = Guid.Parse("5ab17f54-ee63-4772-859f-e6c58ea40077"),
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("3aade180-f674-4b97-8550-a65823e65f86"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 73,
    Value = Guid.Parse("9e0f7dc1-3582-424a-8a75-2d251c7b6d17"),
    NullableValue = Guid.Parse("95b1472c-e864-49d7-9e1c-b5f478916ce5"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 111,
    Value = Guid.Parse("3ba132b3-9e40-48b4-b5d6-7a4d66236c4c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 116,
    Value = Guid.Parse("1f33601c-f1bc-494d-bd7b-cfe72764f057"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 74,
    Value = Guid.Parse("8c698c5b-922d-48b0-8cf7-279233ff1337"),
    NullableValue = Guid.Parse("bedd4bd4-21e7-45a3-9f9c-e709f9c6eab8"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 118,
    Value = Guid.Parse("7e2cde79-f5ee-4e38-b4dd-596d5ba11784"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("e2c7f002-2faf-49f6-ab7c-5b49449fbe0c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 81,
    Value = Guid.Parse("8dc6cf00-27da-4f4d-a0c9-a483d6337b0c"),
    NullableValue = Guid.Parse("73cea74b-3072-4424-a0e5-42e8980e426f"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 124,
    Value = Guid.Parse("99c2e148-3c07-4a2d-9f53-a52197b77c19"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 127,
    Value = Guid.Parse("cb19bbbc-25ed-4aa8-b113-79e491884697"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 83,
    Value = Guid.Parse("6ad116cb-6fe4-49f3-9bcc-5d16c4268826"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("44f33414-5fa3-4efb-9952-eb7b1f6c91d7"),
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(14))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(14)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(14),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models = await ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynParAsync(connection, [parametr1]);
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

                var models =  ((IGuidSingleTypeuniqueidentifier)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DynQuerySelectModel(connection,  query, 0);
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).SelectModelAsync(connection, 0);
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
                var models =  ((IGuidSingleTypeuniqueidentifier)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
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

                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduniqueidentifier0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[4], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[5], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[6], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[7], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[8], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[9], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[10], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[11], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[12], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[13], false);FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[14], false);FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[15], false);FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[16], false);FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[17], false);FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[18], false);FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[19], false);FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.guiduniqueidentifier0m m
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
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
LEFT JOIN dbo.guiduniqueidentifier0mi mi ON mi.id = m.guiduniqueidentifier0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[20], false);FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[21], false);FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[22], false);FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[23], false);FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[24], false);FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[25], false);FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[26], false);FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[27], false);FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[28], false);FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelBatchAsync(connection, 21, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[29], false);
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
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Guiduniqueidentifier0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelBatch(connection, 123, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[29], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 2);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);Guiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);Guiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);Guiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);Guiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);Guiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);Guiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);Guiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);Guiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);Guiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);Guiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);Guiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);Guiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);Guiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);Guiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);Guiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);Guiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7eeb2d9-9d5b-442d-ad96-bc65f86b3c7f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d34969a8-323a-4237-a1d8-197107c61100"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4c2dbd49-a081-463a-b0fd-bf4e57ef9bc3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f85697a8-6032-422c-86f4-db11bf2ea4fe"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("116e21a0-4cbf-45dd-b6fc-544fcac879ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3ddddf2-1721-41ef-98b7-ee7170ff4b11"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c30735ba-1be3-424f-bea3-2a7a11acccfa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab700a57-dae6-40c2-b0b3-78dc08464f26"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d960f6c-cc89-47c2-b4f0-3c31d9fdd457"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b5c46d0c-65a2-42c7-af7a-eedc54bd76d1"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2be6bf1-3a50-4b3e-ada3-8f15fb2e005d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("60f288f3-4558-4043-8ace-c8178d929ff5"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5ec2c22-b4b1-4801-96d1-112db0772289"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0de77911-215d-4623-a531-0f688b0066ef"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16829787-ba30-4a01-bfd9-445dc6a36694"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0c28d01c-8ac9-48ca-9955-b6d88e457fb2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("33133ec6-4f10-48c6-a2b5-e911191ac77a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b9c239b-8be0-464a-922d-71ed5d4f6d86"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f63a5492-8a74-4078-ae5c-799d55fcb2a9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ad9acce-9ffa-4a8b-9de2-763dfd3049d1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("24ac69e9-aecd-4087-b890-b255d7649d32"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("67916a2d-d421-4a34-84fe-5609616ae25a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f145f6fd-095c-484b-a12d-12a6f995c2e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d94604dc-eb96-4a49-8304-81f6749543a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be71c0d8-9772-41fa-ba66-79663afee41e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ef715805-b87f-4168-84f3-8c4dd113688c"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("497b29eb-8637-4a8f-83ed-4bb11e581cf8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9849073f-0edd-4c95-b4e1-aad2d7a4f956"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("750bc1cf-1933-463e-ba79-3dc8f187ed7e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6a21164-950c-4edf-8574-d9a4fdb95509"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef6e36a3-6be2-4fa3-bc14-98da5cd8fe75"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c504e449-0ced-4c13-8fef-03f4105d77fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4c25bca5-8237-4c66-95c4-66e5ea52a20a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b50bdbd2-cb8e-4bcf-9a2f-210f70dd267d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d8631ea-b6a1-4542-8720-826837c19b47"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bacf2266-b44a-4796-9759-ef5caec09dec"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b05631e4-fd94-4839-bd2d-5ce2d5948d74"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("531730c0-2436-40a6-899c-675852f5f4ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e31204c1-9308-45a8-a347-cdd28ca3f48e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ab0c950-a491-425f-b739-071564dcdade"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("59bee751-fc5e-4b43-9f18-1a505646bdb6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f07eb0a6-fc8a-48dd-8611-6df1a7e4c0aa"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0acdf51e-0cee-4e19-9882-535f136063eb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0aed5212-47df-4c4c-8b1b-eec1b36512eb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d2c9536-09e0-43e3-8854-ec4de97a5be5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ec7af3d-c216-451a-bc28-a2a17bd78d51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee874c9b-87cc-4af7-b087-6bd84e0f605d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb0bbcd8-c8de-4a76-bb1a-835ffc4e1777"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5ab17f54-ee63-4772-859f-e6c58ea40077"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aade180-f674-4b97-8550-a65823e65f86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e0f7dc1-3582-424a-8a75-2d251c7b6d17"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("95b1472c-e864-49d7-9e1c-b5f478916ce5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ba132b3-9e40-48b4-b5d6-7a4d66236c4c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1f33601c-f1bc-494d-bd7b-cfe72764f057"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c698c5b-922d-48b0-8cf7-279233ff1337"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bedd4bd4-21e7-45a3-9f9c-e709f9c6eab8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e2cde79-f5ee-4e38-b4dd-596d5ba11784"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2c7f002-2faf-49f6-ab7c-5b49449fbe0c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8dc6cf00-27da-4f4d-a0c9-a483d6337b0c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("73cea74b-3072-4424-a0e5-42e8980e426f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99c2e148-3c07-4a2d-9f53-a52197b77c19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cb19bbbc-25ed-4aa8-b113-79e491884697"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6ad116cb-6fe4-49f3-9bcc-5d16c4268826"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("44f33414-5fa3-4efb-9952-eb7b1f6c91d7"))));

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
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7eeb2d9-9d5b-442d-ad96-bc65f86b3c7f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d34969a8-323a-4237-a1d8-197107c61100"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4c2dbd49-a081-463a-b0fd-bf4e57ef9bc3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f85697a8-6032-422c-86f4-db11bf2ea4fe"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("116e21a0-4cbf-45dd-b6fc-544fcac879ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d3ddddf2-1721-41ef-98b7-ee7170ff4b11"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c30735ba-1be3-424f-bea3-2a7a11acccfa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ab700a57-dae6-40c2-b0b3-78dc08464f26"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7d960f6c-cc89-47c2-b4f0-3c31d9fdd457"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b5c46d0c-65a2-42c7-af7a-eedc54bd76d1"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2be6bf1-3a50-4b3e-ada3-8f15fb2e005d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("60f288f3-4558-4043-8ace-c8178d929ff5"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d5ec2c22-b4b1-4801-96d1-112db0772289"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0de77911-215d-4623-a531-0f688b0066ef"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("16829787-ba30-4a01-bfd9-445dc6a36694"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0c28d01c-8ac9-48ca-9955-b6d88e457fb2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("33133ec6-4f10-48c6-a2b5-e911191ac77a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0b9c239b-8be0-464a-922d-71ed5d4f6d86"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f63a5492-8a74-4078-ae5c-799d55fcb2a9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ad9acce-9ffa-4a8b-9de2-763dfd3049d1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("24ac69e9-aecd-4087-b890-b255d7649d32"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("67916a2d-d421-4a34-84fe-5609616ae25a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f145f6fd-095c-484b-a12d-12a6f995c2e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d94604dc-eb96-4a49-8304-81f6749543a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("be71c0d8-9772-41fa-ba66-79663afee41e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ef715805-b87f-4168-84f3-8c4dd113688c"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("497b29eb-8637-4a8f-83ed-4bb11e581cf8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9849073f-0edd-4c95-b4e1-aad2d7a4f956"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("750bc1cf-1933-463e-ba79-3dc8f187ed7e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6a21164-950c-4edf-8574-d9a4fdb95509"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef6e36a3-6be2-4fa3-bc14-98da5cd8fe75"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c504e449-0ced-4c13-8fef-03f4105d77fa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4c25bca5-8237-4c66-95c4-66e5ea52a20a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b50bdbd2-cb8e-4bcf-9a2f-210f70dd267d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d8631ea-b6a1-4542-8720-826837c19b47"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bacf2266-b44a-4796-9759-ef5caec09dec"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b05631e4-fd94-4839-bd2d-5ce2d5948d74"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("531730c0-2436-40a6-899c-675852f5f4ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e31204c1-9308-45a8-a347-cdd28ca3f48e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ab0c950-a491-425f-b739-071564dcdade"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("59bee751-fc5e-4b43-9f18-1a505646bdb6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f07eb0a6-fc8a-48dd-8611-6df1a7e4c0aa"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0acdf51e-0cee-4e19-9882-535f136063eb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0aed5212-47df-4c4c-8b1b-eec1b36512eb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d2c9536-09e0-43e3-8854-ec4de97a5be5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0ec7af3d-c216-451a-bc28-a2a17bd78d51"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ee874c9b-87cc-4af7-b087-6bd84e0f605d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("eb0bbcd8-c8de-4a76-bb1a-835ffc4e1777"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5ab17f54-ee63-4772-859f-e6c58ea40077"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3aade180-f674-4b97-8550-a65823e65f86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9e0f7dc1-3582-424a-8a75-2d251c7b6d17"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("95b1472c-e864-49d7-9e1c-b5f478916ce5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ba132b3-9e40-48b4-b5d6-7a4d66236c4c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1f33601c-f1bc-494d-bd7b-cfe72764f057"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c698c5b-922d-48b0-8cf7-279233ff1337"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("bedd4bd4-21e7-45a3-9f9c-e709f9c6eab8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e2cde79-f5ee-4e38-b4dd-596d5ba11784"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e2c7f002-2faf-49f6-ab7c-5b49449fbe0c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8dc6cf00-27da-4f4d-a0c9-a483d6337b0c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("73cea74b-3072-4424-a0e5-42e8980e426f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("99c2e148-3c07-4a2d-9f53-a52197b77c19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cb19bbbc-25ed-4aa8-b113-79e491884697"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6ad116cb-6fe4-49f3-9bcc-5d16c4268826"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("44f33414-5fa3-4efb-9952-eb7b1f6c91d7"))));

            }
        }

#endregion

    }
}

