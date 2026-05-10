

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
    Id = 6,
    Value = Guid.Parse("6bff1399-f3a3-4f71-9ad0-b610d9100b1f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 7,
    Value = Guid.Parse("6338502f-c34a-4db4-85a9-3a78aed9607a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 4,
    Value = Guid.Parse("443702da-f8fb-4026-b0c0-4a7e92da9849"),
    NullableValue = Guid.Parse("725f2c54-d909-4d21-9352-4394f57644f8"),
},
    NullableValue = Guid.Parse("2e72ee01-7332-4806-a21b-cf7bf5410af1"),
},
            new Guiduniqueidentifier0M
{
    Id = 16,
    Value = Guid.Parse("444ab105-28bf-4941-8634-6ce4ad6d9ac6"),
    ModelInner = null,
    NullableValue = Guid.Parse("5a910801-c6ba-4763-9d81-a523d44fea43"),
},
            new Guiduniqueidentifier0M
{
    Id = 21,
    Value = Guid.Parse("ad2e04f0-2db5-469b-8d9c-df288780d488"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 9,
    Value = Guid.Parse("1b82f466-6ce8-41e8-b3b3-a847797d61e1"),
    NullableValue = Guid.Parse("d9598b6c-5863-45fe-ad0f-8dc2b1861a00"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 23,
    Value = Guid.Parse("af39a6ec-45e9-4852-bc57-9b6a372c827d"),
    ModelInner = null,
    NullableValue = Guid.Parse("8f4be15c-187f-4b3d-b095-0b092016c9eb"),
},
            new Guiduniqueidentifier0M
{
    Id = 25,
    Value = Guid.Parse("e0fe1d56-0fe2-47a1-b194-b969da9d4a8a"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 16,
    Value = Guid.Parse("9edde217-60ae-461b-a94a-77eaedef8af3"),
    NullableValue = Guid.Parse("a168fcb0-631a-402e-afd6-ed5efbcf27bc"),
},
    NullableValue = Guid.Parse("fcd89eb5-7770-462e-8054-a6f6ebe823da"),
},
            new Guiduniqueidentifier0M
{
    Id = 34,
    Value = Guid.Parse("df574f7b-312c-439d-b1b4-dfd2e47927fd"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 37,
    Value = Guid.Parse("b9c8d3d1-1a1d-4c71-b509-fda47cc34fe7"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 22,
    Value = Guid.Parse("92f2ba35-fb19-4091-8604-aacf79888408"),
    NullableValue = Guid.Parse("575150bb-c958-470a-ba0e-376ac8b53b00"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 38,
    Value = Guid.Parse("6e1541f9-53a6-41a2-a161-540b221b0f25"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 46,
    Value = Guid.Parse("ad3dbff6-47a1-4441-ad97-5c77b68e6314"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 25,
    Value = Guid.Parse("7026b453-c0b9-4ab8-87de-d586c0d8f583"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 55,
    Value = Guid.Parse("504e5852-8ee9-417a-aca9-9365102aca58"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 61,
    Value = Guid.Parse("797734df-6a92-4a27-975e-a84f25328e8f"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 32,
    Value = Guid.Parse("fcb6984c-01f7-48dc-ac3a-1f61dfdf9c5d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("85123aa7-3b5e-46bf-beb7-cd8f7722cdb6"),
},
            new Guiduniqueidentifier0M
{
    Id = 67,
    Value = Guid.Parse("4f47784b-ef51-4435-bbc2-ab44a77e8e2b"),
    ModelInner = null,
    NullableValue = Guid.Parse("6d9a19d2-5758-4590-849b-2318c7492310"),
},
            new Guiduniqueidentifier0M
{
    Id = 70,
    Value = Guid.Parse("9ecc9850-d54f-4bab-9f67-cd21aae5af15"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 41,
    Value = Guid.Parse("e1c17a1b-99a2-4d0a-8e90-adece7a52afb"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 77,
    Value = Guid.Parse("3bc43139-e9e6-4ed5-b9c0-19d01d7821d0"),
    ModelInner = null,
    NullableValue = Guid.Parse("6055523e-362c-48a8-9c6f-0ef989927b1b"),
},
            new Guiduniqueidentifier0M
{
    Id = 80,
    Value = Guid.Parse("88a81438-9ddf-43cd-826b-c25a161f204c"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 47,
    Value = Guid.Parse("2c66f7af-83be-49ac-9c67-71ef09c853db"),
    NullableValue = Guid.Parse("5016d1ea-90ee-4799-8496-34691550eeef"),
},
    NullableValue = Guid.Parse("4c4b52d1-d79a-4c47-8276-c3e6d440a4af"),
},
            new Guiduniqueidentifier0M
{
    Id = 81,
    Value = Guid.Parse("22b679d0-71b5-4d26-b5e6-6febcf30ce27"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 85,
    Value = Guid.Parse("44b7f5cb-6de7-4cf8-ae64-cc0b25e5f940"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 52,
    Value = Guid.Parse("8716791f-a91d-4b40-b6ce-0f186093b150"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 94,
    Value = Guid.Parse("3ab930f2-53cc-4473-a0a1-a936c5ddc39c"),
    ModelInner = null,
    NullableValue = Guid.Parse("c2641dbd-8a71-47e5-abe0-b7c6af13fe62"),
},
            new Guiduniqueidentifier0M
{
    Id = 103,
    Value = Guid.Parse("152c8f59-02e8-44c5-ae89-d3a676b35bff"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 59,
    Value = Guid.Parse("f942a673-571b-48da-8fa5-dcb584e70324"),
    NullableValue = Guid.Parse("d0d9fb2a-aced-4229-988d-bc853ecffc47"),
},
    NullableValue = Guid.Parse("cbf88510-aa9f-4312-a67a-f8835aa3d163"),
},
            new Guiduniqueidentifier0M
{
    Id = 106,
    Value = Guid.Parse("cf1a0c2f-47ab-493b-9007-38eb7ecf4af5"),
    ModelInner = null,
    NullableValue = Guid.Parse("1de48158-9d65-4b9e-bf35-d81441fba625"),
},
            new Guiduniqueidentifier0M
{
    Id = 114,
    Value = Guid.Parse("bb761cf8-7b9b-4538-97ec-871889fd8229"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 61,
    Value = Guid.Parse("f3852e3c-4208-4abd-b313-94d82a6781a7"),
    NullableValue = Guid.Parse("fe5d4ba7-fbee-4c75-a347-e85fe30cf460"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 117,
    Value = Guid.Parse("aa5a2908-d38e-48da-8c75-75976c39221f"),
    ModelInner = null,
    NullableValue = Guid.Parse("802f80b0-9f5d-4681-a8da-13b166543728"),
},
            new Guiduniqueidentifier0M
{
    Id = 123,
    Value = Guid.Parse("aaa9c8e9-2e03-431a-baf9-ab25ca9f074b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 68,
    Value = Guid.Parse("4ba18b43-7427-4fc2-a41c-3144486ab268"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 129,
    Value = Guid.Parse("b076f75c-115b-4ada-9f97-92b94afec1ee"),
    ModelInner = null,
    NullableValue = Guid.Parse("c569dbbb-1221-4f31-b513-f5aa974c26b5"),
},
            new Guiduniqueidentifier0M
{
    Id = 136,
    Value = Guid.Parse("bda5c844-c68e-4ba2-b551-59a182ced22d"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 74,
    Value = Guid.Parse("feef0f10-eb56-4a60-8f23-b4e1df7a5a5c"),
    NullableValue = Guid.Parse("644b6e39-2859-40f3-9c13-31334731a58d"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 137,
    Value = Guid.Parse("cc8a8ec3-5d65-469a-8c2c-0832f4f66aa9"),
    ModelInner = null,
    NullableValue = Guid.Parse("1b359cd1-f6f4-49f7-9fa8-d78973fcbeba"),
},
            new Guiduniqueidentifier0M
{
    Id = 146,
    Value = Guid.Parse("afdc8dc5-594d-48df-90fb-0f71a9c14a0b"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 83,
    Value = Guid.Parse("9cf0cdd8-9b98-4e35-bd63-841c00b3ab59"),
    NullableValue = Guid.Parse("36e5d849-1c14-40c2-80f0-dc88335ea985"),
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 151,
    Value = Guid.Parse("add9271a-7baa-4c21-8b8e-011321d170f0"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 152,
    Value = Guid.Parse("d8522c2e-b2ca-4a02-ab25-0dfcdc4a43cf"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 86,
    Value = Guid.Parse("bcb0451a-0adc-4175-83f9-685c79d6d4ca"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 158,
    Value = Guid.Parse("e7af6d20-e5ac-44c7-8c0b-926b25cca3f1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 159,
    Value = Guid.Parse("20243a3a-4fab-4225-bc9d-93b0e54051ec"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 88,
    Value = Guid.Parse("83b3a966-245d-4bcb-ab25-839dcfce254a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 167,
    Value = Guid.Parse("70bab308-7e64-45e4-9025-a38debad389c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 175,
    Value = Guid.Parse("fb902b2f-f0f7-4781-89b7-bfd57f6c2d86"),
    ModelInner = new Guiduniqueidentifier0MI
{
    Id = 96,
    Value = Guid.Parse("2e0ed6a2-8bc9-433f-92fd-1762782091fe"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduniqueidentifier0M
{
    Id = 179,
    Value = Guid.Parse("b6abb652-215f-4914-847d-7fc61677efed"),
    ModelInner = null,
    NullableValue = Guid.Parse("a84b556e-c22a-4c15-992e-8a9628c4e6b4"),
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 34;
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[9], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[10], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[11], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[12], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[13], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[14], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[15], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[16], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[17], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[18], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[19], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[20], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[17],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[18],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[19],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[20],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[21],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[22],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[23],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[24],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[21], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[22], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[23], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[24], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[10],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[11],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[7],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[8],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 21, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduniqueidentifier0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[34], false);
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
                await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 146, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduniqueidentifier0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(models[11],_testData[34], false);
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
                 ((IGuidSingleTypeuniqueidentifier)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
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
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduniqueidentifier0M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        Guiduniqueidentifier0M.AssertModel(models[12],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[13],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[14],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[15],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        Guiduniqueidentifier0M.AssertModel(models[27],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[28],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[29],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[30],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[31],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSTSelectModelBatch(connection, 167, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guiduniqueidentifier0M.AssertModel(models[0],_testData[28], false);
                        Guiduniqueidentifier0M.AssertModel(models[1],_testData[29], false);
                        Guiduniqueidentifier0M.AssertModel(models[2],_testData[30], false);
                        Guiduniqueidentifier0M.AssertModel(models[3],_testData[31], false);
                        Guiduniqueidentifier0M.AssertModel(models[4],_testData[32], false);
                        Guiduniqueidentifier0M.AssertModel(models[5],_testData[33], false);
                        Guiduniqueidentifier0M.AssertModel(models[6],_testData[34], false);
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
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Guiduniqueidentifier0M.AssertModel(models[0],_testData[19], false);
                Guiduniqueidentifier0M.AssertModel(models[1],_testData[20], false);
                Guiduniqueidentifier0M.AssertModel(models[2],_testData[21], false);
                Guiduniqueidentifier0M.AssertModel(models[3],_testData[22], false);
                Guiduniqueidentifier0M.AssertModel(models[4],_testData[23], false);
                Guiduniqueidentifier0M.AssertModel(models[5],_testData[24], false);
                Guiduniqueidentifier0M.AssertModel(models[6],_testData[25], false);
                Guiduniqueidentifier0M.AssertModel(models[7],_testData[26], false);
                Guiduniqueidentifier0M.AssertModel(models[8],_testData[27], false);
                Guiduniqueidentifier0M.AssertModel(models[9],_testData[28], false);
                Guiduniqueidentifier0M.AssertModel(models[10],_testData[29], false);
                Guiduniqueidentifier0M.AssertModel(models[11],_testData[30], false);
                Guiduniqueidentifier0M.AssertModel(models[12],_testData[31], false);
                Guiduniqueidentifier0M.AssertModel(models[13],_testData[32], false);
                Guiduniqueidentifier0M.AssertModel(models[14],_testData[33], false);
                Guiduniqueidentifier0M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6bff1399-f3a3-4f71-9ad0-b610d9100b1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6338502f-c34a-4db4-85a9-3a78aed9607a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("443702da-f8fb-4026-b0c0-4a7e92da9849"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("725f2c54-d909-4d21-9352-4394f57644f8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2e72ee01-7332-4806-a21b-cf7bf5410af1"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("444ab105-28bf-4941-8634-6ce4ad6d9ac6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5a910801-c6ba-4763-9d81-a523d44fea43"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad2e04f0-2db5-469b-8d9c-df288780d488"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b82f466-6ce8-41e8-b3b3-a847797d61e1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d9598b6c-5863-45fe-ad0f-8dc2b1861a00"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af39a6ec-45e9-4852-bc57-9b6a372c827d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f4be15c-187f-4b3d-b095-0b092016c9eb"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0fe1d56-0fe2-47a1-b194-b969da9d4a8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9edde217-60ae-461b-a94a-77eaedef8af3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a168fcb0-631a-402e-afd6-ed5efbcf27bc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fcd89eb5-7770-462e-8054-a6f6ebe823da"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df574f7b-312c-439d-b1b4-dfd2e47927fd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9c8d3d1-1a1d-4c71-b509-fda47cc34fe7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("92f2ba35-fb19-4091-8604-aacf79888408"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("575150bb-c958-470a-ba0e-376ac8b53b00"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6e1541f9-53a6-41a2-a161-540b221b0f25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad3dbff6-47a1-4441-ad97-5c77b68e6314"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7026b453-c0b9-4ab8-87de-d586c0d8f583"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("504e5852-8ee9-417a-aca9-9365102aca58"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("797734df-6a92-4a27-975e-a84f25328e8f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fcb6984c-01f7-48dc-ac3a-1f61dfdf9c5d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85123aa7-3b5e-46bf-beb7-cd8f7722cdb6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f47784b-ef51-4435-bbc2-ab44a77e8e2b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d9a19d2-5758-4590-849b-2318c7492310"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ecc9850-d54f-4bab-9f67-cd21aae5af15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1c17a1b-99a2-4d0a-8e90-adece7a52afb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bc43139-e9e6-4ed5-b9c0-19d01d7821d0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6055523e-362c-48a8-9c6f-0ef989927b1b"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88a81438-9ddf-43cd-826b-c25a161f204c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c66f7af-83be-49ac-9c67-71ef09c853db"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5016d1ea-90ee-4799-8496-34691550eeef"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c4b52d1-d79a-4c47-8276-c3e6d440a4af"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22b679d0-71b5-4d26-b5e6-6febcf30ce27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44b7f5cb-6de7-4cf8-ae64-cc0b25e5f940"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8716791f-a91d-4b40-b6ce-0f186093b150"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ab930f2-53cc-4473-a0a1-a936c5ddc39c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c2641dbd-8a71-47e5-abe0-b7c6af13fe62"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("152c8f59-02e8-44c5-ae89-d3a676b35bff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f942a673-571b-48da-8fa5-dcb584e70324"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d0d9fb2a-aced-4229-988d-bc853ecffc47"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbf88510-aa9f-4312-a67a-f8835aa3d163"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf1a0c2f-47ab-493b-9007-38eb7ecf4af5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1de48158-9d65-4b9e-bf35-d81441fba625"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb761cf8-7b9b-4538-97ec-871889fd8229"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3852e3c-4208-4abd-b313-94d82a6781a7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fe5d4ba7-fbee-4c75-a347-e85fe30cf460"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa5a2908-d38e-48da-8c75-75976c39221f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("802f80b0-9f5d-4681-a8da-13b166543728"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aaa9c8e9-2e03-431a-baf9-ab25ca9f074b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4ba18b43-7427-4fc2-a41c-3144486ab268"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b076f75c-115b-4ada-9f97-92b94afec1ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c569dbbb-1221-4f31-b513-f5aa974c26b5"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bda5c844-c68e-4ba2-b551-59a182ced22d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("feef0f10-eb56-4a60-8f23-b4e1df7a5a5c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("644b6e39-2859-40f3-9c13-31334731a58d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc8a8ec3-5d65-469a-8c2c-0832f4f66aa9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1b359cd1-f6f4-49f7-9fa8-d78973fcbeba"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afdc8dc5-594d-48df-90fb-0f71a9c14a0b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9cf0cdd8-9b98-4e35-bd63-841c00b3ab59"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("36e5d849-1c14-40c2-80f0-dc88335ea985"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("add9271a-7baa-4c21-8b8e-011321d170f0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8522c2e-b2ca-4a02-ab25-0dfcdc4a43cf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bcb0451a-0adc-4175-83f9-685c79d6d4ca"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7af6d20-e5ac-44c7-8c0b-926b25cca3f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20243a3a-4fab-4225-bc9d-93b0e54051ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("83b3a966-245d-4bcb-ab25-839dcfce254a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70bab308-7e64-45e4-9025-a38debad389c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb902b2f-f0f7-4781-89b7-bfd57f6c2d86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e0ed6a2-8bc9-433f-92fd-1762782091fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6abb652-215f-4914-847d-7fc61677efed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a84b556e-c22a-4c15-992e-8a9628c4e6b4"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6bff1399-f3a3-4f71-9ad0-b610d9100b1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6338502f-c34a-4db4-85a9-3a78aed9607a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("443702da-f8fb-4026-b0c0-4a7e92da9849"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("725f2c54-d909-4d21-9352-4394f57644f8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2e72ee01-7332-4806-a21b-cf7bf5410af1"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("444ab105-28bf-4941-8634-6ce4ad6d9ac6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5a910801-c6ba-4763-9d81-a523d44fea43"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad2e04f0-2db5-469b-8d9c-df288780d488"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1b82f466-6ce8-41e8-b3b3-a847797d61e1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d9598b6c-5863-45fe-ad0f-8dc2b1861a00"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("af39a6ec-45e9-4852-bc57-9b6a372c827d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8f4be15c-187f-4b3d-b095-0b092016c9eb"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e0fe1d56-0fe2-47a1-b194-b969da9d4a8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9edde217-60ae-461b-a94a-77eaedef8af3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a168fcb0-631a-402e-afd6-ed5efbcf27bc"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fcd89eb5-7770-462e-8054-a6f6ebe823da"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("df574f7b-312c-439d-b1b4-dfd2e47927fd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b9c8d3d1-1a1d-4c71-b509-fda47cc34fe7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("92f2ba35-fb19-4091-8604-aacf79888408"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("575150bb-c958-470a-ba0e-376ac8b53b00"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6e1541f9-53a6-41a2-a161-540b221b0f25"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ad3dbff6-47a1-4441-ad97-5c77b68e6314"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7026b453-c0b9-4ab8-87de-d586c0d8f583"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("504e5852-8ee9-417a-aca9-9365102aca58"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("797734df-6a92-4a27-975e-a84f25328e8f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("fcb6984c-01f7-48dc-ac3a-1f61dfdf9c5d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85123aa7-3b5e-46bf-beb7-cd8f7722cdb6"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f47784b-ef51-4435-bbc2-ab44a77e8e2b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6d9a19d2-5758-4590-849b-2318c7492310"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9ecc9850-d54f-4bab-9f67-cd21aae5af15"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e1c17a1b-99a2-4d0a-8e90-adece7a52afb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3bc43139-e9e6-4ed5-b9c0-19d01d7821d0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6055523e-362c-48a8-9c6f-0ef989927b1b"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("88a81438-9ddf-43cd-826b-c25a161f204c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2c66f7af-83be-49ac-9c67-71ef09c853db"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5016d1ea-90ee-4799-8496-34691550eeef"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c4b52d1-d79a-4c47-8276-c3e6d440a4af"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("22b679d0-71b5-4d26-b5e6-6febcf30ce27"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("44b7f5cb-6de7-4cf8-ae64-cc0b25e5f940"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8716791f-a91d-4b40-b6ce-0f186093b150"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ab930f2-53cc-4473-a0a1-a936c5ddc39c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c2641dbd-8a71-47e5-abe0-b7c6af13fe62"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("152c8f59-02e8-44c5-ae89-d3a676b35bff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f942a673-571b-48da-8fa5-dcb584e70324"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d0d9fb2a-aced-4229-988d-bc853ecffc47"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cbf88510-aa9f-4312-a67a-f8835aa3d163"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf1a0c2f-47ab-493b-9007-38eb7ecf4af5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1de48158-9d65-4b9e-bf35-d81441fba625"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb761cf8-7b9b-4538-97ec-871889fd8229"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3852e3c-4208-4abd-b313-94d82a6781a7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fe5d4ba7-fbee-4c75-a347-e85fe30cf460"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aa5a2908-d38e-48da-8c75-75976c39221f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("802f80b0-9f5d-4681-a8da-13b166543728"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aaa9c8e9-2e03-431a-baf9-ab25ca9f074b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4ba18b43-7427-4fc2-a41c-3144486ab268"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b076f75c-115b-4ada-9f97-92b94afec1ee"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c569dbbb-1221-4f31-b513-f5aa974c26b5"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bda5c844-c68e-4ba2-b551-59a182ced22d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("feef0f10-eb56-4a60-8f23-b4e1df7a5a5c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("644b6e39-2859-40f3-9c13-31334731a58d"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc8a8ec3-5d65-469a-8c2c-0832f4f66aa9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1b359cd1-f6f4-49f7-9fa8-d78973fcbeba"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("afdc8dc5-594d-48df-90fb-0f71a9c14a0b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9cf0cdd8-9b98-4e35-bd63-841c00b3ab59"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("36e5d849-1c14-40c2-80f0-dc88335ea985"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("add9271a-7baa-4c21-8b8e-011321d170f0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8522c2e-b2ca-4a02-ab25-0dfcdc4a43cf"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bcb0451a-0adc-4175-83f9-685c79d6d4ca"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7af6d20-e5ac-44c7-8c0b-926b25cca3f1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("20243a3a-4fab-4225-bc9d-93b0e54051ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("83b3a966-245d-4bcb-ab25-839dcfce254a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70bab308-7e64-45e4-9025-a38debad389c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fb902b2f-f0f7-4781-89b7-bfd57f6c2d86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e0ed6a2-8bc9-433f-92fd-1762782091fe"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6abb652-215f-4914-847d-7fc61677efed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a84b556e-c22a-4c15-992e-8a9628c4e6b4"))));

            }
        }

#endregion

    }
}

