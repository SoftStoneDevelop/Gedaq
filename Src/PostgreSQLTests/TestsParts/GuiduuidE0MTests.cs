

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
    Id = 4,
    Value = Guid.Parse("01a659c4-3233-40aa-8cb9-b8ec25ae9048"),
    ModelInner = null,
    NullableValue = Guid.Parse("f96df717-dbad-45d1-98cd-8c1fac1c519d"),
},
            new GuiduuidE0M
{
    Id = 6,
    Value = Guid.Parse("c4deb258-61b1-4629-9621-4fd625e68815"),
    ModelInner = new GuiduuidE0MI
{
    Id = 1,
    Value = Guid.Parse("f3bdd5f7-a1ec-416e-9f13-14324809c55a"),
    NullableValue = Guid.Parse("34638be0-72f7-4b74-988c-5e0affcc1e7c"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 12,
    Value = Guid.Parse("5521549c-7c64-4664-8bc6-b4404a756034"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 17,
    Value = Guid.Parse("70769e97-e976-4660-8ede-7c95ec829785"),
    ModelInner = new GuiduuidE0MI
{
    Id = 10,
    Value = Guid.Parse("2b600a7f-e81c-4f5b-b311-7d16d6e3f937"),
    NullableValue = Guid.Parse("a9b5ce10-ec6f-4ce4-bfb1-f1e6b7f858eb"),
},
    NullableValue = Guid.Parse("5cb4ea7c-e51f-42be-94c1-d675f8fd3d55"),
},
            new GuiduuidE0M
{
    Id = 18,
    Value = Guid.Parse("7e5eed05-279f-4c6e-b018-19a87fd6f1cb"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 19,
    Value = Guid.Parse("0a89d3dc-1585-4e76-8b56-92d400429a77"),
    ModelInner = new GuiduuidE0MI
{
    Id = 12,
    Value = Guid.Parse("04d1953c-21a6-4155-bd54-91be182875b5"),
    NullableValue = Guid.Parse("b215c909-4b99-4ccc-82d2-ea28631254ce"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 26,
    Value = Guid.Parse("d8d526a8-4d18-4cee-8191-b277be131ff6"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 29,
    Value = Guid.Parse("7cb33109-03ae-4bbb-9769-2bd79d622033"),
    ModelInner = new GuiduuidE0MI
{
    Id = 13,
    Value = Guid.Parse("35451ddd-cf31-4c01-b38a-49193c155efd"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 36,
    Value = Guid.Parse("5ff154a8-7bf9-430b-8bad-89dedfc719f4"),
    ModelInner = null,
    NullableValue = Guid.Parse("fe72ff53-fe95-4ae9-9b30-34ab6120f708"),
},
            new GuiduuidE0M
{
    Id = 39,
    Value = Guid.Parse("fca8d746-0ddf-4d72-9a49-b4d02316bdc6"),
    ModelInner = new GuiduuidE0MI
{
    Id = 20,
    Value = Guid.Parse("62248d5d-2251-4a9b-a22d-5e2d926cc64b"),
    NullableValue = Guid.Parse("a41e7696-42e5-44da-9a67-71244d4aa87c"),
},
    NullableValue = Guid.Parse("80bf20b0-9648-4b14-8621-13e7ac1e8a33"),
},
            new GuiduuidE0M
{
    Id = 41,
    Value = Guid.Parse("f4fe232a-2ab2-470d-b897-a464b6d2111a"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 44,
    Value = Guid.Parse("061b4f03-d3ed-4acb-9e6b-bbdb9ba57202"),
    ModelInner = new GuiduuidE0MI
{
    Id = 24,
    Value = Guid.Parse("b79e0f95-c6f0-4992-b8ca-b1d96f4f0303"),
    NullableValue = Guid.Parse("ef2fc361-9e37-4a81-b7c9-31734a22982c"),
},
    NullableValue = Guid.Parse("7087e6db-867d-431b-a053-024e83ba48a8"),
},
            new GuiduuidE0M
{
    Id = 49,
    Value = Guid.Parse("3fb57a09-32c1-4f68-a751-7c73b7737701"),
    ModelInner = null,
    NullableValue = Guid.Parse("0cf9a74e-8345-48c5-ad36-d37293a948ed"),
},
            new GuiduuidE0M
{
    Id = 51,
    Value = Guid.Parse("fcd64c13-77e1-4cd2-b372-152850e43e86"),
    ModelInner = new GuiduuidE0MI
{
    Id = 27,
    Value = Guid.Parse("25336674-48b2-460a-b74a-6ac2f503b2e7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 56,
    Value = Guid.Parse("ff07922b-af08-4d31-ae6b-30275f801eca"),
    ModelInner = null,
    NullableValue = Guid.Parse("35388a5e-3bd8-4f83-b410-15f8db1bd8fb"),
},
            new GuiduuidE0M
{
    Id = 57,
    Value = Guid.Parse("c40b6720-bd2d-493d-b826-f7968c9e424e"),
    ModelInner = new GuiduuidE0MI
{
    Id = 31,
    Value = Guid.Parse("c318d7d3-3593-42af-884c-50b6f2091f68"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6735ee57-e6dc-4c6e-9eb5-5a559de3b3fc"),
},
            new GuiduuidE0M
{
    Id = 65,
    Value = Guid.Parse("6f4a3b73-3a36-42f2-bdd9-f5fb6708be0f"),
    ModelInner = null,
    NullableValue = Guid.Parse("4c2f059a-d2c1-44ee-aa1d-c80ff9c28242"),
},
            new GuiduuidE0M
{
    Id = 67,
    Value = Guid.Parse("3ac76289-136d-4263-9e6f-45b3138404a0"),
    ModelInner = new GuiduuidE0MI
{
    Id = 37,
    Value = Guid.Parse("89202a83-ecfc-4507-9576-cec655310166"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 76,
    Value = Guid.Parse("7ea2ac38-9d46-4565-9c1a-f1786e5118a0"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 84,
    Value = Guid.Parse("1158f5e3-f5c8-4624-9db2-b51422a904af"),
    ModelInner = new GuiduuidE0MI
{
    Id = 46,
    Value = Guid.Parse("08514a7f-bc45-432c-ba4e-321242614408"),
    NullableValue = Guid.Parse("ba9cb07f-4dfd-4559-b678-ea1441715d7c"),
},
    NullableValue = Guid.Parse("9c6b8835-45bb-433a-9f14-bcf2b856c0d6"),
},
            new GuiduuidE0M
{
    Id = 86,
    Value = Guid.Parse("ae69111b-e385-4aef-8528-94747003df35"),
    ModelInner = null,
    NullableValue = Guid.Parse("aa6731ca-7180-4da9-a3e4-b253c49ab340"),
},
            new GuiduuidE0M
{
    Id = 91,
    Value = Guid.Parse("d6869568-e7cb-410d-9fc8-3dfdf5f03ab3"),
    ModelInner = new GuiduuidE0MI
{
    Id = 47,
    Value = Guid.Parse("21d710a7-8c6d-4612-96ac-47116e8817c7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 92,
    Value = Guid.Parse("70b3069f-debb-4aae-a53d-c679cd2e4065"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 101,
    Value = Guid.Parse("4ce1dc30-2097-4503-b620-3eb318df7fdd"),
    ModelInner = new GuiduuidE0MI
{
    Id = 51,
    Value = Guid.Parse("d3f95885-caf5-4b2c-a998-fe5ec4b718f9"),
    NullableValue = Guid.Parse("7018fdf4-50ed-4934-bba9-3168b130553b"),
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 105,
    Value = Guid.Parse("535b9651-fee1-4768-bd4c-62fb8f35a27c"),
    ModelInner = null,
    NullableValue = Guid.Parse("af9e913b-fe3e-4bb0-be17-116fa2ba2afa"),
},
            new GuiduuidE0M
{
    Id = 107,
    Value = Guid.Parse("a0c27ae9-54ac-440a-a6f9-6ce0f533e1f3"),
    ModelInner = new GuiduuidE0MI
{
    Id = 54,
    Value = Guid.Parse("5e8740a0-9321-4909-b7a1-5921bba3e8c7"),
    NullableValue = Guid.Parse("99817bec-766e-4b75-a3e5-406c4270be59"),
},
    NullableValue = Guid.Parse("6e74dbcc-990e-4955-8650-3d440205ad27"),
},
            new GuiduuidE0M
{
    Id = 116,
    Value = Guid.Parse("6e8f0557-f1c7-40fb-858a-c906f3642a43"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 118,
    Value = Guid.Parse("9d8d9297-9b1f-45e4-84bd-fa2426547efa"),
    ModelInner = new GuiduuidE0MI
{
    Id = 57,
    Value = Guid.Parse("81aeb1b8-c1c5-4d8a-a3a8-78f076df9d5d"),
    NullableValue = Guid.Parse("87aeacf5-2a69-47a2-a0cb-af502a43ed9b"),
},
    NullableValue = Guid.Parse("4722b99c-7a0e-433f-9b48-e36d085f385e"),
},
            new GuiduuidE0M
{
    Id = 127,
    Value = Guid.Parse("d6be18b2-331b-475b-ba6d-4b92173f9420"),
    ModelInner = null,
    NullableValue = Guid.Parse("5e775ad3-9536-4417-b603-a83dc4d7861f"),
},
            new GuiduuidE0M
{
    Id = 130,
    Value = Guid.Parse("ffd104da-308d-4a02-bd34-3dcb6b44fe05"),
    ModelInner = new GuiduuidE0MI
{
    Id = 63,
    Value = Guid.Parse("880d5347-eec6-4291-ab0d-10239a0ea279"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("acdb632a-32c7-4e92-a54e-73e082ae6565"),
},
            new GuiduuidE0M
{
    Id = 136,
    Value = Guid.Parse("fec37101-bd8d-4bd5-a085-5b3175845882"),
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 144,
    Value = Guid.Parse("1d6d029e-d89a-4c5d-a297-7ff28fad87f5"),
    ModelInner = new GuiduuidE0MI
{
    Id = 68,
    Value = Guid.Parse("d0a64f3e-e18f-4f7d-8aca-4f68f2000927"),
    NullableValue = Guid.Parse("f554f696-0fe0-4633-a90c-ef78742c7c0e"),
},
    NullableValue = Guid.Parse("5b4faa2c-f1f4-4b3b-abf2-78e6bac7ba9c"),
},
            new GuiduuidE0M
{
    Id = 153,
    Value = Guid.Parse("812cbe55-f243-4b8f-9608-72d8076716fc"),
    ModelInner = null,
    NullableValue = Guid.Parse("abde5f8b-e4c1-4d33-97c6-133c0aeba65f"),
},
            new GuiduuidE0M
{
    Id = 155,
    Value = Guid.Parse("b643e4d0-465c-43bb-bb67-3e243549d4cc"),
    ModelInner = new GuiduuidE0MI
{
    Id = 74,
    Value = Guid.Parse("c5492793-49a6-4da8-9ca5-7866e4ee4d43"),
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidE0M
{
    Id = 158,
    Value = Guid.Parse("8ee30c27-171e-4d23-a076-80e25d542634"),
    ModelInner = null,
    NullableValue = Guid.Parse("41f750a8-91ae-4184-8f57-bdd8280c897b"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("fe72ff53-fe95-4ae9-9b30-34ab6120f708")));
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("80bf20b0-9648-4b14-8621-13e7ac1e8a33")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("7087e6db-867d-431b-a053-024e83ba48a8")));
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[25],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidE0M.AssertModel(models[0],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidE0M.AssertModel(models[0],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidE0M.AssertModel(models[0],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 91, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 12, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[34], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidE0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(models[10],_testData[34], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 153, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidE0M.AssertModel(models[0],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidE0M.AssertModel(models[0],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 86, 6))
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidE0M.AssertModel(models[0],_testData[2], false);
                        GuiduuidE0M.AssertModel(models[1],_testData[3], false);
                        GuiduuidE0M.AssertModel(models[2],_testData[4], false);
                        GuiduuidE0M.AssertModel(models[3],_testData[5], false);
                        GuiduuidE0M.AssertModel(models[4],_testData[6], false);
                        GuiduuidE0M.AssertModel(models[5],_testData[7], false);
                        GuiduuidE0M.AssertModel(models[6],_testData[8], false);
                        GuiduuidE0M.AssertModel(models[7],_testData[9], false);
                        GuiduuidE0M.AssertModel(models[8],_testData[10], false);
                        GuiduuidE0M.AssertModel(models[9],_testData[11], false);
                        GuiduuidE0M.AssertModel(models[10],_testData[12], false);
                        GuiduuidE0M.AssertModel(models[11],_testData[13], false);
                        GuiduuidE0M.AssertModel(models[12],_testData[14], false);
                        GuiduuidE0M.AssertModel(models[13],_testData[15], false);
                        GuiduuidE0M.AssertModel(models[14],_testData[16], false);
                        GuiduuidE0M.AssertModel(models[15],_testData[17], false);
                        GuiduuidE0M.AssertModel(models[16],_testData[18], false);
                        GuiduuidE0M.AssertModel(models[17],_testData[19], false);
                        GuiduuidE0M.AssertModel(models[18],_testData[20], false);
                        GuiduuidE0M.AssertModel(models[19],_testData[21], false);
                        GuiduuidE0M.AssertModel(models[20],_testData[22], false);
                        GuiduuidE0M.AssertModel(models[21],_testData[23], false);
                        GuiduuidE0M.AssertModel(models[22],_testData[24], false);
                        GuiduuidE0M.AssertModel(models[23],_testData[25], false);
                        GuiduuidE0M.AssertModel(models[24],_testData[26], false);
                        GuiduuidE0M.AssertModel(models[25],_testData[27], false);
                        GuiduuidE0M.AssertModel(models[26],_testData[28], false);
                        GuiduuidE0M.AssertModel(models[27],_testData[29], false);
                        GuiduuidE0M.AssertModel(models[28],_testData[30], false);
                        GuiduuidE0M.AssertModel(models[29],_testData[31], false);
                        GuiduuidE0M.AssertModel(models[30],_testData[32], false);
                        GuiduuidE0M.AssertModel(models[31],_testData[33], false);
                        GuiduuidE0M.AssertModel(models[32],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                GuiduuidE0M.AssertModel(models[0],_testData[6], false);
                GuiduuidE0M.AssertModel(models[1],_testData[7], false);
                GuiduuidE0M.AssertModel(models[2],_testData[8], false);
                GuiduuidE0M.AssertModel(models[3],_testData[9], false);
                GuiduuidE0M.AssertModel(models[4],_testData[10], false);
                GuiduuidE0M.AssertModel(models[5],_testData[11], false);
                GuiduuidE0M.AssertModel(models[6],_testData[12], false);
                GuiduuidE0M.AssertModel(models[7],_testData[13], false);
                GuiduuidE0M.AssertModel(models[8],_testData[14], false);
                GuiduuidE0M.AssertModel(models[9],_testData[15], false);
                GuiduuidE0M.AssertModel(models[10],_testData[16], false);
                GuiduuidE0M.AssertModel(models[11],_testData[17], false);
                GuiduuidE0M.AssertModel(models[12],_testData[18], false);
                GuiduuidE0M.AssertModel(models[13],_testData[19], false);
                GuiduuidE0M.AssertModel(models[14],_testData[20], false);
                GuiduuidE0M.AssertModel(models[15],_testData[21], false);
                GuiduuidE0M.AssertModel(models[16],_testData[22], false);
                GuiduuidE0M.AssertModel(models[17],_testData[23], false);
                GuiduuidE0M.AssertModel(models[18],_testData[24], false);
                GuiduuidE0M.AssertModel(models[19],_testData[25], false);
                GuiduuidE0M.AssertModel(models[20],_testData[26], false);
                GuiduuidE0M.AssertModel(models[21],_testData[27], false);
                GuiduuidE0M.AssertModel(models[22],_testData[28], false);
                GuiduuidE0M.AssertModel(models[23],_testData[29], false);
                GuiduuidE0M.AssertModel(models[24],_testData[30], false);
                GuiduuidE0M.AssertModel(models[25],_testData[31], false);
                GuiduuidE0M.AssertModel(models[26],_testData[32], false);
                GuiduuidE0M.AssertModel(models[27],_testData[33], false);
                GuiduuidE0M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01a659c4-3233-40aa-8cb9-b8ec25ae9048"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f96df717-dbad-45d1-98cd-8c1fac1c519d"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4deb258-61b1-4629-9621-4fd625e68815"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3bdd5f7-a1ec-416e-9f13-14324809c55a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("34638be0-72f7-4b74-988c-5e0affcc1e7c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5521549c-7c64-4664-8bc6-b4404a756034"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70769e97-e976-4660-8ede-7c95ec829785"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b600a7f-e81c-4f5b-b311-7d16d6e3f937"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9b5ce10-ec6f-4ce4-bfb1-f1e6b7f858eb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5cb4ea7c-e51f-42be-94c1-d675f8fd3d55"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5eed05-279f-4c6e-b018-19a87fd6f1cb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0a89d3dc-1585-4e76-8b56-92d400429a77"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04d1953c-21a6-4155-bd54-91be182875b5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b215c909-4b99-4ccc-82d2-ea28631254ce"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8d526a8-4d18-4cee-8191-b277be131ff6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7cb33109-03ae-4bbb-9769-2bd79d622033"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35451ddd-cf31-4c01-b38a-49193c155efd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ff154a8-7bf9-430b-8bad-89dedfc719f4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fe72ff53-fe95-4ae9-9b30-34ab6120f708"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fca8d746-0ddf-4d72-9a49-b4d02316bdc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("62248d5d-2251-4a9b-a22d-5e2d926cc64b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a41e7696-42e5-44da-9a67-71244d4aa87c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("80bf20b0-9648-4b14-8621-13e7ac1e8a33"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4fe232a-2ab2-470d-b897-a464b6d2111a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("061b4f03-d3ed-4acb-9e6b-bbdb9ba57202"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b79e0f95-c6f0-4992-b8ca-b1d96f4f0303"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef2fc361-9e37-4a81-b7c9-31734a22982c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7087e6db-867d-431b-a053-024e83ba48a8"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3fb57a09-32c1-4f68-a751-7c73b7737701"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0cf9a74e-8345-48c5-ad36-d37293a948ed"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fcd64c13-77e1-4cd2-b372-152850e43e86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("25336674-48b2-460a-b74a-6ac2f503b2e7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff07922b-af08-4d31-ae6b-30275f801eca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("35388a5e-3bd8-4f83-b410-15f8db1bd8fb"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c40b6720-bd2d-493d-b826-f7968c9e424e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c318d7d3-3593-42af-884c-50b6f2091f68"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6735ee57-e6dc-4c6e-9eb5-5a559de3b3fc"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f4a3b73-3a36-42f2-bdd9-f5fb6708be0f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c2f059a-d2c1-44ee-aa1d-c80ff9c28242"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ac76289-136d-4263-9e6f-45b3138404a0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("89202a83-ecfc-4507-9576-cec655310166"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ea2ac38-9d46-4565-9c1a-f1786e5118a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1158f5e3-f5c8-4624-9db2-b51422a904af"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("08514a7f-bc45-432c-ba4e-321242614408"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ba9cb07f-4dfd-4559-b678-ea1441715d7c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c6b8835-45bb-433a-9f14-bcf2b856c0d6"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae69111b-e385-4aef-8528-94747003df35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aa6731ca-7180-4da9-a3e4-b253c49ab340"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6869568-e7cb-410d-9fc8-3dfdf5f03ab3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21d710a7-8c6d-4612-96ac-47116e8817c7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70b3069f-debb-4aae-a53d-c679cd2e4065"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ce1dc30-2097-4503-b620-3eb318df7fdd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3f95885-caf5-4b2c-a998-fe5ec4b718f9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7018fdf4-50ed-4934-bba9-3168b130553b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("535b9651-fee1-4768-bd4c-62fb8f35a27c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af9e913b-fe3e-4bb0-be17-116fa2ba2afa"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0c27ae9-54ac-440a-a6f9-6ce0f533e1f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5e8740a0-9321-4909-b7a1-5921bba3e8c7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("99817bec-766e-4b75-a3e5-406c4270be59"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e74dbcc-990e-4955-8650-3d440205ad27"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6e8f0557-f1c7-40fb-858a-c906f3642a43"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d8d9297-9b1f-45e4-84bd-fa2426547efa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("81aeb1b8-c1c5-4d8a-a3a8-78f076df9d5d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("87aeacf5-2a69-47a2-a0cb-af502a43ed9b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4722b99c-7a0e-433f-9b48-e36d085f385e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6be18b2-331b-475b-ba6d-4b92173f9420"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e775ad3-9536-4417-b603-a83dc4d7861f"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ffd104da-308d-4a02-bd34-3dcb6b44fe05"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("880d5347-eec6-4291-ab0d-10239a0ea279"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acdb632a-32c7-4e92-a54e-73e082ae6565"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fec37101-bd8d-4bd5-a085-5b3175845882"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d6d029e-d89a-4c5d-a297-7ff28fad87f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0a64f3e-e18f-4f7d-8aca-4f68f2000927"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f554f696-0fe0-4633-a90c-ef78742c7c0e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b4faa2c-f1f4-4b3b-abf2-78e6bac7ba9c"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("812cbe55-f243-4b8f-9608-72d8076716fc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("abde5f8b-e4c1-4d33-97c6-133c0aeba65f"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b643e4d0-465c-43bb-bb67-3e243549d4cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c5492793-49a6-4da8-9ca5-7866e4ee4d43"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee30c27-171e-4d23-a076-80e25d542634"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("41f750a8-91ae-4184-8f57-bdd8280c897b"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("01a659c4-3233-40aa-8cb9-b8ec25ae9048"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("f96df717-dbad-45d1-98cd-8c1fac1c519d"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c4deb258-61b1-4629-9621-4fd625e68815"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f3bdd5f7-a1ec-416e-9f13-14324809c55a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("34638be0-72f7-4b74-988c-5e0affcc1e7c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5521549c-7c64-4664-8bc6-b4404a756034"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70769e97-e976-4660-8ede-7c95ec829785"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2b600a7f-e81c-4f5b-b311-7d16d6e3f937"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a9b5ce10-ec6f-4ce4-bfb1-f1e6b7f858eb"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5cb4ea7c-e51f-42be-94c1-d675f8fd3d55"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7e5eed05-279f-4c6e-b018-19a87fd6f1cb"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0a89d3dc-1585-4e76-8b56-92d400429a77"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("04d1953c-21a6-4155-bd54-91be182875b5"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b215c909-4b99-4ccc-82d2-ea28631254ce"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d8d526a8-4d18-4cee-8191-b277be131ff6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7cb33109-03ae-4bbb-9769-2bd79d622033"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35451ddd-cf31-4c01-b38a-49193c155efd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5ff154a8-7bf9-430b-8bad-89dedfc719f4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("fe72ff53-fe95-4ae9-9b30-34ab6120f708"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fca8d746-0ddf-4d72-9a49-b4d02316bdc6"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("62248d5d-2251-4a9b-a22d-5e2d926cc64b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("a41e7696-42e5-44da-9a67-71244d4aa87c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("80bf20b0-9648-4b14-8621-13e7ac1e8a33"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f4fe232a-2ab2-470d-b897-a464b6d2111a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("061b4f03-d3ed-4acb-9e6b-bbdb9ba57202"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b79e0f95-c6f0-4992-b8ca-b1d96f4f0303"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef2fc361-9e37-4a81-b7c9-31734a22982c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7087e6db-867d-431b-a053-024e83ba48a8"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3fb57a09-32c1-4f68-a751-7c73b7737701"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0cf9a74e-8345-48c5-ad36-d37293a948ed"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fcd64c13-77e1-4cd2-b372-152850e43e86"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("25336674-48b2-460a-b74a-6ac2f503b2e7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff07922b-af08-4d31-ae6b-30275f801eca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("35388a5e-3bd8-4f83-b410-15f8db1bd8fb"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c40b6720-bd2d-493d-b826-f7968c9e424e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c318d7d3-3593-42af-884c-50b6f2091f68"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6735ee57-e6dc-4c6e-9eb5-5a559de3b3fc"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6f4a3b73-3a36-42f2-bdd9-f5fb6708be0f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4c2f059a-d2c1-44ee-aa1d-c80ff9c28242"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3ac76289-136d-4263-9e6f-45b3138404a0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("89202a83-ecfc-4507-9576-cec655310166"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7ea2ac38-9d46-4565-9c1a-f1786e5118a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1158f5e3-f5c8-4624-9db2-b51422a904af"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("08514a7f-bc45-432c-ba4e-321242614408"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ba9cb07f-4dfd-4559-b678-ea1441715d7c"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9c6b8835-45bb-433a-9f14-bcf2b856c0d6"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae69111b-e385-4aef-8528-94747003df35"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("aa6731ca-7180-4da9-a3e4-b253c49ab340"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6869568-e7cb-410d-9fc8-3dfdf5f03ab3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("21d710a7-8c6d-4612-96ac-47116e8817c7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70b3069f-debb-4aae-a53d-c679cd2e4065"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4ce1dc30-2097-4503-b620-3eb318df7fdd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3f95885-caf5-4b2c-a998-fe5ec4b718f9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7018fdf4-50ed-4934-bba9-3168b130553b"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("535b9651-fee1-4768-bd4c-62fb8f35a27c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af9e913b-fe3e-4bb0-be17-116fa2ba2afa"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a0c27ae9-54ac-440a-a6f9-6ce0f533e1f3"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5e8740a0-9321-4909-b7a1-5921bba3e8c7"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("99817bec-766e-4b75-a3e5-406c4270be59"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6e74dbcc-990e-4955-8650-3d440205ad27"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6e8f0557-f1c7-40fb-858a-c906f3642a43"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d8d9297-9b1f-45e4-84bd-fa2426547efa"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("81aeb1b8-c1c5-4d8a-a3a8-78f076df9d5d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("87aeacf5-2a69-47a2-a0cb-af502a43ed9b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("4722b99c-7a0e-433f-9b48-e36d085f385e"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d6be18b2-331b-475b-ba6d-4b92173f9420"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5e775ad3-9536-4417-b603-a83dc4d7861f"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ffd104da-308d-4a02-bd34-3dcb6b44fe05"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("880d5347-eec6-4291-ab0d-10239a0ea279"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acdb632a-32c7-4e92-a54e-73e082ae6565"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fec37101-bd8d-4bd5-a085-5b3175845882"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1d6d029e-d89a-4c5d-a297-7ff28fad87f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0a64f3e-e18f-4f7d-8aca-4f68f2000927"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f554f696-0fe0-4633-a90c-ef78742c7c0e"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5b4faa2c-f1f4-4b3b-abf2-78e6bac7ba9c"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("812cbe55-f243-4b8f-9608-72d8076716fc"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("abde5f8b-e4c1-4d33-97c6-133c0aeba65f"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b643e4d0-465c-43bb-bb67-3e243549d4cc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c5492793-49a6-4da8-9ca5-7866e4ee4d43"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee30c27-171e-4d23-a076-80e25d542634"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("41f750a8-91ae-4184-8f57-bdd8280c897b"))));

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

