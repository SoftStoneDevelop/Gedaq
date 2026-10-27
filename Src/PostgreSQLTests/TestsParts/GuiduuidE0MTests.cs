

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

        private readonly GuiduuidE0M[] _testData = new GuiduuidE0M[]
        {
            new GuiduuidE0M
{
    Id = 9,
    Value = Guid.Parse("ef3c2853-33da-4264-b7ab-0e4b39394a9b"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 11,
    Value = Guid.Parse("b25389ac-1e62-4117-b0a9-07f54ae6cb20"),
    ModelInner = new GuiduuidE0MI
{
    Id = 8,
    Value = Guid.Parse("1e5e6466-91d7-42ae-9c92-a4a0228de77a"),
    NullableValue = Guid.Parse("b54dab4b-a01f-4196-8481-daae3fa2f408"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 17,
    Value = Guid.Parse("1d85f966-7252-4946-a387-41538daffd35"),
    ModelInner = null,
    NullableValue = Guid.Parse("7269b1e2-a5c1-41ea-9014-bdfbd18bbaa8"),
},
            new GuiduuidE0M
{
    Id = 18,
    Value = Guid.Parse("63657446-ae17-4ca5-9a5d-3b91141de3a1"),
    ModelInner = new GuiduuidE0MI
{
    Id = 14,
    Value = Guid.Parse("a6c3b3ae-a55e-4810-880b-e97e4592dcfa"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 25,
    Value = Guid.Parse("fdfc4f77-1ac5-49c9-855b-5dc1d4c2e446"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 33,
    Value = Guid.Parse("de84a91d-6f4a-483d-bb49-de396f08d571"),
    ModelInner = new GuiduuidE0MI
{
    Id = 17,
    Value = Guid.Parse("7e2b7cd1-d7a7-475b-994a-7a111c8aa727"),
    NullableValue = Guid.Parse("2aff4690-8fb3-4b2e-a772-fd3dccad1641"),
},
    NullableValue = Guid.Parse("c7c87e8b-d6dd-49f8-8e95-0621f36dac3b"),
},
            new GuiduuidE0M
{
    Id = 35,
    Value = Guid.Parse("f0a7f2ee-1dc9-4264-9242-5fff5b5f8dfc"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 44,
    Value = Guid.Parse("e495d4e3-87ba-443f-b9ff-d665cfad324b"),
    ModelInner = new GuiduuidE0MI
{
    Id = 19,
    Value = Guid.Parse("a98aabfb-08bf-4a26-8e79-be4d9c0444b7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 49,
    Value = Guid.Parse("7af6dba3-fbc2-495c-92d8-e4b959d9394b"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 56,
    Value = Guid.Parse("48ba04b4-6c13-49b0-b967-0a46dcb6b6ea"),
    ModelInner = new GuiduuidE0MI
{
    Id = 25,
    Value = Guid.Parse("0702eaaf-422b-4273-a1b9-fafc387d411f"),
    NullableValue = Guid.Parse("d5c6e473-35df-4b4c-8d63-7a1074a21f5c"),
},
    NullableValue = Guid.Parse("d4381579-0384-4099-86aa-b3b38911c4c2"),
},
            new GuiduuidE0M
{
    Id = 57,
    Value = Guid.Parse("f40e1d2f-28f6-47d9-9d39-8e637bcee6f9"),
    ModelInner = null,
    NullableValue = Guid.Parse("4c3fbeaf-7c81-4d32-8d95-64d3e872c8c6"),
},
            new GuiduuidE0M
{
    Id = 59,
    Value = Guid.Parse("1ab8aa65-45d5-48ed-8e54-3ca89042e9b8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 31,
    Value = Guid.Parse("b0fcd080-b4c4-479a-86c1-b32c868e189c"),
    NullableValue = Guid.Parse("5d7c87cc-1c8d-488e-8fcb-0defa207ef14"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 63,
    Value = Guid.Parse("32b4c459-494b-4c5a-b5b3-5fa01425779a"),
    ModelInner = null,
    NullableValue = Guid.Parse("01e72354-4db4-4929-9aa8-8bf87b07df11"),
},
            new GuiduuidE0M
{
    Id = 65,
    Value = Guid.Parse("38dfb23e-29c6-4753-bfdf-23df2369c722"),
    ModelInner = new GuiduuidE0MI
{
    Id = 36,
    Value = Guid.Parse("3e4ce548-557e-4994-91b6-762e167398f0"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 69,
    Value = Guid.Parse("5f21eac7-735a-4de0-9005-adc2f420cd38"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 72,
    Value = Guid.Parse("bb52c7b8-6ad0-4574-81b8-8b904915a2b9"),
    ModelInner = new GuiduuidE0MI
{
    Id = 40,
    Value = Guid.Parse("2e345571-0963-4f55-9b57-0d614eaa9f34"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 79,
    Value = Guid.Parse("ba5a4e34-33e3-442d-bf0c-a10be44fc8cc"),
    ModelInner = null,
    NullableValue = Guid.Parse("41e3d157-d806-48c9-93b1-ab4d0911c193"),
},
            new GuiduuidE0M
{
    Id = 86,
    Value = Guid.Parse("c1fd296e-dcd9-4d5c-b382-8a755c79e8b3"),
    ModelInner = new GuiduuidE0MI
{
    Id = 42,
    Value = Guid.Parse("9d29f9d4-59f6-470f-b1ad-3eca6b4d5506"),
    NullableValue = Guid.Parse("73383f94-42c3-454a-8009-6a55fcc6f569"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 90,
    Value = Guid.Parse("2a73bba2-1efa-438e-a388-15442009fc5e"),
    ModelInner = null,
    NullableValue = Guid.Parse("a8bb1621-3085-48d5-b03d-c0ac99ae91be"),
},
            new GuiduuidE0M
{
    Id = 93,
    Value = Guid.Parse("b4652e61-d26c-4318-a3eb-c9b0a3366bb7"),
    ModelInner = new GuiduuidE0MI
{
    Id = 51,
    Value = Guid.Parse("4b625b60-297b-4f59-aca4-e0015be692b8"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("99621063-6a22-4190-8c68-2ba99e5cd895"),
},
            new GuiduuidE0M
{
    Id = 97,
    Value = Guid.Parse("9324f49f-6511-4767-9896-35dec0272a39"),
    ModelInner = null,
    NullableValue = Guid.Parse("3c9b6b12-481f-4456-a322-fb6e5f2d569d"),
},
            new GuiduuidE0M
{
    Id = 99,
    Value = Guid.Parse("be98af58-b3bb-4a04-9eaf-66fb9bba6171"),
    ModelInner = new GuiduuidE0MI
{
    Id = 54,
    Value = Guid.Parse("56c64dfa-b95b-414c-bac1-69abe5890881"),
    NullableValue = Guid.Parse("b6fa14d6-fd3a-4b98-b440-ab643f3f6955"),
},
    NullableValue = Guid.Parse("2ee28161-a5c7-4ace-a475-85364a205495"),
},
            new GuiduuidE0M
{
    Id = 107,
    Value = Guid.Parse("d1c22225-d253-4b03-9e81-807466dcf677"),
    ModelInner = null,
    NullableValue = Guid.Parse("1d25e055-7e6b-4f49-897c-1000c3b60c6f"),
},
            new GuiduuidE0M
{
    Id = 110,
    Value = Guid.Parse("f22fa3b4-6bf2-4c26-9e81-cf1fa3e677cb"),
    ModelInner = new GuiduuidE0MI
{
    Id = 56,
    Value = Guid.Parse("4efd56a8-af77-4be7-b4d3-ef912f469043"),
    NullableValue = Guid.Parse("b4f2c531-b10a-48bf-962d-87597628dca9"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 119,
    Value = Guid.Parse("6eccc10d-fcb9-4a84-933b-8479f3bcbc30"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 126,
    Value = Guid.Parse("ac7ebff3-f00a-4ec7-bfa4-59ffbe1a68cc"),
    ModelInner = new GuiduuidE0MI
{
    Id = 63,
    Value = Guid.Parse("4acb9a93-e47f-42a8-9ad9-ecfb61f53fd7"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3c34a930-21e4-4cec-b256-0cd8dc4f42d6"),
},
            new GuiduuidE0M
{
    Id = 127,
    Value = Guid.Parse("101c8e1a-261d-491f-9fa6-38e0f8e99668"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 133,
    Value = Guid.Parse("9930faf9-168f-407d-83f9-aed3a5c3a504"),
    ModelInner = new GuiduuidE0MI
{
    Id = 70,
    Value = Guid.Parse("f9dbfb15-d1f3-42da-a184-3ff9a0a8d2ed"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("91b6aa59-8144-4e60-bf28-4187be6237e7"),
},
            new GuiduuidE0M
{
    Id = 135,
    Value = Guid.Parse("ccdc04f6-5bb8-4cc6-8328-6a3de875c21e"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 141,
    Value = Guid.Parse("2f027fe2-2112-4b14-a969-7c7e4848daa8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 72,
    Value = Guid.Parse("af072908-05a6-47f2-8208-91d303d69092"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("f996f7ef-4813-4299-a8d3-663394c00cfa"),
},
            new GuiduuidE0M
{
    Id = 143,
    Value = Guid.Parse("a6b4bdd6-0248-4891-bc83-bbf56208bd34"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 152,
    Value = Guid.Parse("7b8322f7-7268-450d-bd10-cfe34b0e49e6"),
    ModelInner = new GuiduuidE0MI
{
    Id = 75,
    Value = Guid.Parse("510093a5-a4f1-48f3-8e9f-8be5e77a6bda"),
    NullableValue = Guid.Parse("9dbe3367-660b-453d-9317-2210ab1c0fa2"),
},
    NullableValue = Guid.Parse("e7baf5e3-d9af-4459-9edc-761ab2ad026d"),
},
            new GuiduuidE0M
{
    Id = 160,
    Value = Guid.Parse("1ea85238-d21d-45d5-ba34-17d23739df7e"),
    ModelInner = null,
    NullableValue = Guid.Parse("2ff19d3b-ef76-4bed-b024-115cf0177ff8"),
},
            new GuiduuidE0M
{
    Id = 163,
    Value = Guid.Parse("183254cc-696b-4b07-ba8b-d35946efd299"),
    ModelInner = new GuiduuidE0MI
{
    Id = 82,
    Value = Guid.Parse("23af0f43-e654-43d8-9ac4-5a691fd35858"),
    NullableValue = Guid.Parse("e1e1d8cd-ae79-4ca7-9578-430693aefeb8"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 170,
    Value = Guid.Parse("87270840-0152-4b7c-bf30-ddd38ecf64a6"),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0mi(
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
INSERT INTO public.guiduuide0mi(
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
            queryMapTypes: [typeof(GuiduuidE0MI)],
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
INSERT INTO public.guiduuide0mi(
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
                methodParametrName: "guiduuide0mi_id", 
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c7c87e8b-d6dd-49f8-8e95-0621f36dac3b")));
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
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
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
    guiduuide0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                methodParametrName: "guiduuide0mi_id", 
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("d4381579-0384-4099-86aa-b3b38911c4c2")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("4c3fbeaf-7c81-4d32-8d95-64d3e872c8c6")));
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
                List<GuiduuidE0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidE0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
	id,
    value,
    nullablevalue,
    guiduuide0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuide0mi_id
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
                parametrName: "guiduuide0mi_id", 
                methodParametrName: "guiduuide0mi_id", 
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
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
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
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 11;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr2.Value = 160;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
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
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 90;
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.guiduuide0m m
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
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidE0M.AssertModel(models[0],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidE0M.AssertModel(models[0],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[34], false);
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidE0M.AssertModel(models[0],_testData[4], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[5], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[6], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[28],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[29],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidE0M.AssertModel(models[0],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M), typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 152, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidE0M>();
                var models2 = new List<FlatGuiduuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var firstItems2 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidE0M)],
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 133, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[34], false);
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
FROM public.guiduuide0m m
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
FROM public.guiduuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidE0M>();
                var secondItems1 = new List<FlatGuiduuidE0M>();
                var secondItems2 = new List<FlatGuiduuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidE0M.AssertModel(models[0],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidE0M.AssertModel(models[0],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[34], false);
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
                    GuiduuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 135, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidE0M.AssertModel(models[0],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidE0M.AssertModel(models[0],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                GuiduuidE0M.AssertModel(models[0],_testData[14], false);
                GuiduuidE0M.AssertModel(models[1],_testData[15], false);
                GuiduuidE0M.AssertModel(models[2],_testData[16], false);
                GuiduuidE0M.AssertModel(models[3],_testData[17], false);
                GuiduuidE0M.AssertModel(models[4],_testData[18], false);
                GuiduuidE0M.AssertModel(models[5],_testData[19], false);
                GuiduuidE0M.AssertModel(models[6],_testData[20], false);
                GuiduuidE0M.AssertModel(models[7],_testData[21], false);
                GuiduuidE0M.AssertModel(models[8],_testData[22], false);
                GuiduuidE0M.AssertModel(models[9],_testData[23], false);
                GuiduuidE0M.AssertModel(models[10],_testData[24], false);
                GuiduuidE0M.AssertModel(models[11],_testData[25], false);
                GuiduuidE0M.AssertModel(models[12],_testData[26], false);
                GuiduuidE0M.AssertModel(models[13],_testData[27], false);
                GuiduuidE0M.AssertModel(models[14],_testData[28], false);
                GuiduuidE0M.AssertModel(models[15],_testData[29], false);
                GuiduuidE0M.AssertModel(models[16],_testData[30], false);
                GuiduuidE0M.AssertModel(models[17],_testData[31], false);
                GuiduuidE0M.AssertModel(models[18],_testData[32], false);
                GuiduuidE0M.AssertModel(models[19],_testData[33], false);
                GuiduuidE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                GuiduuidE0M.AssertModel(models[0],_testData[25], false);
                GuiduuidE0M.AssertModel(models[1],_testData[26], false);
                GuiduuidE0M.AssertModel(models[2],_testData[27], false);
                GuiduuidE0M.AssertModel(models[3],_testData[28], false);
                GuiduuidE0M.AssertModel(models[4],_testData[29], false);
                GuiduuidE0M.AssertModel(models[5],_testData[30], false);
                GuiduuidE0M.AssertModel(models[6],_testData[31], false);
                GuiduuidE0M.AssertModel(models[7],_testData[32], false);
                GuiduuidE0M.AssertModel(models[8],_testData[33], false);
                GuiduuidE0M.AssertModel(models[9],_testData[34], false);
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
FROM public.guiduuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef3c2853-33da-4264-b7ab-0e4b39394a9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b25389ac-1e62-4117-b0a9-07f54ae6cb20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1e5e6466-91d7-42ae-9c92-a4a0228de77a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b54dab4b-a01f-4196-8481-daae3fa2f408"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d85f966-7252-4946-a387-41538daffd35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7269b1e2-a5c1-41ea-9014-bdfbd18bbaa8"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63657446-ae17-4ca5-9a5d-3b91141de3a1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a6c3b3ae-a55e-4810-880b-e97e4592dcfa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fdfc4f77-1ac5-49c9-855b-5dc1d4c2e446"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("de84a91d-6f4a-483d-bb49-de396f08d571"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7e2b7cd1-d7a7-475b-994a-7a111c8aa727"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2aff4690-8fb3-4b2e-a772-fd3dccad1641"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c7c87e8b-d6dd-49f8-8e95-0621f36dac3b"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f0a7f2ee-1dc9-4264-9242-5fff5b5f8dfc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e495d4e3-87ba-443f-b9ff-d665cfad324b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a98aabfb-08bf-4a26-8e79-be4d9c0444b7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af6dba3-fbc2-495c-92d8-e4b959d9394b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("48ba04b4-6c13-49b0-b967-0a46dcb6b6ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0702eaaf-422b-4273-a1b9-fafc387d411f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d5c6e473-35df-4b4c-8d63-7a1074a21f5c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d4381579-0384-4099-86aa-b3b38911c4c2"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f40e1d2f-28f6-47d9-9d39-8e637bcee6f9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c3fbeaf-7c81-4d32-8d95-64d3e872c8c6"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ab8aa65-45d5-48ed-8e54-3ca89042e9b8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b0fcd080-b4c4-479a-86c1-b32c868e189c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5d7c87cc-1c8d-488e-8fcb-0defa207ef14"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("32b4c459-494b-4c5a-b5b3-5fa01425779a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01e72354-4db4-4929-9aa8-8bf87b07df11"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38dfb23e-29c6-4753-bfdf-23df2369c722"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3e4ce548-557e-4994-91b6-762e167398f0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f21eac7-735a-4de0-9005-adc2f420cd38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb52c7b8-6ad0-4574-81b8-8b904915a2b9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e345571-0963-4f55-9b57-0d614eaa9f34"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ba5a4e34-33e3-442d-bf0c-a10be44fc8cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("41e3d157-d806-48c9-93b1-ab4d0911c193"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1fd296e-dcd9-4d5c-b382-8a755c79e8b3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9d29f9d4-59f6-470f-b1ad-3eca6b4d5506"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("73383f94-42c3-454a-8009-6a55fcc6f569"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a73bba2-1efa-438e-a388-15442009fc5e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8bb1621-3085-48d5-b03d-c0ac99ae91be"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4652e61-d26c-4318-a3eb-c9b0a3366bb7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b625b60-297b-4f59-aca4-e0015be692b8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99621063-6a22-4190-8c68-2ba99e5cd895"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9324f49f-6511-4767-9896-35dec0272a39"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c9b6b12-481f-4456-a322-fb6e5f2d569d"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be98af58-b3bb-4a04-9eaf-66fb9bba6171"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("56c64dfa-b95b-414c-bac1-69abe5890881"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6fa14d6-fd3a-4b98-b440-ab643f3f6955"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ee28161-a5c7-4ace-a475-85364a205495"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1c22225-d253-4b03-9e81-807466dcf677"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d25e055-7e6b-4f49-897c-1000c3b60c6f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f22fa3b4-6bf2-4c26-9e81-cf1fa3e677cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4efd56a8-af77-4be7-b4d3-ef912f469043"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b4f2c531-b10a-48bf-962d-87597628dca9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6eccc10d-fcb9-4a84-933b-8479f3bcbc30"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac7ebff3-f00a-4ec7-bfa4-59ffbe1a68cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4acb9a93-e47f-42a8-9ad9-ecfb61f53fd7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c34a930-21e4-4cec-b256-0cd8dc4f42d6"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("101c8e1a-261d-491f-9fa6-38e0f8e99668"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9930faf9-168f-407d-83f9-aed3a5c3a504"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f9dbfb15-d1f3-42da-a184-3ff9a0a8d2ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("91b6aa59-8144-4e60-bf28-4187be6237e7"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccdc04f6-5bb8-4cc6-8328-6a3de875c21e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f027fe2-2112-4b14-a969-7c7e4848daa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("af072908-05a6-47f2-8208-91d303d69092"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f996f7ef-4813-4299-a8d3-663394c00cfa"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6b4bdd6-0248-4891-bc83-bbf56208bd34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b8322f7-7268-450d-bd10-cfe34b0e49e6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("510093a5-a4f1-48f3-8e9f-8be5e77a6bda"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9dbe3367-660b-453d-9317-2210ab1c0fa2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e7baf5e3-d9af-4459-9edc-761ab2ad026d"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ea85238-d21d-45d5-ba34-17d23739df7e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ff19d3b-ef76-4bed-b024-115cf0177ff8"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("183254cc-696b-4b07-ba8b-d35946efd299"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23af0f43-e654-43d8-9ac4-5a691fd35858"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1e1d8cd-ae79-4ca7-9578-430693aefeb8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87270840-0152-4b7c-bf30-ddd38ecf64a6"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef3c2853-33da-4264-b7ab-0e4b39394a9b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b25389ac-1e62-4117-b0a9-07f54ae6cb20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1e5e6466-91d7-42ae-9c92-a4a0228de77a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b54dab4b-a01f-4196-8481-daae3fa2f408"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d85f966-7252-4946-a387-41538daffd35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7269b1e2-a5c1-41ea-9014-bdfbd18bbaa8"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63657446-ae17-4ca5-9a5d-3b91141de3a1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a6c3b3ae-a55e-4810-880b-e97e4592dcfa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fdfc4f77-1ac5-49c9-855b-5dc1d4c2e446"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("de84a91d-6f4a-483d-bb49-de396f08d571"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7e2b7cd1-d7a7-475b-994a-7a111c8aa727"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2aff4690-8fb3-4b2e-a772-fd3dccad1641"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c7c87e8b-d6dd-49f8-8e95-0621f36dac3b"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f0a7f2ee-1dc9-4264-9242-5fff5b5f8dfc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e495d4e3-87ba-443f-b9ff-d665cfad324b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a98aabfb-08bf-4a26-8e79-be4d9c0444b7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7af6dba3-fbc2-495c-92d8-e4b959d9394b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("48ba04b4-6c13-49b0-b967-0a46dcb6b6ea"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0702eaaf-422b-4273-a1b9-fafc387d411f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("d5c6e473-35df-4b4c-8d63-7a1074a21f5c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d4381579-0384-4099-86aa-b3b38911c4c2"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f40e1d2f-28f6-47d9-9d39-8e637bcee6f9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c3fbeaf-7c81-4d32-8d95-64d3e872c8c6"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ab8aa65-45d5-48ed-8e54-3ca89042e9b8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b0fcd080-b4c4-479a-86c1-b32c868e189c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("5d7c87cc-1c8d-488e-8fcb-0defa207ef14"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("32b4c459-494b-4c5a-b5b3-5fa01425779a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("01e72354-4db4-4929-9aa8-8bf87b07df11"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38dfb23e-29c6-4753-bfdf-23df2369c722"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3e4ce548-557e-4994-91b6-762e167398f0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5f21eac7-735a-4de0-9005-adc2f420cd38"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb52c7b8-6ad0-4574-81b8-8b904915a2b9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2e345571-0963-4f55-9b57-0d614eaa9f34"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ba5a4e34-33e3-442d-bf0c-a10be44fc8cc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("41e3d157-d806-48c9-93b1-ab4d0911c193"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1fd296e-dcd9-4d5c-b382-8a755c79e8b3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9d29f9d4-59f6-470f-b1ad-3eca6b4d5506"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("73383f94-42c3-454a-8009-6a55fcc6f569"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a73bba2-1efa-438e-a388-15442009fc5e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a8bb1621-3085-48d5-b03d-c0ac99ae91be"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4652e61-d26c-4318-a3eb-c9b0a3366bb7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4b625b60-297b-4f59-aca4-e0015be692b8"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("99621063-6a22-4190-8c68-2ba99e5cd895"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9324f49f-6511-4767-9896-35dec0272a39"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c9b6b12-481f-4456-a322-fb6e5f2d569d"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("be98af58-b3bb-4a04-9eaf-66fb9bba6171"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("56c64dfa-b95b-414c-bac1-69abe5890881"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b6fa14d6-fd3a-4b98-b440-ab643f3f6955"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ee28161-a5c7-4ace-a475-85364a205495"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1c22225-d253-4b03-9e81-807466dcf677"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1d25e055-7e6b-4f49-897c-1000c3b60c6f"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f22fa3b4-6bf2-4c26-9e81-cf1fa3e677cb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4efd56a8-af77-4be7-b4d3-ef912f469043"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b4f2c531-b10a-48bf-962d-87597628dca9"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6eccc10d-fcb9-4a84-933b-8479f3bcbc30"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac7ebff3-f00a-4ec7-bfa4-59ffbe1a68cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4acb9a93-e47f-42a8-9ad9-ecfb61f53fd7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3c34a930-21e4-4cec-b256-0cd8dc4f42d6"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("101c8e1a-261d-491f-9fa6-38e0f8e99668"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9930faf9-168f-407d-83f9-aed3a5c3a504"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f9dbfb15-d1f3-42da-a184-3ff9a0a8d2ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("91b6aa59-8144-4e60-bf28-4187be6237e7"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccdc04f6-5bb8-4cc6-8328-6a3de875c21e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f027fe2-2112-4b14-a969-7c7e4848daa8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("af072908-05a6-47f2-8208-91d303d69092"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f996f7ef-4813-4299-a8d3-663394c00cfa"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6b4bdd6-0248-4891-bc83-bbf56208bd34"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7b8322f7-7268-450d-bd10-cfe34b0e49e6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("510093a5-a4f1-48f3-8e9f-8be5e77a6bda"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9dbe3367-660b-453d-9317-2210ab1c0fa2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e7baf5e3-d9af-4459-9edc-761ab2ad026d"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1ea85238-d21d-45d5-ba34-17d23739df7e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2ff19d3b-ef76-4bed-b024-115cf0177ff8"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("183254cc-696b-4b07-ba8b-d35946efd299"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23af0f43-e654-43d8-9ac4-5a691fd35858"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1e1d8cd-ae79-4ca7-9578-430693aefeb8"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87270840-0152-4b7c-bf30-ddd38ecf64a6"))));//Value

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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
            queryMapType: typeof(GuiduuidE0MIWA),
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
            queryMapType: typeof(GuiduuidE0MIWA),
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
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
COPY public.binary_guiduuide0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidE0MI),
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
                var importCollection = new List<GuiduuidE0MI>(2);
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
                    GuiduuidE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MI>(2);
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
                    GuiduuidE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuide0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
COPY public.binary_guiduuide0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidE0MIWA),
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidE0MIWA
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
                    GuiduuidE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuide0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuide0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidE0M),
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
FROM public.binary_guiduuide0m m
LEFT JOIN public.binary_guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                var importCollection = new List<GuiduuidE0M>();
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
                    GuiduuidE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidE0M>();
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
                    GuiduuidE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuide0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidE0M)],
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
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
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
                    GuiduuidE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuide0mi
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI), typeof(GuiduuidE0MI)],
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
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                await ((IGuidSingleTypeuuid)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MI>();
                var models2 = new List<GuiduuidE0MI>();
                ((IGuidSingleTypeuuid)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MI)],
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
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
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
                    GuiduuidE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuide0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA), typeof(GuiduuidE0MIWA)],
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                await ((IGuidSingleTypeuuid)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidE0MIWA>();
                var models2 = new List<GuiduuidE0MIWA>();
                ((IGuidSingleTypeuuid)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuide0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidE0MIWA)],
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
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
                    GuiduuidE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

