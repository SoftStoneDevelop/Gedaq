

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
    Id = 7,
    Value = Guid.Parse("03549ac3-c921-468f-9607-4d262d2acdb2"),
    ModelInner = null,
    NullableValue = Guid.Parse("2469b510-0479-4a6a-9fec-fb38e9506b92"),
},
            new Guiduuid0M
{
    Id = 12,
    Value = Guid.Parse("564cb97b-3499-4509-ab08-98eb7748ed95"),
    ModelInner = new Guiduuid0MI
{
    Id = 8,
    Value = Guid.Parse("2b7388c9-ec4f-4716-81f3-2842d31e5c3e"),
    NullableValue = Guid.Parse("00852048-a1f9-4ae4-b2f7-e49c9dd32444"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 21,
    Value = Guid.Parse("b4a8b4fc-82ee-40b9-95dc-64fab1ba8b18"),
    ModelInner = null,
    NullableValue = Guid.Parse("a25fe90f-a5cd-4ae4-82fc-69f13b9246e5"),
},
            new Guiduuid0M
{
    Id = 24,
    Value = Guid.Parse("fef1edde-bccd-459b-89be-07f20facc774"),
    ModelInner = new Guiduuid0MI
{
    Id = 11,
    Value = Guid.Parse("72d05cd3-7d18-4139-9953-a8f5eb852d69"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("402e75fc-20aa-4768-a7ec-793eda031e74"),
},
            new Guiduuid0M
{
    Id = 30,
    Value = Guid.Parse("e22f3c1f-4656-4959-a108-343c2b917744"),
    ModelInner = null,
    NullableValue = Guid.Parse("362de5cf-0f4d-442a-b8f3-343e7d18d05a"),
},
            new Guiduuid0M
{
    Id = 36,
    Value = Guid.Parse("e10a3dd0-6850-41c7-ab07-9d1d4def5928"),
    ModelInner = new Guiduuid0MI
{
    Id = 19,
    Value = Guid.Parse("75ef8fa1-3841-4798-be7c-7a0d8d5db26c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("d2c03147-c288-4fc3-a501-e2ec3b39e5ce"),
},
            new Guiduuid0M
{
    Id = 37,
    Value = Guid.Parse("fc4714db-9413-414b-9b22-e9ae546eb288"),
    ModelInner = null,
    NullableValue = Guid.Parse("e5de910b-3f5f-470a-94da-43af1921d165"),
},
            new Guiduuid0M
{
    Id = 40,
    Value = Guid.Parse("4c130e6a-e346-451e-acc8-d80cbb04a48f"),
    ModelInner = new Guiduuid0MI
{
    Id = 23,
    Value = Guid.Parse("f3cfe27f-861c-4c2e-91f2-5d2fddd66821"),
    NullableValue = Guid.Parse("320eb548-524c-4ebd-9886-5ce7b6324817"),
},
    NullableValue = Guid.Parse("9233354e-65e2-464c-a35e-0e28c0767100"),
},
            new Guiduuid0M
{
    Id = 44,
    Value = Guid.Parse("8f98afbf-1811-4d08-8c54-7fc2de6ebdad"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 53,
    Value = Guid.Parse("4ca9dd0d-8fa4-4e1c-ab91-dc4e828ce49d"),
    ModelInner = new Guiduuid0MI
{
    Id = 24,
    Value = Guid.Parse("3986adbc-d910-485d-831d-15552ae96e3f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ab30e12a-fe38-4378-9768-bda72cf59263"),
},
            new Guiduuid0M
{
    Id = 55,
    Value = Guid.Parse("e999d374-e872-40d6-aae1-ac5f3e9e014d"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 60,
    Value = Guid.Parse("b6997b67-5835-40e1-89b4-95167cd75c35"),
    ModelInner = new Guiduuid0MI
{
    Id = 29,
    Value = Guid.Parse("bdf2bd00-edb9-418c-ae61-45810793fce9"),
    NullableValue = Guid.Parse("6daf16cd-d567-40aa-b1ac-3e13ed344cf8"),
},
    NullableValue = Guid.Parse("93851967-7744-4e62-b671-61d7ca6c5632"),
},
            new Guiduuid0M
{
    Id = 62,
    Value = Guid.Parse("ee6cce63-5c75-4d47-ab97-63b659b644d8"),
    ModelInner = null,
    NullableValue = Guid.Parse("65013716-54ac-482e-b40a-a8167dd0dd0a"),
},
            new Guiduuid0M
{
    Id = 64,
    Value = Guid.Parse("295814ea-71d8-4421-b0cd-5e7f6ae645ff"),
    ModelInner = new Guiduuid0MI
{
    Id = 36,
    Value = Guid.Parse("03ea6441-9ccf-4d66-9370-ed0db76a3e71"),
    NullableValue = Guid.Parse("e05b8343-cd69-43a9-acde-ce61b04212d1"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 66,
    Value = Guid.Parse("38585ad6-e8a0-498a-ac62-8907d1b97fe1"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 74,
    Value = Guid.Parse("3a8451f9-159c-413d-8062-58c80a7ac5da"),
    ModelInner = new Guiduuid0MI
{
    Id = 45,
    Value = Guid.Parse("d71bb041-35a8-40a8-ba68-5f740ccac2d4"),
    NullableValue = Guid.Parse("f79ad1ca-afd4-4cbd-ad1e-17dedb871980"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 76,
    Value = Guid.Parse("38efc1a7-2f9e-4ab8-a8bf-2984b497d6ae"),
    ModelInner = null,
    NullableValue = Guid.Parse("07bb0398-5e9b-4a62-8d6e-b308f8010fde"),
},
            new Guiduuid0M
{
    Id = 81,
    Value = Guid.Parse("63de2e6c-fabd-4e8d-aa75-f49f8af20420"),
    ModelInner = new Guiduuid0MI
{
    Id = 52,
    Value = Guid.Parse("5bdf2ace-d82f-401d-b255-1285e3e19c71"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("ecb632f5-eb6b-4151-b890-c38f0b7c2589"),
},
            new Guiduuid0M
{
    Id = 88,
    Value = Guid.Parse("55cad308-dc69-4805-8874-e6fe3b208b9f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 94,
    Value = Guid.Parse("bc418bee-1da0-4d9c-81f5-af649be12102"),
    ModelInner = new Guiduuid0MI
{
    Id = 59,
    Value = Guid.Parse("d3ded752-a354-4722-9e38-d3a2ace3cf8c"),
    NullableValue = Guid.Parse("4bbedea2-dd9d-4a7c-bf33-65e4fbb8628e"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 100,
    Value = Guid.Parse("86122d9d-1a1b-4cbc-91bc-65b26f7def69"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 107,
    Value = Guid.Parse("da310d5d-4239-4e70-a680-b408f2d32c8c"),
    ModelInner = new Guiduuid0MI
{
    Id = 63,
    Value = Guid.Parse("7244e667-023b-4fa4-acc2-7ccd870f7362"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("dbaa5cee-7013-4f0a-b02a-03d69be789f5"),
},
            new Guiduuid0M
{
    Id = 108,
    Value = Guid.Parse("391fd79b-262a-4e15-8c9f-6ecf0f585615"),
    ModelInner = null,
    NullableValue = Guid.Parse("af1ed21c-48fc-4364-942d-35136fa62dd9"),
},
            new Guiduuid0M
{
    Id = 117,
    Value = Guid.Parse("19c94f49-857c-4e06-817a-f227dcf7d5e2"),
    ModelInner = new Guiduuid0MI
{
    Id = 71,
    Value = Guid.Parse("10f8fc12-2a86-4113-a1fb-27a9c66e11c2"),
    NullableValue = Guid.Parse("f7f82469-5fb3-4905-9503-279d161695b4"),
},
    NullableValue = Guid.Parse("7d8ab02f-ed02-4fdd-a139-f46074af74f3"),
},
            new Guiduuid0M
{
    Id = 120,
    Value = Guid.Parse("d48c86e0-620f-470b-a6c9-54288a1055ad"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 126,
    Value = Guid.Parse("7ec7bdeb-ceba-4ea3-8b20-436210681aed"),
    ModelInner = new Guiduuid0MI
{
    Id = 74,
    Value = Guid.Parse("3273082c-8c33-46ad-911c-c98adde059cc"),
    NullableValue = Guid.Parse("9580fd4b-8a18-460c-b915-13b5362a858a"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 135,
    Value = Guid.Parse("876dd94e-97a8-4a04-9168-698cbca263d5"),
    ModelInner = null,
    NullableValue = Guid.Parse("dd5218f2-7580-42e3-9784-8cfb2bcc621d"),
},
            new Guiduuid0M
{
    Id = 139,
    Value = Guid.Parse("030b1cc8-f40a-477c-98c9-3ad33bf2f7bb"),
    ModelInner = new Guiduuid0MI
{
    Id = 77,
    Value = Guid.Parse("704566c9-440a-4af5-843e-4ef9618ca011"),
    NullableValue = Guid.Parse("411c1bf5-c5ab-4638-b002-b8622053b58f"),
},
    NullableValue = Guid.Parse("d60fb7dd-8af7-4548-a32c-bcb0a73be75f"),
},
            new Guiduuid0M
{
    Id = 148,
    Value = Guid.Parse("c9db7d13-84dd-4b4f-9041-40f42585a704"),
    ModelInner = null,
    NullableValue = Guid.Parse("6fd56933-832f-4b67-9030-f50610ffa867"),
},
            new Guiduuid0M
{
    Id = 156,
    Value = Guid.Parse("f4d09630-70fb-4e2c-971a-3ee684f3902c"),
    ModelInner = new Guiduuid0MI
{
    Id = 78,
    Value = Guid.Parse("87536b38-dc21-4259-a084-6955e85e0b2c"),
    NullableValue = Guid.Parse("c05fb784-6623-4d86-b4cf-52493be1286e"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 157,
    Value = Guid.Parse("80f8e2d5-d1d7-4d05-bbca-2e4bb84c8407"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 164,
    Value = Guid.Parse("f4a8fbf6-b541-489a-ade4-2a156d0396ec"),
    ModelInner = new Guiduuid0MI
{
    Id = 81,
    Value = Guid.Parse("32c1e859-a235-41b3-9ef9-5fab37676f50"),
    NullableValue = Guid.Parse("82080543-a890-4547-aef3-048628c74b6e"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 167,
    Value = Guid.Parse("5e7e074d-171d-45de-a173-aacacd1e5826"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 169,
    Value = Guid.Parse("74b4fe4f-ad09-49fa-9ae1-aa1d2cd6b46a"),
    ModelInner = new Guiduuid0MI
{
    Id = 86,
    Value = Guid.Parse("e349d19d-6023-4713-abf6-94d9534f28f5"),
    NullableValue = Guid.Parse("ce2992f6-260d-4869-982b-89f0dfcf75db"),
},
    NullableValue = Guid.Parse("d28e4801-bb24-4726-80e4-5a04a90c12d4"),
},
            new Guiduuid0M
{
    Id = 173,
    Value = Guid.Parse("70cdbdff-50c4-428f-9eec-9fa77f233044"),
    ModelInner = null,
    NullableValue = Guid.Parse("8bb390f4-321c-4eef-931f-61568231e53d"),
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("362de5cf-0f4d-442a-b8f3-343e7d18d05a")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("d2c03147-c288-4fc3-a501-e2ec3b39e5ce")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("e5de910b-3f5f-470a-94da-43af1921d165")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("9233354e-65e2-464c-a35e-0e28c0767100")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("ab30e12a-fe38-4378-9768-bda72cf59263")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("93851967-7744-4e62-b671-61d7ca6c5632")));
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
                parametr1.Value = 60;
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduuid0M.AssertModel(models[0],_testData[18], false);
                        Guiduuid0M.AssertModel(models[1],_testData[19], false);
                        Guiduuid0M.AssertModel(models[2],_testData[20], false);
                        Guiduuid0M.AssertModel(models[3],_testData[21], false);
                        Guiduuid0M.AssertModel(models[4],_testData[22], false);
                        Guiduuid0M.AssertModel(models[5],_testData[23], false);
                        Guiduuid0M.AssertModel(models[6],_testData[24], false);
                        Guiduuid0M.AssertModel(models[7],_testData[25], false);
                        Guiduuid0M.AssertModel(models[8],_testData[26], false);
                        Guiduuid0M.AssertModel(models[9],_testData[27], false);
                        Guiduuid0M.AssertModel(models[10],_testData[28], false);
                        Guiduuid0M.AssertModel(models[11],_testData[29], false);
                        Guiduuid0M.AssertModel(models[12],_testData[30], false);
                        Guiduuid0M.AssertModel(models[13],_testData[31], false);
                        Guiduuid0M.AssertModel(models[14],_testData[32], false);
                        Guiduuid0M.AssertModel(models[15],_testData[33], false);
                        Guiduuid0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guiduuid0M.AssertModel(models[0],_testData[30], false);
                        Guiduuid0M.AssertModel(models[1],_testData[31], false);
                        Guiduuid0M.AssertModel(models[2],_testData[32], false);
                        Guiduuid0M.AssertModel(models[3],_testData[33], false);
                        Guiduuid0M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 126, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 21, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 81, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 60, query1, 88, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 164, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 60, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Guiduuid0M.AssertModel(models[0],_testData[12], false);
                        Guiduuid0M.AssertModel(models[1],_testData[13], false);
                        Guiduuid0M.AssertModel(models[2],_testData[14], false);
                        Guiduuid0M.AssertModel(models[3],_testData[15], false);
                        Guiduuid0M.AssertModel(models[4],_testData[16], false);
                        Guiduuid0M.AssertModel(models[5],_testData[17], false);
                        Guiduuid0M.AssertModel(models[6],_testData[18], false);
                        Guiduuid0M.AssertModel(models[7],_testData[19], false);
                        Guiduuid0M.AssertModel(models[8],_testData[20], false);
                        Guiduuid0M.AssertModel(models[9],_testData[21], false);
                        Guiduuid0M.AssertModel(models[10],_testData[22], false);
                        Guiduuid0M.AssertModel(models[11],_testData[23], false);
                        Guiduuid0M.AssertModel(models[12],_testData[24], false);
                        Guiduuid0M.AssertModel(models[13],_testData[25], false);
                        Guiduuid0M.AssertModel(models[14],_testData[26], false);
                        Guiduuid0M.AssertModel(models[15],_testData[27], false);
                        Guiduuid0M.AssertModel(models[16],_testData[28], false);
                        Guiduuid0M.AssertModel(models[17],_testData[29], false);
                        Guiduuid0M.AssertModel(models[18],_testData[30], false);
                        Guiduuid0M.AssertModel(models[19],_testData[31], false);
                        Guiduuid0M.AssertModel(models[20],_testData[32], false);
                        Guiduuid0M.AssertModel(models[21],_testData[33], false);
                        Guiduuid0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Guiduuid0M.AssertModel(models[0],_testData[31], false);
                        Guiduuid0M.AssertModel(models[1],_testData[32], false);
                        Guiduuid0M.AssertModel(models[2],_testData[33], false);
                        Guiduuid0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 36, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guiduuid0M.AssertModel(models[0],_testData[6], false);
                        Guiduuid0M.AssertModel(models[1],_testData[7], false);
                        Guiduuid0M.AssertModel(models[2],_testData[8], false);
                        Guiduuid0M.AssertModel(models[3],_testData[9], false);
                        Guiduuid0M.AssertModel(models[4],_testData[10], false);
                        Guiduuid0M.AssertModel(models[5],_testData[11], false);
                        Guiduuid0M.AssertModel(models[6],_testData[12], false);
                        Guiduuid0M.AssertModel(models[7],_testData[13], false);
                        Guiduuid0M.AssertModel(models[8],_testData[14], false);
                        Guiduuid0M.AssertModel(models[9],_testData[15], false);
                        Guiduuid0M.AssertModel(models[10],_testData[16], false);
                        Guiduuid0M.AssertModel(models[11],_testData[17], false);
                        Guiduuid0M.AssertModel(models[12],_testData[18], false);
                        Guiduuid0M.AssertModel(models[13],_testData[19], false);
                        Guiduuid0M.AssertModel(models[14],_testData[20], false);
                        Guiduuid0M.AssertModel(models[15],_testData[21], false);
                        Guiduuid0M.AssertModel(models[16],_testData[22], false);
                        Guiduuid0M.AssertModel(models[17],_testData[23], false);
                        Guiduuid0M.AssertModel(models[18],_testData[24], false);
                        Guiduuid0M.AssertModel(models[19],_testData[25], false);
                        Guiduuid0M.AssertModel(models[20],_testData[26], false);
                        Guiduuid0M.AssertModel(models[21],_testData[27], false);
                        Guiduuid0M.AssertModel(models[22],_testData[28], false);
                        Guiduuid0M.AssertModel(models[23],_testData[29], false);
                        Guiduuid0M.AssertModel(models[24],_testData[30], false);
                        Guiduuid0M.AssertModel(models[25],_testData[31], false);
                        Guiduuid0M.AssertModel(models[26],_testData[32], false);
                        Guiduuid0M.AssertModel(models[27],_testData[33], false);
                        Guiduuid0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduuid0M.AssertModel(models[0],_testData[29], false);
                        Guiduuid0M.AssertModel(models[1],_testData[30], false);
                        Guiduuid0M.AssertModel(models[2],_testData[31], false);
                        Guiduuid0M.AssertModel(models[3],_testData[32], false);
                        Guiduuid0M.AssertModel(models[4],_testData[33], false);
                        Guiduuid0M.AssertModel(models[5],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Guiduuid0M.AssertModel(models[0],_testData[5], false);
                Guiduuid0M.AssertModel(models[1],_testData[6], false);
                Guiduuid0M.AssertModel(models[2],_testData[7], false);
                Guiduuid0M.AssertModel(models[3],_testData[8], false);
                Guiduuid0M.AssertModel(models[4],_testData[9], false);
                Guiduuid0M.AssertModel(models[5],_testData[10], false);
                Guiduuid0M.AssertModel(models[6],_testData[11], false);
                Guiduuid0M.AssertModel(models[7],_testData[12], false);
                Guiduuid0M.AssertModel(models[8],_testData[13], false);
                Guiduuid0M.AssertModel(models[9],_testData[14], false);
                Guiduuid0M.AssertModel(models[10],_testData[15], false);
                Guiduuid0M.AssertModel(models[11],_testData[16], false);
                Guiduuid0M.AssertModel(models[12],_testData[17], false);
                Guiduuid0M.AssertModel(models[13],_testData[18], false);
                Guiduuid0M.AssertModel(models[14],_testData[19], false);
                Guiduuid0M.AssertModel(models[15],_testData[20], false);
                Guiduuid0M.AssertModel(models[16],_testData[21], false);
                Guiduuid0M.AssertModel(models[17],_testData[22], false);
                Guiduuid0M.AssertModel(models[18],_testData[23], false);
                Guiduuid0M.AssertModel(models[19],_testData[24], false);
                Guiduuid0M.AssertModel(models[20],_testData[25], false);
                Guiduuid0M.AssertModel(models[21],_testData[26], false);
                Guiduuid0M.AssertModel(models[22],_testData[27], false);
                Guiduuid0M.AssertModel(models[23],_testData[28], false);
                Guiduuid0M.AssertModel(models[24],_testData[29], false);
                Guiduuid0M.AssertModel(models[25],_testData[30], false);
                Guiduuid0M.AssertModel(models[26],_testData[31], false);
                Guiduuid0M.AssertModel(models[27],_testData[32], false);
                Guiduuid0M.AssertModel(models[28],_testData[33], false);
                Guiduuid0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 88);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03549ac3-c921-468f-9607-4d262d2acdb2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2469b510-0479-4a6a-9fec-fb38e9506b92"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("564cb97b-3499-4509-ab08-98eb7748ed95"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b7388c9-ec4f-4716-81f3-2842d31e5c3e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("00852048-a1f9-4ae4-b2f7-e49c9dd32444"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4a8b4fc-82ee-40b9-95dc-64fab1ba8b18"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a25fe90f-a5cd-4ae4-82fc-69f13b9246e5"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fef1edde-bccd-459b-89be-07f20facc774"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("72d05cd3-7d18-4139-9953-a8f5eb852d69"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("402e75fc-20aa-4768-a7ec-793eda031e74"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e22f3c1f-4656-4959-a108-343c2b917744"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("362de5cf-0f4d-442a-b8f3-343e7d18d05a"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e10a3dd0-6850-41c7-ab07-9d1d4def5928"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("75ef8fa1-3841-4798-be7c-7a0d8d5db26c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d2c03147-c288-4fc3-a501-e2ec3b39e5ce"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc4714db-9413-414b-9b22-e9ae546eb288"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5de910b-3f5f-470a-94da-43af1921d165"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c130e6a-e346-451e-acc8-d80cbb04a48f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3cfe27f-861c-4c2e-91f2-5d2fddd66821"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("320eb548-524c-4ebd-9886-5ce7b6324817"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9233354e-65e2-464c-a35e-0e28c0767100"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f98afbf-1811-4d08-8c54-7fc2de6ebdad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ca9dd0d-8fa4-4e1c-ab91-dc4e828ce49d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3986adbc-d910-485d-831d-15552ae96e3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab30e12a-fe38-4378-9768-bda72cf59263"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e999d374-e872-40d6-aae1-ac5f3e9e014d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6997b67-5835-40e1-89b4-95167cd75c35"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bdf2bd00-edb9-418c-ae61-45810793fce9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6daf16cd-d567-40aa-b1ac-3e13ed344cf8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("93851967-7744-4e62-b671-61d7ca6c5632"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ee6cce63-5c75-4d47-ab97-63b659b644d8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("65013716-54ac-482e-b40a-a8167dd0dd0a"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("295814ea-71d8-4421-b0cd-5e7f6ae645ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("03ea6441-9ccf-4d66-9370-ed0db76a3e71"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e05b8343-cd69-43a9-acde-ce61b04212d1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38585ad6-e8a0-498a-ac62-8907d1b97fe1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3a8451f9-159c-413d-8062-58c80a7ac5da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d71bb041-35a8-40a8-ba68-5f740ccac2d4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f79ad1ca-afd4-4cbd-ad1e-17dedb871980"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38efc1a7-2f9e-4ab8-a8bf-2984b497d6ae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("07bb0398-5e9b-4a62-8d6e-b308f8010fde"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63de2e6c-fabd-4e8d-aa75-f49f8af20420"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5bdf2ace-d82f-401d-b255-1285e3e19c71"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ecb632f5-eb6b-4151-b890-c38f0b7c2589"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55cad308-dc69-4805-8874-e6fe3b208b9f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc418bee-1da0-4d9c-81f5-af649be12102"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3ded752-a354-4722-9e38-d3a2ace3cf8c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4bbedea2-dd9d-4a7c-bf33-65e4fbb8628e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("86122d9d-1a1b-4cbc-91bc-65b26f7def69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da310d5d-4239-4e70-a680-b408f2d32c8c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7244e667-023b-4fa4-acc2-7ccd870f7362"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dbaa5cee-7013-4f0a-b02a-03d69be789f5"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391fd79b-262a-4e15-8c9f-6ecf0f585615"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af1ed21c-48fc-4364-942d-35136fa62dd9"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19c94f49-857c-4e06-817a-f227dcf7d5e2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("10f8fc12-2a86-4113-a1fb-27a9c66e11c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f7f82469-5fb3-4905-9503-279d161695b4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7d8ab02f-ed02-4fdd-a139-f46074af74f3"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d48c86e0-620f-470b-a6c9-54288a1055ad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ec7bdeb-ceba-4ea3-8b20-436210681aed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3273082c-8c33-46ad-911c-c98adde059cc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9580fd4b-8a18-460c-b915-13b5362a858a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("876dd94e-97a8-4a04-9168-698cbca263d5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd5218f2-7580-42e3-9784-8cfb2bcc621d"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("030b1cc8-f40a-477c-98c9-3ad33bf2f7bb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("704566c9-440a-4af5-843e-4ef9618ca011"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("411c1bf5-c5ab-4638-b002-b8622053b58f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d60fb7dd-8af7-4548-a32c-bcb0a73be75f"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9db7d13-84dd-4b4f-9041-40f42585a704"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6fd56933-832f-4b67-9030-f50610ffa867"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4d09630-70fb-4e2c-971a-3ee684f3902c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("87536b38-dc21-4259-a084-6955e85e0b2c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c05fb784-6623-4d86-b4cf-52493be1286e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80f8e2d5-d1d7-4d05-bbca-2e4bb84c8407"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4a8fbf6-b541-489a-ade4-2a156d0396ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("32c1e859-a235-41b3-9ef9-5fab37676f50"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("82080543-a890-4547-aef3-048628c74b6e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e7e074d-171d-45de-a173-aacacd1e5826"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74b4fe4f-ad09-49fa-9ae1-aa1d2cd6b46a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e349d19d-6023-4713-abf6-94d9534f28f5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ce2992f6-260d-4869-982b-89f0dfcf75db"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d28e4801-bb24-4726-80e4-5a04a90c12d4"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70cdbdff-50c4-428f-9eec-9fa77f233044"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8bb390f4-321c-4eef-931f-61568231e53d"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("03549ac3-c921-468f-9607-4d262d2acdb2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("2469b510-0479-4a6a-9fec-fb38e9506b92"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("564cb97b-3499-4509-ab08-98eb7748ed95"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b7388c9-ec4f-4716-81f3-2842d31e5c3e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("00852048-a1f9-4ae4-b2f7-e49c9dd32444"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b4a8b4fc-82ee-40b9-95dc-64fab1ba8b18"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a25fe90f-a5cd-4ae4-82fc-69f13b9246e5"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fef1edde-bccd-459b-89be-07f20facc774"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("72d05cd3-7d18-4139-9953-a8f5eb852d69"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("402e75fc-20aa-4768-a7ec-793eda031e74"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e22f3c1f-4656-4959-a108-343c2b917744"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("362de5cf-0f4d-442a-b8f3-343e7d18d05a"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e10a3dd0-6850-41c7-ab07-9d1d4def5928"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("75ef8fa1-3841-4798-be7c-7a0d8d5db26c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d2c03147-c288-4fc3-a501-e2ec3b39e5ce"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fc4714db-9413-414b-9b22-e9ae546eb288"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e5de910b-3f5f-470a-94da-43af1921d165"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c130e6a-e346-451e-acc8-d80cbb04a48f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3cfe27f-861c-4c2e-91f2-5d2fddd66821"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("320eb548-524c-4ebd-9886-5ce7b6324817"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9233354e-65e2-464c-a35e-0e28c0767100"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f98afbf-1811-4d08-8c54-7fc2de6ebdad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ca9dd0d-8fa4-4e1c-ab91-dc4e828ce49d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3986adbc-d910-485d-831d-15552ae96e3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ab30e12a-fe38-4378-9768-bda72cf59263"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e999d374-e872-40d6-aae1-ac5f3e9e014d"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b6997b67-5835-40e1-89b4-95167cd75c35"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("bdf2bd00-edb9-418c-ae61-45810793fce9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("6daf16cd-d567-40aa-b1ac-3e13ed344cf8"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("93851967-7744-4e62-b671-61d7ca6c5632"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ee6cce63-5c75-4d47-ab97-63b659b644d8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("65013716-54ac-482e-b40a-a8167dd0dd0a"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("295814ea-71d8-4421-b0cd-5e7f6ae645ff"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("03ea6441-9ccf-4d66-9370-ed0db76a3e71"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e05b8343-cd69-43a9-acde-ce61b04212d1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38585ad6-e8a0-498a-ac62-8907d1b97fe1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3a8451f9-159c-413d-8062-58c80a7ac5da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d71bb041-35a8-40a8-ba68-5f740ccac2d4"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f79ad1ca-afd4-4cbd-ad1e-17dedb871980"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("38efc1a7-2f9e-4ab8-a8bf-2984b497d6ae"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("07bb0398-5e9b-4a62-8d6e-b308f8010fde"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("63de2e6c-fabd-4e8d-aa75-f49f8af20420"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5bdf2ace-d82f-401d-b255-1285e3e19c71"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ecb632f5-eb6b-4151-b890-c38f0b7c2589"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("55cad308-dc69-4805-8874-e6fe3b208b9f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc418bee-1da0-4d9c-81f5-af649be12102"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3ded752-a354-4722-9e38-d3a2ace3cf8c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("4bbedea2-dd9d-4a7c-bf33-65e4fbb8628e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("86122d9d-1a1b-4cbc-91bc-65b26f7def69"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da310d5d-4239-4e70-a680-b408f2d32c8c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("7244e667-023b-4fa4-acc2-7ccd870f7362"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dbaa5cee-7013-4f0a-b02a-03d69be789f5"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("391fd79b-262a-4e15-8c9f-6ecf0f585615"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af1ed21c-48fc-4364-942d-35136fa62dd9"))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("19c94f49-857c-4e06-817a-f227dcf7d5e2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("10f8fc12-2a86-4113-a1fb-27a9c66e11c2"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f7f82469-5fb3-4905-9503-279d161695b4"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7d8ab02f-ed02-4fdd-a139-f46074af74f3"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d48c86e0-620f-470b-a6c9-54288a1055ad"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ec7bdeb-ceba-4ea3-8b20-436210681aed"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3273082c-8c33-46ad-911c-c98adde059cc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9580fd4b-8a18-460c-b915-13b5362a858a"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("876dd94e-97a8-4a04-9168-698cbca263d5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd5218f2-7580-42e3-9784-8cfb2bcc621d"))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("030b1cc8-f40a-477c-98c9-3ad33bf2f7bb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("704566c9-440a-4af5-843e-4ef9618ca011"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("411c1bf5-c5ab-4638-b002-b8622053b58f"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d60fb7dd-8af7-4548-a32c-bcb0a73be75f"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9db7d13-84dd-4b4f-9041-40f42585a704"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6fd56933-832f-4b67-9030-f50610ffa867"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4d09630-70fb-4e2c-971a-3ee684f3902c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("87536b38-dc21-4259-a084-6955e85e0b2c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c05fb784-6623-4d86-b4cf-52493be1286e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("80f8e2d5-d1d7-4d05-bbca-2e4bb84c8407"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4a8fbf6-b541-489a-ade4-2a156d0396ec"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("32c1e859-a235-41b3-9ef9-5fab37676f50"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("82080543-a890-4547-aef3-048628c74b6e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5e7e074d-171d-45de-a173-aacacd1e5826"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("74b4fe4f-ad09-49fa-9ae1-aa1d2cd6b46a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e349d19d-6023-4713-abf6-94d9534f28f5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ce2992f6-260d-4869-982b-89f0dfcf75db"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("d28e4801-bb24-4726-80e4-5a04a90c12d4"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70cdbdff-50c4-428f-9eec-9fa77f233044"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8bb390f4-321c-4eef-931f-61568231e53d"))));

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

