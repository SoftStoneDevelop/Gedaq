

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
    Id = 4,
    Value = Guid.Parse("0e2d8f27-7e9d-46ef-946a-372bb60c4a4d"),
    ModelInner = null,
    NullableValue = Guid.Parse("b94ad677-f2d8-4115-a141-73619b3f9fc7"),
},
            new Guiduniqueidentifier0M
{
    Id = 12,
    Value = Guid.Parse("70fe1787-6de3-458d-8204-283ec6d2518c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 8,
    Value = Guid.Parse("3dd5f8c9-6b65-49cf-a165-cf0ea24cc060"),
    NullableValue = Guid.Parse("6017900c-a378-4d8f-ae7d-ee9d287b17a3"),
},
    NullableValue = Guid.Parse("e844e2b3-7761-4d82-a199-fad48972c618"),
},
            new Guiduniqueidentifier0M
{
    Id = 18,
    Value = Guid.Parse("2f3dd112-4c36-406a-a26d-0db530dd551c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 22,
    Value = Guid.Parse("fc3d6375-76b3-473f-ac1c-758cac3c5a5b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 13,
    Value = Guid.Parse("51397849-e967-4025-8fba-440805c63085"),
    NullableValue = Guid.Parse("56598378-09c7-4a5b-96fa-b06780d079e5"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 27,
    Value = Guid.Parse("dc81de88-f926-43b5-a397-b1c8359d4735"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 30,
    Value = Guid.Parse("f5c22451-84df-4b79-b88c-718114d3c3ca"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 21,
    Value = Guid.Parse("a4ea4fd2-11f9-453a-8a76-680db292dc2e"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a285360b-fa90-488f-8b13-dd91799fb1c3"),
},
            new Guiduniqueidentifier0M
{
    Id = 33,
    Value = Guid.Parse("1515cd7d-6b04-452b-a680-f1e27d841097"),
    ModelInner = null,
    NullableValue = Guid.Parse("4e9515c6-b92d-4f80-965a-b309581d0f85"),
},
            new Guiduniqueidentifier0M
{
    Id = 34,
    Value = Guid.Parse("765be33d-05c1-4090-8774-7d66b5c69abc"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 28,
    Value = Guid.Parse("67dfba52-551a-42ae-ba11-1489989866c9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("003ea050-9d65-4ee4-82cd-2996d69436a2"),
},
            new Guiduniqueidentifier0M
{
    Id = 40,
    Value = Guid.Parse("d65728dc-2f3c-44f5-a61e-b8ec22ff4418"),
    ModelInner = null,
    NullableValue = Guid.Parse("7ea8b46d-409f-40b2-9cc0-a1506c33b52c"),
},
            new Guiduniqueidentifier0M
{
    Id = 41,
    Value = Guid.Parse("c9149037-40a0-4f7c-9626-c306f2d31fbc"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 32,
    Value = Guid.Parse("b0bdaca9-64d1-4673-bff1-c2e7eaf06168"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 49,
    Value = Guid.Parse("fd186082-8533-4c3e-ac5f-e3288bc66516"),
    ModelInner = null,
    NullableValue = Guid.Parse("87df23dc-8924-476c-aa5d-b06c7e4c3008"),
},
            new Guiduniqueidentifier0M
{
    Id = 52,
    Value = Guid.Parse("f4b1ec10-a8be-4acb-9199-670eab0f87d7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 40,
    Value = Guid.Parse("cd44a6d4-e62b-4262-a37e-6f78a128e839"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 58,
    Value = Guid.Parse("7f8b81b5-681f-4168-ac88-ecded954ac59"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 63,
    Value = Guid.Parse("b09b5021-56e1-4589-bf69-75bda2b5941a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 44,
    Value = Guid.Parse("c84d3c07-add1-4a59-a295-c9b4bbd24f30"),
    NullableValue = Guid.Parse("e27ce521-9cfb-4dba-a4bf-145a6ef517aa"),
},
    NullableValue = Guid.Parse("10114f6e-e5bf-4b6f-9c86-3595d6fbc363"),
},
            new Guiduniqueidentifier0M
{
    Id = 66,
    Value = Guid.Parse("2332fe6d-a770-4ea0-8a13-4213c8205850"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 71,
    Value = Guid.Parse("7a8ed28e-374c-4327-b4a1-33409a466b0e"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 49,
    Value = Guid.Parse("a96650cd-4e43-435d-9de7-70033f9f2ab5"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("77e323f4-f3a3-4b59-9ae1-858ea7620f55"),
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("63b7f8c2-198d-4e87-985d-440fb8161b4a"),
    ModelInner = null,
    NullableValue = Guid.Parse("77e3aa73-b718-4656-bc6d-9d160a25dd0a"),
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("1c2b604f-68ce-42d2-9d94-e59d0398ef7b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 50,
    Value = Guid.Parse("152506d3-6edc-482d-beee-33b1aba02d02"),
    NullableValue = Guid.Parse("a4cea99b-42b6-4f5d-815a-8c95f302f37d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 86,
    Value = Guid.Parse("142d98b1-8622-4260-9eb1-65e79fa347bb"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 91,
    Value = Guid.Parse("915a60e1-837b-4f88-ae7b-ddb080f8861d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 56,
    Value = Guid.Parse("73b0a206-3975-4f6d-bdd9-ce29af584838"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 98,
    Value = Guid.Parse("b16576d4-81c0-4f99-9e1b-37fac9b33c19"),
    ModelInner = null,
    NullableValue = Guid.Parse("09d1c22c-ecf6-44f5-a5d1-7981dd749b75"),
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("fdbcfeb6-7dbf-457c-baeb-4e581dc40e67"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 59,
    Value = Guid.Parse("812a69b9-af25-4e58-a03a-d45393cad890"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9cb414fb-3ed7-48c8-b901-241036e33456"),
},
            new Guiduniqueidentifier0M
{
    Id = 108,
    Value = Guid.Parse("1d35259f-342e-4d2b-96f3-298be907f658"),
    ModelInner = null,
    NullableValue = Guid.Parse("3d81ae79-caee-459d-babe-cd5f51a105f3"),
},
            new Guiduniqueidentifier0M
{
    Id = 109,
    Value = Guid.Parse("7007d4bd-7e5a-4983-9aca-94fdd52166e0"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 66,
    Value = Guid.Parse("96abc292-9391-402c-a20e-b2e0112b82c5"),
    NullableValue = Guid.Parse("77e9addc-bae2-49f8-a9f9-c01f206659f0"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 111,
    Value = Guid.Parse("2cafba97-5b68-4ded-bfef-4f385f3c1822"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 119,
    Value = Guid.Parse("153c7be8-c6d5-430d-b80e-e731b6a35cef"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 73,
    Value = Guid.Parse("1a81b8d5-2cbb-468f-a506-79c7e921e6bc"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("014a1f0f-248a-4381-b953-6a82c5ea4e18"),
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("412ab565-eea9-40a3-b214-2545db45a547"),
    ModelInner = null,
    NullableValue = Guid.Parse("f1667e9e-9064-421d-bb90-eb3e26c27dab"),
},
            new Guiduniqueidentifier0M
{
    Id = 131,
    Value = Guid.Parse("4d03ac06-4686-4e82-b7c9-9a592c2b849c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 76,
    Value = Guid.Parse("a1f657b4-dea8-452c-b59c-105ff79a5aeb"),
    NullableValue = Guid.Parse("3c868464-0f44-4674-ab23-2dbd149a47c7"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 136,
    Value = Guid.Parse("5a05925c-44f9-4d6b-826c-04fd40beb0d6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 144,
    Value = Guid.Parse("d403c11e-247e-4944-9343-e80a149ba63b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 79,
    Value = Guid.Parse("34de03f6-6041-4b40-8a9a-e6e6eb468f63"),
    NullableValue = Guid.Parse("90286bd9-1d31-49fe-8459-f91ee05baa1f"),
},
    NullableValue = null,
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 49, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[30], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[5], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[6], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[7], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[8], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 66, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);Guiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);Guiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Guiduniqueidentifier0M.AssertModel(models[0],_testData[27], false);Guiduniqueidentifier0M.AssertModel(models[1],_testData[28], false);Guiduniqueidentifier0M.AssertModel(models[2],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e2d8f27-7e9d-46ef-946a-372bb60c4a4d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b94ad677-f2d8-4115-a141-73619b3f9fc7"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70fe1787-6de3-458d-8204-283ec6d2518c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3dd5f8c9-6b65-49cf-a165-cf0ea24cc060"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6017900c-a378-4d8f-ae7d-ee9d287b17a3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e844e2b3-7761-4d82-a199-fad48972c618"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f3dd112-4c36-406a-a26d-0db530dd551c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc3d6375-76b3-473f-ac1c-758cac3c5a5b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("51397849-e967-4025-8fba-440805c63085"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("56598378-09c7-4a5b-96fa-b06780d079e5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc81de88-f926-43b5-a397-b1c8359d4735"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5c22451-84df-4b79-b88c-718114d3c3ca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a4ea4fd2-11f9-453a-8a76-680db292dc2e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a285360b-fa90-488f-8b13-dd91799fb1c3"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1515cd7d-6b04-452b-a680-f1e27d841097"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e9515c6-b92d-4f80-965a-b309581d0f85"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("765be33d-05c1-4090-8774-7d66b5c69abc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("67dfba52-551a-42ae-ba11-1489989866c9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("003ea050-9d65-4ee4-82cd-2996d69436a2"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d65728dc-2f3c-44f5-a61e-b8ec22ff4418"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ea8b46d-409f-40b2-9cc0-a1506c33b52c"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9149037-40a0-4f7c-9626-c306f2d31fbc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b0bdaca9-64d1-4673-bff1-c2e7eaf06168"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd186082-8533-4c3e-ac5f-e3288bc66516"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87df23dc-8924-476c-aa5d-b06c7e4c3008"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4b1ec10-a8be-4acb-9199-670eab0f87d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cd44a6d4-e62b-4262-a37e-6f78a128e839"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f8b81b5-681f-4168-ac88-ecded954ac59"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b09b5021-56e1-4589-bf69-75bda2b5941a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c84d3c07-add1-4a59-a295-c9b4bbd24f30"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e27ce521-9cfb-4dba-a4bf-145a6ef517aa"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10114f6e-e5bf-4b6f-9c86-3595d6fbc363"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2332fe6d-a770-4ea0-8a13-4213c8205850"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a8ed28e-374c-4327-b4a1-33409a466b0e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a96650cd-4e43-435d-9de7-70033f9f2ab5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("77e323f4-f3a3-4b59-9ae1-858ea7620f55"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63b7f8c2-198d-4e87-985d-440fb8161b4a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("77e3aa73-b718-4656-bc6d-9d160a25dd0a"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c2b604f-68ce-42d2-9d94-e59d0398ef7b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("152506d3-6edc-482d-beee-33b1aba02d02"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a4cea99b-42b6-4f5d-815a-8c95f302f37d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("142d98b1-8622-4260-9eb1-65e79fa347bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("915a60e1-837b-4f88-ae7b-ddb080f8861d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("73b0a206-3975-4f6d-bdd9-ce29af584838"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b16576d4-81c0-4f99-9e1b-37fac9b33c19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("09d1c22c-ecf6-44f5-a5d1-7981dd749b75"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fdbcfeb6-7dbf-457c-baeb-4e581dc40e67"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("812a69b9-af25-4e58-a03a-d45393cad890"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9cb414fb-3ed7-48c8-b901-241036e33456"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d35259f-342e-4d2b-96f3-298be907f658"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d81ae79-caee-459d-babe-cd5f51a105f3"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7007d4bd-7e5a-4983-9aca-94fdd52166e0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("96abc292-9391-402c-a20e-b2e0112b82c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("77e9addc-bae2-49f8-a9f9-c01f206659f0"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2cafba97-5b68-4ded-bfef-4f385f3c1822"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("153c7be8-c6d5-430d-b80e-e731b6a35cef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a81b8d5-2cbb-468f-a506-79c7e921e6bc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("014a1f0f-248a-4381-b953-6a82c5ea4e18"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("412ab565-eea9-40a3-b214-2545db45a547"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f1667e9e-9064-421d-bb90-eb3e26c27dab"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d03ac06-4686-4e82-b7c9-9a592c2b849c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1f657b4-dea8-452c-b59c-105ff79a5aeb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3c868464-0f44-4674-ab23-2dbd149a47c7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a05925c-44f9-4d6b-826c-04fd40beb0d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d403c11e-247e-4944-9343-e80a149ba63b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("34de03f6-6041-4b40-8a9a-e6e6eb468f63"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("90286bd9-1d31-49fe-8459-f91ee05baa1f"))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0e2d8f27-7e9d-46ef-946a-372bb60c4a4d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b94ad677-f2d8-4115-a141-73619b3f9fc7"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70fe1787-6de3-458d-8204-283ec6d2518c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3dd5f8c9-6b65-49cf-a165-cf0ea24cc060"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6017900c-a378-4d8f-ae7d-ee9d287b17a3"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e844e2b3-7761-4d82-a199-fad48972c618"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f3dd112-4c36-406a-a26d-0db530dd551c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc3d6375-76b3-473f-ac1c-758cac3c5a5b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("51397849-e967-4025-8fba-440805c63085"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("56598378-09c7-4a5b-96fa-b06780d079e5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dc81de88-f926-43b5-a397-b1c8359d4735"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f5c22451-84df-4b79-b88c-718114d3c3ca"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a4ea4fd2-11f9-453a-8a76-680db292dc2e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a285360b-fa90-488f-8b13-dd91799fb1c3"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1515cd7d-6b04-452b-a680-f1e27d841097"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4e9515c6-b92d-4f80-965a-b309581d0f85"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("765be33d-05c1-4090-8774-7d66b5c69abc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("67dfba52-551a-42ae-ba11-1489989866c9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("003ea050-9d65-4ee4-82cd-2996d69436a2"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d65728dc-2f3c-44f5-a61e-b8ec22ff4418"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7ea8b46d-409f-40b2-9cc0-a1506c33b52c"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9149037-40a0-4f7c-9626-c306f2d31fbc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b0bdaca9-64d1-4673-bff1-c2e7eaf06168"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd186082-8533-4c3e-ac5f-e3288bc66516"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("87df23dc-8924-476c-aa5d-b06c7e4c3008"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4b1ec10-a8be-4acb-9199-670eab0f87d7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cd44a6d4-e62b-4262-a37e-6f78a128e839"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f8b81b5-681f-4168-ac88-ecded954ac59"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b09b5021-56e1-4589-bf69-75bda2b5941a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c84d3c07-add1-4a59-a295-c9b4bbd24f30"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e27ce521-9cfb-4dba-a4bf-145a6ef517aa"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("10114f6e-e5bf-4b6f-9c86-3595d6fbc363"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2332fe6d-a770-4ea0-8a13-4213c8205850"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7a8ed28e-374c-4327-b4a1-33409a466b0e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a96650cd-4e43-435d-9de7-70033f9f2ab5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("77e323f4-f3a3-4b59-9ae1-858ea7620f55"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63b7f8c2-198d-4e87-985d-440fb8161b4a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("77e3aa73-b718-4656-bc6d-9d160a25dd0a"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1c2b604f-68ce-42d2-9d94-e59d0398ef7b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("152506d3-6edc-482d-beee-33b1aba02d02"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a4cea99b-42b6-4f5d-815a-8c95f302f37d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("142d98b1-8622-4260-9eb1-65e79fa347bb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("915a60e1-837b-4f88-ae7b-ddb080f8861d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("73b0a206-3975-4f6d-bdd9-ce29af584838"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b16576d4-81c0-4f99-9e1b-37fac9b33c19"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("09d1c22c-ecf6-44f5-a5d1-7981dd749b75"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fdbcfeb6-7dbf-457c-baeb-4e581dc40e67"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("812a69b9-af25-4e58-a03a-d45393cad890"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9cb414fb-3ed7-48c8-b901-241036e33456"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d35259f-342e-4d2b-96f3-298be907f658"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3d81ae79-caee-459d-babe-cd5f51a105f3"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7007d4bd-7e5a-4983-9aca-94fdd52166e0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("96abc292-9391-402c-a20e-b2e0112b82c5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("77e9addc-bae2-49f8-a9f9-c01f206659f0"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2cafba97-5b68-4ded-bfef-4f385f3c1822"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("153c7be8-c6d5-430d-b80e-e731b6a35cef"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1a81b8d5-2cbb-468f-a506-79c7e921e6bc"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("014a1f0f-248a-4381-b953-6a82c5ea4e18"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("412ab565-eea9-40a3-b214-2545db45a547"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f1667e9e-9064-421d-bb90-eb3e26c27dab"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4d03ac06-4686-4e82-b7c9-9a592c2b849c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a1f657b4-dea8-452c-b59c-105ff79a5aeb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3c868464-0f44-4674-ab23-2dbd149a47c7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5a05925c-44f9-4d6b-826c-04fd40beb0d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d403c11e-247e-4944-9343-e80a149ba63b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("34de03f6-6041-4b40-8a9a-e6e6eb468f63"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("90286bd9-1d31-49fe-8459-f91ee05baa1f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

