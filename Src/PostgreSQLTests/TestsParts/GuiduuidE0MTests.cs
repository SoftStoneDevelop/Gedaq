

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
    Id = 1,
    Value = Guid.Parse("23ff891f-38c6-4e0f-a969-486f11a17e78"),
    ModelInner = null,
    NullableValue = Guid.Parse("32e3f339-ec0f-48f3-b55b-48ee33086f14"),
},
            new GuiduuidE0M
{
    Id = 8,
    Value = Guid.Parse("7f151f55-2c43-4e24-82b7-258e4f80ab43"),
    ModelInner = new Guiduuid0MI
{
    Id = 8,
    Value = Guid.Parse("9bd37611-3181-40aa-9118-bdf044894c7f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ec831ac2-35c8-421a-8712-14c608799252"),
},
            new GuiduuidE0M
{
    Id = 15,
    Value = Guid.Parse("4a73bf77-a1ea-468c-85d4-bf4eb8c53f84"),
    ModelInner = null,
    NullableValue = Guid.Parse("1fb34b6f-ff81-489f-84ed-328d6c6ebe7c"),
},
            new GuiduuidE0M
{
    Id = 18,
    Value = Guid.Parse("4a75a528-95a7-489b-9042-0e309f0fb353"),
    ModelInner = new Guiduuid0MI
{
    Id = 9,
    Value = Guid.Parse("bf4967d3-f2d9-414d-a9ec-f3c6ed6dbfd9"),
    NullableValue = Guid.Parse("4f1b8e4a-bb8f-453e-af9c-620b6837028a"),
},
    NullableValue = Guid.Parse("d7ba83bc-e671-4410-9cee-b35b173b002e"),
},
            new GuiduuidE0M
{
    Id = 26,
    Value = Guid.Parse("277e10db-3842-4996-9e42-c3f555bfef8f"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 34,
    Value = Guid.Parse("ab78ce1f-64da-4ca3-aaa2-3e87865aae04"),
    ModelInner = new Guiduuid0MI
{
    Id = 14,
    Value = Guid.Parse("9580a7c0-9d8c-457c-bfcf-76c1f443116d"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("8a8f1d82-dcd5-4a6f-a5e6-6d3a8408aac0"),
},
            new GuiduuidE0M
{
    Id = 41,
    Value = Guid.Parse("945d701e-120f-4b50-a1c9-c28bedd6e683"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 49,
    Value = Guid.Parse("8975244f-7450-4e04-b278-e023c1cb8710"),
    ModelInner = new Guiduuid0MI
{
    Id = 20,
    Value = Guid.Parse("211c6b11-e8b7-4cb3-94c7-8618737a6adb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("a2babd3b-c678-465f-8ed7-6924cc301e29"),
},
            new GuiduuidE0M
{
    Id = 50,
    Value = Guid.Parse("0821bf1e-c833-48e1-9617-a10531b8e00b"),
    ModelInner = null,
    NullableValue = Guid.Parse("c8d2b73e-79bd-47d0-8f16-7b6b7b585ca3"),
},
            new GuiduuidE0M
{
    Id = 59,
    Value = Guid.Parse("672efa80-95f7-428f-ae21-e366ce669284"),
    ModelInner = new Guiduuid0MI
{
    Id = 28,
    Value = Guid.Parse("1d23387d-ff2a-4177-a7a9-5a0cbad8500e"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 60,
    Value = Guid.Parse("9dcbca21-156e-42ef-8c26-68318f72e9c5"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 69,
    Value = Guid.Parse("04e4bd0f-8e52-4efe-8525-8238a7b9c5aa"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("59564503-e98f-4d3f-9250-adc1cd743eba"),
    NullableValue = Guid.Parse("14b24ea0-cdea-454f-980f-0027bfdedd3b"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 72,
    Value = Guid.Parse("a3ee87a3-5dd4-4405-9469-e9baac30563c"),
    ModelInner = null,
    NullableValue = Guid.Parse("e8024cbf-2aba-46b9-b8b5-88c0d974643f"),
},
            new GuiduuidE0M
{
    Id = 79,
    Value = Guid.Parse("3432a624-4553-41c7-a6b1-75ce15872e27"),
    ModelInner = new Guiduuid0MI
{
    Id = 39,
    Value = Guid.Parse("07740b25-c74d-4650-b1d9-f61202e9c407"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 81,
    Value = Guid.Parse("6a31bdbd-e043-4cd4-8ec0-18d67da7f2ba"),
    ModelInner = null,
    NullableValue = Guid.Parse("e5a1e846-7057-453b-bdb3-21a3a71412e1"),
},
            new GuiduuidE0M
{
    Id = 82,
    Value = Guid.Parse("abffe866-71e6-48d1-bbdc-ae211a91f088"),
    ModelInner = new Guiduuid0MI
{
    Id = 48,
    Value = Guid.Parse("ecf5e284-354f-4581-88ad-e1b0706f8ee0"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("bac2338c-14ed-412d-85db-a6cb490d039a"),
},
            new GuiduuidE0M
{
    Id = 84,
    Value = Guid.Parse("6b1a8e2b-b8b4-4970-a7cd-eafe7fd811e9"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 90,
    Value = Guid.Parse("cc384c08-7a0e-4e8a-bb84-23cddb2cf6b4"),
    ModelInner = new Guiduuid0MI
{
    Id = 52,
    Value = Guid.Parse("ddc2ba88-ec95-4364-adde-aee24f9757ed"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b8f8372a-49c2-404b-9fb5-0362ebb6aa36"),
},
            new GuiduuidE0M
{
    Id = 92,
    Value = Guid.Parse("252c3a00-19f7-4976-8cca-43b99df9e20c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 96,
    Value = Guid.Parse("98c5d93a-1738-46de-bae3-c771eb38e888"),
    ModelInner = new Guiduuid0MI
{
    Id = 55,
    Value = Guid.Parse("e2723219-1db0-4915-b158-6fb87cadcdd6"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 103,
    Value = Guid.Parse("a8cfaf2b-7ed7-4897-b5bb-bb197ecaab58"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 105,
    Value = Guid.Parse("fac179c8-8ee5-4e10-b121-e034ebe9fd1c"),
    ModelInner = new Guiduuid0MI
{
    Id = 62,
    Value = Guid.Parse("3cc9be53-17a3-4807-ac93-307750a87a7f"),
    NullableValue = Guid.Parse("01bfa25b-ce1b-4b19-9764-8582cbc34eb4"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 106,
    Value = Guid.Parse("6a73bf1e-f666-4354-82b5-027a3d5b9e7c"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 107,
    Value = Guid.Parse("c06bb387-a198-40df-853b-51c31a72d32b"),
    ModelInner = new Guiduuid0MI
{
    Id = 66,
    Value = Guid.Parse("ac287cef-81a5-4c1f-a18d-d1ba01d70894"),
    NullableValue = Guid.Parse("03103219-5447-4331-b991-1d064c1fc5ea"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 109,
    Value = Guid.Parse("0f3daca0-6c32-4c7a-a6b6-0bad346f8ffd"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 114,
    Value = Guid.Parse("f4f475f8-8d90-4e98-827d-26a95561b9b4"),
    ModelInner = new Guiduuid0MI
{
    Id = 71,
    Value = Guid.Parse("9f0543af-3873-4ce8-bbd7-65f364a31dd4"),
    NullableValue = Guid.Parse("ac7b81cb-4caa-4f8a-920a-b82c12dbf9a7"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 115,
    Value = Guid.Parse("41e12148-b7e7-475a-a845-794a9fe3734f"),
    ModelInner = null,
    NullableValue = Guid.Parse("85b62e59-3384-42a2-8dff-1c9e73087913"),
},
            new GuiduuidE0M
{
    Id = 122,
    Value = Guid.Parse("917786b5-3258-4d09-b999-9bc3c0245a3a"),
    ModelInner = new Guiduuid0MI
{
    Id = 79,
    Value = Guid.Parse("cad60900-683a-4f76-a740-db519b8710b1"),
    NullableValue = Guid.Parse("3cc3fbb2-5d86-4765-9a4e-885a4c7f58ff"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 126,
    Value = Guid.Parse("626387ef-e31e-463e-a980-3458422038c0"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 129,
    Value = Guid.Parse("4c60d996-c211-4185-b5ae-d8de269d1e0a"),
    ModelInner = new Guiduuid0MI
{
    Id = 82,
    Value = Guid.Parse("04a4abbb-d894-48e2-beb9-0fda9ced41d2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 130,
    Value = Guid.Parse("9a77f016-33ab-447f-98ed-feeee0661175"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 137,
    Value = Guid.Parse("2c1b3d35-275e-4e86-af88-789828853369"),
    ModelInner = new Guiduuid0MI
{
    Id = 84,
    Value = Guid.Parse("60079e72-f565-482a-b635-03547e79789c"),
    NullableValue = Guid.Parse("285ed64f-d10f-469c-a2d3-8bb1123c5f44"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 141,
    Value = Guid.Parse("ffe7685a-8c19-4710-a0d6-49031a29f9bf"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 146,
    Value = Guid.Parse("a2d1cbc6-1a32-41fc-be7d-88b68f6e990c"),
    ModelInner = new Guiduuid0MI
{
    Id = 92,
    Value = Guid.Parse("ccb2e34a-41d7-4318-bd3d-72bfd7b6252f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("3161381e-57e6-454d-9beb-c5b4b0edec0e"),
},
            new GuiduuidE0M
{
    Id = 152,
    Value = Guid.Parse("63a5c88c-51d7-496b-b8e0-f6704c8ed215"),
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
INSERT INTO public.guiduuide0m(
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
INSERT INTO public.guiduuide0m(
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("8a8f1d82-dcd5-4a6f-a5e6-6d3a8408aac0")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("a2babd3b-c678-465f-8ed7-6924cc301e29")));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuide0m(
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c8d2b73e-79bd-47d0-8f16-7b6b7b585ca3")));
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 84;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[34], false);
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidE0M.AssertModel(models[0],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidE0M.AssertModel(models[0],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 82, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[34], false);
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
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 84))
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidE0M.AssertModel(models[0],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 103, 59))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidE0M.AssertModel(models[0],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                GuiduuidE0M.AssertModel(models[0],_testData[12], false);
                GuiduuidE0M.AssertModel(models[1],_testData[13], false);
                GuiduuidE0M.AssertModel(models[2],_testData[14], false);
                GuiduuidE0M.AssertModel(models[3],_testData[15], false);
                GuiduuidE0M.AssertModel(models[4],_testData[16], false);
                GuiduuidE0M.AssertModel(models[5],_testData[17], false);
                GuiduuidE0M.AssertModel(models[6],_testData[18], false);
                GuiduuidE0M.AssertModel(models[7],_testData[19], false);
                GuiduuidE0M.AssertModel(models[8],_testData[20], false);
                GuiduuidE0M.AssertModel(models[9],_testData[21], false);
                GuiduuidE0M.AssertModel(models[10],_testData[22], false);
                GuiduuidE0M.AssertModel(models[11],_testData[23], false);
                GuiduuidE0M.AssertModel(models[12],_testData[24], false);
                GuiduuidE0M.AssertModel(models[13],_testData[25], false);
                GuiduuidE0M.AssertModel(models[14],_testData[26], false);
                GuiduuidE0M.AssertModel(models[15],_testData[27], false);
                GuiduuidE0M.AssertModel(models[16],_testData[28], false);
                GuiduuidE0M.AssertModel(models[17],_testData[29], false);
                GuiduuidE0M.AssertModel(models[18],_testData[30], false);
                GuiduuidE0M.AssertModel(models[19],_testData[31], false);
                GuiduuidE0M.AssertModel(models[20],_testData[32], false);
                GuiduuidE0M.AssertModel(models[21],_testData[33], false);
                GuiduuidE0M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                GuiduuidE0M.AssertModel(models[0],_testData[24], false);
                GuiduuidE0M.AssertModel(models[1],_testData[25], false);
                GuiduuidE0M.AssertModel(models[2],_testData[26], false);
                GuiduuidE0M.AssertModel(models[3],_testData[27], false);
                GuiduuidE0M.AssertModel(models[4],_testData[28], false);
                GuiduuidE0M.AssertModel(models[5],_testData[29], false);
                GuiduuidE0M.AssertModel(models[6],_testData[30], false);
                GuiduuidE0M.AssertModel(models[7],_testData[31], false);
                GuiduuidE0M.AssertModel(models[8],_testData[32], false);
                GuiduuidE0M.AssertModel(models[9],_testData[33], false);
                GuiduuidE0M.AssertModel(models[10],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23ff891f-38c6-4e0f-a969-486f11a17e78"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32e3f339-ec0f-48f3-b55b-48ee33086f14"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f151f55-2c43-4e24-82b7-258e4f80ab43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bd37611-3181-40aa-9118-bdf044894c7f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ec831ac2-35c8-421a-8712-14c608799252"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a73bf77-a1ea-468c-85d4-bf4eb8c53f84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1fb34b6f-ff81-489f-84ed-328d6c6ebe7c"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a75a528-95a7-489b-9042-0e309f0fb353"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bf4967d3-f2d9-414d-a9ec-f3c6ed6dbfd9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4f1b8e4a-bb8f-453e-af9c-620b6837028a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d7ba83bc-e671-4410-9cee-b35b173b002e"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("277e10db-3842-4996-9e42-c3f555bfef8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ab78ce1f-64da-4ca3-aaa2-3e87865aae04"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9580a7c0-9d8c-457c-bfcf-76c1f443116d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8a8f1d82-dcd5-4a6f-a5e6-6d3a8408aac0"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("945d701e-120f-4b50-a1c9-c28bedd6e683"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8975244f-7450-4e04-b278-e023c1cb8710"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("211c6b11-e8b7-4cb3-94c7-8618737a6adb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2babd3b-c678-465f-8ed7-6924cc301e29"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0821bf1e-c833-48e1-9617-a10531b8e00b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c8d2b73e-79bd-47d0-8f16-7b6b7b585ca3"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("672efa80-95f7-428f-ae21-e366ce669284"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d23387d-ff2a-4177-a7a9-5a0cbad8500e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9dcbca21-156e-42ef-8c26-68318f72e9c5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04e4bd0f-8e52-4efe-8525-8238a7b9c5aa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("59564503-e98f-4d3f-9250-adc1cd743eba"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("14b24ea0-cdea-454f-980f-0027bfdedd3b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a3ee87a3-5dd4-4405-9469-e9baac30563c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e8024cbf-2aba-46b9-b8b5-88c0d974643f"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3432a624-4553-41c7-a6b1-75ce15872e27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07740b25-c74d-4650-b1d9-f61202e9c407"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a31bdbd-e043-4cd4-8ec0-18d67da7f2ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5a1e846-7057-453b-bdb3-21a3a71412e1"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abffe866-71e6-48d1-bbdc-ae211a91f088"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ecf5e284-354f-4581-88ad-e1b0706f8ee0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bac2338c-14ed-412d-85db-a6cb490d039a"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b1a8e2b-b8b4-4970-a7cd-eafe7fd811e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc384c08-7a0e-4e8a-bb84-23cddb2cf6b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ddc2ba88-ec95-4364-adde-aee24f9757ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8f8372a-49c2-404b-9fb5-0362ebb6aa36"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("252c3a00-19f7-4976-8cca-43b99df9e20c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98c5d93a-1738-46de-bae3-c771eb38e888"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2723219-1db0-4915-b158-6fb87cadcdd6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8cfaf2b-7ed7-4897-b5bb-bb197ecaab58"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fac179c8-8ee5-4e10-b121-e034ebe9fd1c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3cc9be53-17a3-4807-ac93-307750a87a7f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("01bfa25b-ce1b-4b19-9764-8582cbc34eb4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a73bf1e-f666-4354-82b5-027a3d5b9e7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c06bb387-a198-40df-853b-51c31a72d32b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac287cef-81a5-4c1f-a18d-d1ba01d70894"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("03103219-5447-4331-b991-1d064c1fc5ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0f3daca0-6c32-4c7a-a6b6-0bad346f8ffd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4f475f8-8d90-4e98-827d-26a95561b9b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9f0543af-3873-4ce8-bbd7-65f364a31dd4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ac7b81cb-4caa-4f8a-920a-b82c12dbf9a7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41e12148-b7e7-475a-a845-794a9fe3734f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85b62e59-3384-42a2-8dff-1c9e73087913"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("917786b5-3258-4d09-b999-9bc3c0245a3a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cad60900-683a-4f76-a740-db519b8710b1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3cc3fbb2-5d86-4765-9a4e-885a4c7f58ff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("626387ef-e31e-463e-a980-3458422038c0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c60d996-c211-4185-b5ae-d8de269d1e0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04a4abbb-d894-48e2-beb9-0fda9ced41d2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a77f016-33ab-447f-98ed-feeee0661175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c1b3d35-275e-4e86-af88-789828853369"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60079e72-f565-482a-b635-03547e79789c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("285ed64f-d10f-469c-a2d3-8bb1123c5f44"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ffe7685a-8c19-4710-a0d6-49031a29f9bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a2d1cbc6-1a32-41fc-be7d-88b68f6e990c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ccb2e34a-41d7-4318-bd3d-72bfd7b6252f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3161381e-57e6-454d-9beb-c5b4b0edec0e"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63a5c88c-51d7-496b-b8e0-f6704c8ed215"))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("23ff891f-38c6-4e0f-a969-486f11a17e78"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("32e3f339-ec0f-48f3-b55b-48ee33086f14"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f151f55-2c43-4e24-82b7-258e4f80ab43"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9bd37611-3181-40aa-9118-bdf044894c7f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ec831ac2-35c8-421a-8712-14c608799252"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a73bf77-a1ea-468c-85d4-bf4eb8c53f84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1fb34b6f-ff81-489f-84ed-328d6c6ebe7c"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4a75a528-95a7-489b-9042-0e309f0fb353"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bf4967d3-f2d9-414d-a9ec-f3c6ed6dbfd9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4f1b8e4a-bb8f-453e-af9c-620b6837028a"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d7ba83bc-e671-4410-9cee-b35b173b002e"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("277e10db-3842-4996-9e42-c3f555bfef8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ab78ce1f-64da-4ca3-aaa2-3e87865aae04"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9580a7c0-9d8c-457c-bfcf-76c1f443116d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8a8f1d82-dcd5-4a6f-a5e6-6d3a8408aac0"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("945d701e-120f-4b50-a1c9-c28bedd6e683"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8975244f-7450-4e04-b278-e023c1cb8710"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("211c6b11-e8b7-4cb3-94c7-8618737a6adb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a2babd3b-c678-465f-8ed7-6924cc301e29"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0821bf1e-c833-48e1-9617-a10531b8e00b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c8d2b73e-79bd-47d0-8f16-7b6b7b585ca3"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("672efa80-95f7-428f-ae21-e366ce669284"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1d23387d-ff2a-4177-a7a9-5a0cbad8500e"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9dcbca21-156e-42ef-8c26-68318f72e9c5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("04e4bd0f-8e52-4efe-8525-8238a7b9c5aa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("59564503-e98f-4d3f-9250-adc1cd743eba"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("14b24ea0-cdea-454f-980f-0027bfdedd3b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a3ee87a3-5dd4-4405-9469-e9baac30563c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e8024cbf-2aba-46b9-b8b5-88c0d974643f"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3432a624-4553-41c7-a6b1-75ce15872e27"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("07740b25-c74d-4650-b1d9-f61202e9c407"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a31bdbd-e043-4cd4-8ec0-18d67da7f2ba"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5a1e846-7057-453b-bdb3-21a3a71412e1"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("abffe866-71e6-48d1-bbdc-ae211a91f088"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ecf5e284-354f-4581-88ad-e1b0706f8ee0"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bac2338c-14ed-412d-85db-a6cb490d039a"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b1a8e2b-b8b4-4970-a7cd-eafe7fd811e9"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cc384c08-7a0e-4e8a-bb84-23cddb2cf6b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ddc2ba88-ec95-4364-adde-aee24f9757ed"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b8f8372a-49c2-404b-9fb5-0362ebb6aa36"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("252c3a00-19f7-4976-8cca-43b99df9e20c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("98c5d93a-1738-46de-bae3-c771eb38e888"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2723219-1db0-4915-b158-6fb87cadcdd6"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8cfaf2b-7ed7-4897-b5bb-bb197ecaab58"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fac179c8-8ee5-4e10-b121-e034ebe9fd1c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3cc9be53-17a3-4807-ac93-307750a87a7f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("01bfa25b-ce1b-4b19-9764-8582cbc34eb4"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6a73bf1e-f666-4354-82b5-027a3d5b9e7c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c06bb387-a198-40df-853b-51c31a72d32b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ac287cef-81a5-4c1f-a18d-d1ba01d70894"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("03103219-5447-4331-b991-1d064c1fc5ea"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0f3daca0-6c32-4c7a-a6b6-0bad346f8ffd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4f475f8-8d90-4e98-827d-26a95561b9b4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9f0543af-3873-4ce8-bbd7-65f364a31dd4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ac7b81cb-4caa-4f8a-920a-b82c12dbf9a7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("41e12148-b7e7-475a-a845-794a9fe3734f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("85b62e59-3384-42a2-8dff-1c9e73087913"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("917786b5-3258-4d09-b999-9bc3c0245a3a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("cad60900-683a-4f76-a740-db519b8710b1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("3cc3fbb2-5d86-4765-9a4e-885a4c7f58ff"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("626387ef-e31e-463e-a980-3458422038c0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c60d996-c211-4185-b5ae-d8de269d1e0a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04a4abbb-d894-48e2-beb9-0fda9ced41d2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9a77f016-33ab-447f-98ed-feeee0661175"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2c1b3d35-275e-4e86-af88-789828853369"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("60079e72-f565-482a-b635-03547e79789c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("285ed64f-d10f-469c-a2d3-8bb1123c5f44"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ffe7685a-8c19-4710-a0d6-49031a29f9bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a2d1cbc6-1a32-41fc-be7d-88b68f6e990c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("ccb2e34a-41d7-4318-bd3d-72bfd7b6252f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3161381e-57e6-454d-9beb-c5b4b0edec0e"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63a5c88c-51d7-496b-b8e0-f6704c8ed215"))));//Value

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
COPY public.binary_guiduuide0m
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
LEFT JOIN public.binary_guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
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
    guiduuid0mi_id,
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

