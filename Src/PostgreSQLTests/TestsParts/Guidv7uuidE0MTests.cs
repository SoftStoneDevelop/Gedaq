

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

        private readonly Guidv7uuidE0M[] _testData = new Guidv7uuidE0M[]
        {
            new Guidv7uuidE0M
{
    Id = 6,
    Value = Guid.Parse("019e1b45-9255-70d8-853f-8b3046b2249f"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-78cb-b59e-ef6bc4462ef0"),
},
            new Guidv7uuidE0M
{
    Id = 13,
    Value = Guid.Parse("019e1b45-9255-7178-bb62-77f7cc1097bc"),
    ModelInner = new GuiduuidE0MI
{
    Id = 6,
    Value = Guid.Parse("019e1b45-9255-7b3d-94e2-14e10bf5fd46"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 15,
    Value = Guid.Parse("019e1b45-9255-7d0b-8b96-3606d54738d6"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7ca7-b1c5-2f1f641739c9"),
},
            new Guidv7uuidE0M
{
    Id = 24,
    Value = Guid.Parse("019e1b45-9255-75b2-92e0-3d3495579ac8"),
    ModelInner = new GuiduuidE0MI
{
    Id = 10,
    Value = Guid.Parse("019e1b45-9255-7495-914b-d07370fa984a"),
    NullableValue = Guid.Parse("019e1b45-9255-721b-9620-c72a7ed24352"),
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 26,
    Value = Guid.Parse("019e1b45-9255-723f-94d7-48df1f0505b7"),
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 30,
    Value = Guid.Parse("019e1b45-9255-7448-b6ea-5587723900da"),
    ModelInner = new GuiduuidE0MI
{
    Id = 12,
    Value = Guid.Parse("019e1b45-9255-76c4-8951-5cd184e3de1d"),
    NullableValue = Guid.Parse("019e1b45-9255-708f-acc4-9d456dda2aa1"),
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 39,
    Value = Guid.Parse("019e1b45-9255-7a6c-8fb4-d5988ef05786"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-778e-81f5-c9857c0d9248"),
},
            new Guidv7uuidE0M
{
    Id = 48,
    Value = Guid.Parse("019e1b45-9255-7d92-9d19-0fa85bbad1f4"),
    ModelInner = new GuiduuidE0MI
{
    Id = 17,
    Value = Guid.Parse("019e1b45-9255-7b9b-a303-a53f5089412c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-7fbc-a6df-ad71f8dc941e"),
},
            new Guidv7uuidE0M
{
    Id = 53,
    Value = Guid.Parse("019e1b45-9255-75f2-a4c4-997535ba11fd"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7db3-b229-9f91473f2cf0"),
},
            new Guidv7uuidE0M
{
    Id = 61,
    Value = Guid.Parse("019e1b45-9255-71d5-9e77-c74e373e2828"),
    ModelInner = new GuiduuidE0MI
{
    Id = 21,
    Value = Guid.Parse("019e1b45-9255-7db8-8fb1-2e02df42b4fa"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-7ff4-bc15-8691888edb5e"),
},
            new Guidv7uuidE0M
{
    Id = 67,
    Value = Guid.Parse("019e1b45-9255-7445-9a8b-c0d0b2ab6f06"),
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 72,
    Value = Guid.Parse("019e1b45-9255-7ea2-9cc8-befbcd1d67ab"),
    ModelInner = new GuiduuidE0MI
{
    Id = 28,
    Value = Guid.Parse("019e1b45-9255-7069-a89c-eaf0b2a6c81c"),
    NullableValue = Guid.Parse("019e1b45-9255-7e63-bbbe-d6c7581610ed"),
},
    NullableValue = Guid.Parse("019e1b45-9255-7867-9b55-7f90aed13796"),
},
            new Guidv7uuidE0M
{
    Id = 81,
    Value = Guid.Parse("019e1b45-9255-7cc9-ab85-7ccdcacfa191"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-78a9-b6b3-d5279b6f2c29"),
},
            new Guidv7uuidE0M
{
    Id = 84,
    Value = Guid.Parse("019e1b45-9255-7add-a2f4-d16e54d9e9c0"),
    ModelInner = new GuiduuidE0MI
{
    Id = 32,
    Value = Guid.Parse("019e1b45-9255-7baf-933e-afa8db273b83"),
    NullableValue = Guid.Parse("019e1b45-9255-7d85-8117-64040b55fd57"),
},
    NullableValue = Guid.Parse("019e1b45-9255-7bce-94fc-4c610a5924d6"),
},
            new Guidv7uuidE0M
{
    Id = 93,
    Value = Guid.Parse("019e1b45-9255-736b-b063-f8672128d9af"),
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 102,
    Value = Guid.Parse("019e1b45-9255-7dbc-97f4-12b906e6ac76"),
    ModelInner = new GuiduuidE0MI
{
    Id = 36,
    Value = Guid.Parse("019e1b45-9255-7701-9f42-ef1d2b7d7b7e"),
    NullableValue = Guid.Parse("019e1b45-9255-798a-9f2e-fc900ff82622"),
},
    NullableValue = Guid.Parse("019e1b45-9255-7acf-8739-56d4c3797cd1"),
},
            new Guidv7uuidE0M
{
    Id = 104,
    Value = Guid.Parse("019e1b45-9255-74a9-a660-cdd94d111a1f"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7f4e-ae8c-e6d710794809"),
},
            new Guidv7uuidE0M
{
    Id = 107,
    Value = Guid.Parse("019e1b45-9255-79bb-92f7-417ebe10f7a7"),
    ModelInner = new GuiduuidE0MI
{
    Id = 45,
    Value = Guid.Parse("019e1b45-9255-74cb-bbdd-1f26b028ad04"),
    NullableValue = Guid.Parse("019e1b45-9255-733d-93f8-5f2919f720fe"),
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 115,
    Value = Guid.Parse("019e1b45-9255-761b-b878-30fcf26b15ab"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-76dd-a560-aec055eb3d8b"),
},
            new Guidv7uuidE0M
{
    Id = 116,
    Value = Guid.Parse("019e1b45-9255-7809-a8fe-60b14198dc54"),
    ModelInner = new GuiduuidE0MI
{
    Id = 51,
    Value = Guid.Parse("019e1b45-9255-7119-bc17-1d4734b3942a"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-7e65-b211-843eaeb1d179"),
},
            new Guidv7uuidE0M
{
    Id = 118,
    Value = Guid.Parse("019e1b45-9255-7bb1-9c3a-f846b475c6c7"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7490-b253-00f89cfb3371"),
},
            new Guidv7uuidE0M
{
    Id = 119,
    Value = Guid.Parse("019e1b45-9255-7750-84ce-e29e178bc551"),
    ModelInner = new GuiduuidE0MI
{
    Id = 52,
    Value = Guid.Parse("019e1b45-9255-7810-b7ef-76b7410f59dd"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-705b-be69-ea4cf53238e0"),
},
            new Guidv7uuidE0M
{
    Id = 126,
    Value = Guid.Parse("019e1b45-9255-7ce7-9f77-6322c8299e04"),
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 135,
    Value = Guid.Parse("019e1b45-9255-7c4c-8e4a-9f92b64355c2"),
    ModelInner = new GuiduuidE0MI
{
    Id = 56,
    Value = Guid.Parse("019e1b45-9255-77bd-bd05-b52328c7b1f2"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 138,
    Value = Guid.Parse("019e1b45-9255-795d-894a-fe26994a8c54"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-709d-8489-7e97fc4e1b23"),
},
            new Guidv7uuidE0M
{
    Id = 143,
    Value = Guid.Parse("019e1b45-9255-75ed-85e8-b27d409c9886"),
    ModelInner = new GuiduuidE0MI
{
    Id = 61,
    Value = Guid.Parse("019e1b45-9255-7291-8446-652cd63df535"),
    NullableValue = Guid.Parse("019e1b45-9255-7e6e-aa02-2ccddb17598e"),
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 146,
    Value = Guid.Parse("019e1b45-9255-77ab-8919-14c91dd2718f"),
    ModelInner = null,
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 152,
    Value = Guid.Parse("019e1b45-9255-7731-b39e-0933815435f1"),
    ModelInner = new GuiduuidE0MI
{
    Id = 65,
    Value = Guid.Parse("019e1b45-9255-75f7-89be-d53ea665a58e"),
    NullableValue = Guid.Parse("019e1b45-9255-7e6a-95b3-0270c5facb66"),
},
    NullableValue = null,
},
            new Guidv7uuidE0M
{
    Id = 158,
    Value = Guid.Parse("019e1b45-9255-7440-859a-11e40d53041e"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7b0e-8b3c-473204751122"),
},
            new Guidv7uuidE0M
{
    Id = 160,
    Value = Guid.Parse("019e1b45-9255-7d4f-a6d9-08edf8e51d8b"),
    ModelInner = new GuiduuidE0MI
{
    Id = 66,
    Value = Guid.Parse("019e1b45-9255-7d74-8580-372db5a06300"),
    NullableValue = Guid.Parse("019e1b45-9255-764b-8107-55c092b86415"),
},
    NullableValue = Guid.Parse("019e1b45-9255-7629-a1c8-b2ce3a719a5a"),
},
            new Guidv7uuidE0M
{
    Id = 163,
    Value = Guid.Parse("019e1b45-9255-7b6b-8df0-46b1da895bed"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7df7-9f53-31a931b32ae3"),
},
            new Guidv7uuidE0M
{
    Id = 164,
    Value = Guid.Parse("019e1b45-9255-7b69-822d-9ac7862a6a05"),
    ModelInner = new GuiduuidE0MI
{
    Id = 67,
    Value = Guid.Parse("019e1b45-9255-7363-968c-89126c919860"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-7238-84b8-162ea8ec844c"),
},
            new Guidv7uuidE0M
{
    Id = 169,
    Value = Guid.Parse("019e1b45-9255-7051-ad66-d7902204a9bf"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7043-8929-5944c1f2790a"),
},
            new Guidv7uuidE0M
{
    Id = 173,
    Value = Guid.Parse("019e1b45-9255-7d07-bf4b-d60d14bb522c"),
    ModelInner = new GuiduuidE0MI
{
    Id = 75,
    Value = Guid.Parse("019e1b45-9255-7559-86e8-463caaab3f24"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("019e1b45-9255-796a-9f67-af8af486a211"),
},
            new Guidv7uuidE0M
{
    Id = 177,
    Value = Guid.Parse("019e1b45-9255-759a-856b-f9352e1046ca"),
    ModelInner = null,
    NullableValue = Guid.Parse("019e1b45-9255-7c1d-b0ea-db583e494d07"),
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
INSERT INTO public.guidv7uuide0m(
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
INSERT INTO public.guidv7uuide0m(
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
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("019e1b45-9255-778e-81f5-c9857c0d9248")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("019e1b45-9255-7fbc-a6df-ad71f8dc941e")));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuide0m(
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
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("019e1b45-9255-7db3-b229-9f91473f2cf0")));
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("019e1b45-9255-7ff4-bc15-8691888edb5e")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("019e1b45-9255-7867-9b55-7f90aed13796")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidE0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guidv7uuidE0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guidv7uuidE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guidv7uuide0m(
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
            queryMapTypes: [typeof(FlatGuidv7uuidE0M), typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
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
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
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
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M), typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M), typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr2.Value = 61;
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 169;
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
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
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(models[9],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(models[10],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(models[11],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(models[12],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(models[13],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(models[14],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(models[15],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(models[16],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(models[17],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(models[18],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(models[19],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(models[20],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(models[21],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(models[22],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(models[23],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[24],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[25],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[26],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[27],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[28],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[29],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[30],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 6;
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guidv7uuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[10], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[11], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[12], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[13], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[14], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[15], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[16], false);
                        Guidv7uuidE0M.AssertModel(models[7],_testData[17], false);
                        Guidv7uuidE0M.AssertModel(models[8],_testData[18], false);
                        Guidv7uuidE0M.AssertModel(models[9],_testData[19], false);
                        Guidv7uuidE0M.AssertModel(models[10],_testData[20], false);
                        Guidv7uuidE0M.AssertModel(models[11],_testData[21], false);
                        Guidv7uuidE0M.AssertModel(models[12],_testData[22], false);
                        Guidv7uuidE0M.AssertModel(models[13],_testData[23], false);
                        Guidv7uuidE0M.AssertModel(models[14],_testData[24], false);
                        Guidv7uuidE0M.AssertModel(models[15],_testData[25], false);
                        Guidv7uuidE0M.AssertModel(models[16],_testData[26], false);
                        Guidv7uuidE0M.AssertModel(models[17],_testData[27], false);
                        Guidv7uuidE0M.AssertModel(models[18],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[19],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[20],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[21],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[22],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[23],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[24],_testData[34], false);
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[19], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[20], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[21], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[22], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[23], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[24], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[25], false);
                        Guidv7uuidE0M.AssertModel(models[7],_testData[26], false);
                        Guidv7uuidE0M.AssertModel(models[8],_testData[27], false);
                        Guidv7uuidE0M.AssertModel(models[9],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[10],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[11],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[12],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[13],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[14],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[25], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[26], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[27], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[7],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[8],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M), typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 160, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 13, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuidv7uuidE0M>();
                var models2 = new List<FlatGuidv7uuidE0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models1[i],_testData[i], false);
                    FlatGuidv7uuidE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var firstItems2 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 160, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuidv7uuidE0M)],
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[9],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[10],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[11],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[12],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[1], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[2], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(models[9],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(models[10],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(models[11],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(models[12],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(models[13],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(models[14],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(models[15],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(models[16],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(models[17],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(models[18],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(models[19],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(models[20],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(models[21],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(models[22],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(models[23],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(models[24],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(models[25],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[26],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[27],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[28],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[29],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[30],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[31],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[32],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[33],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 164, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[9],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[10],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[11],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuidv7uuidE0M.AssertModel(models[0],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(models[1],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(models[2],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(models[3],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(models[4],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(models[5],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(models[6],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(models[7],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(models[8],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(models[9],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(models[10],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(models[11],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
FROM public.guidv7uuide0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems1 = new List<FlatGuidv7uuidE0M>();
                var secondItems2 = new List<FlatGuidv7uuidE0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuidv7uuidE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.guidv7uuide0m m
LEFT JOIN public.guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[13], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[14], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[15], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[16], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[17], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[18], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[19], false);
                        Guidv7uuidE0M.AssertModel(models[7],_testData[20], false);
                        Guidv7uuidE0M.AssertModel(models[8],_testData[21], false);
                        Guidv7uuidE0M.AssertModel(models[9],_testData[22], false);
                        Guidv7uuidE0M.AssertModel(models[10],_testData[23], false);
                        Guidv7uuidE0M.AssertModel(models[11],_testData[24], false);
                        Guidv7uuidE0M.AssertModel(models[12],_testData[25], false);
                        Guidv7uuidE0M.AssertModel(models[13],_testData[26], false);
                        Guidv7uuidE0M.AssertModel(models[14],_testData[27], false);
                        Guidv7uuidE0M.AssertModel(models[15],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[16],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[17],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[18],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[19],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[20],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[34], false);
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
                    Guidv7uuidE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 160, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Guidv7uuidE0M.AssertModel(models[0],_testData[14], false);
                        Guidv7uuidE0M.AssertModel(models[1],_testData[15], false);
                        Guidv7uuidE0M.AssertModel(models[2],_testData[16], false);
                        Guidv7uuidE0M.AssertModel(models[3],_testData[17], false);
                        Guidv7uuidE0M.AssertModel(models[4],_testData[18], false);
                        Guidv7uuidE0M.AssertModel(models[5],_testData[19], false);
                        Guidv7uuidE0M.AssertModel(models[6],_testData[20], false);
                        Guidv7uuidE0M.AssertModel(models[7],_testData[21], false);
                        Guidv7uuidE0M.AssertModel(models[8],_testData[22], false);
                        Guidv7uuidE0M.AssertModel(models[9],_testData[23], false);
                        Guidv7uuidE0M.AssertModel(models[10],_testData[24], false);
                        Guidv7uuidE0M.AssertModel(models[11],_testData[25], false);
                        Guidv7uuidE0M.AssertModel(models[12],_testData[26], false);
                        Guidv7uuidE0M.AssertModel(models[13],_testData[27], false);
                        Guidv7uuidE0M.AssertModel(models[14],_testData[28], false);
                        Guidv7uuidE0M.AssertModel(models[15],_testData[29], false);
                        Guidv7uuidE0M.AssertModel(models[16],_testData[30], false);
                        Guidv7uuidE0M.AssertModel(models[17],_testData[31], false);
                        Guidv7uuidE0M.AssertModel(models[18],_testData[32], false);
                        Guidv7uuidE0M.AssertModel(models[19],_testData[33], false);
                        Guidv7uuidE0M.AssertModel(models[20],_testData[34], false);
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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Guidv7uuidE0M.AssertModel(models[0],_testData[9], false);
                Guidv7uuidE0M.AssertModel(models[1],_testData[10], false);
                Guidv7uuidE0M.AssertModel(models[2],_testData[11], false);
                Guidv7uuidE0M.AssertModel(models[3],_testData[12], false);
                Guidv7uuidE0M.AssertModel(models[4],_testData[13], false);
                Guidv7uuidE0M.AssertModel(models[5],_testData[14], false);
                Guidv7uuidE0M.AssertModel(models[6],_testData[15], false);
                Guidv7uuidE0M.AssertModel(models[7],_testData[16], false);
                Guidv7uuidE0M.AssertModel(models[8],_testData[17], false);
                Guidv7uuidE0M.AssertModel(models[9],_testData[18], false);
                Guidv7uuidE0M.AssertModel(models[10],_testData[19], false);
                Guidv7uuidE0M.AssertModel(models[11],_testData[20], false);
                Guidv7uuidE0M.AssertModel(models[12],_testData[21], false);
                Guidv7uuidE0M.AssertModel(models[13],_testData[22], false);
                Guidv7uuidE0M.AssertModel(models[14],_testData[23], false);
                Guidv7uuidE0M.AssertModel(models[15],_testData[24], false);
                Guidv7uuidE0M.AssertModel(models[16],_testData[25], false);
                Guidv7uuidE0M.AssertModel(models[17],_testData[26], false);
                Guidv7uuidE0M.AssertModel(models[18],_testData[27], false);
                Guidv7uuidE0M.AssertModel(models[19],_testData[28], false);
                Guidv7uuidE0M.AssertModel(models[20],_testData[29], false);
                Guidv7uuidE0M.AssertModel(models[21],_testData[30], false);
                Guidv7uuidE0M.AssertModel(models[22],_testData[31], false);
                Guidv7uuidE0M.AssertModel(models[23],_testData[32], false);
                Guidv7uuidE0M.AssertModel(models[24],_testData[33], false);
                Guidv7uuidE0M.AssertModel(models[25],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(13));

                Guidv7uuidE0M.AssertModel(models[0],_testData[22], false);
                Guidv7uuidE0M.AssertModel(models[1],_testData[23], false);
                Guidv7uuidE0M.AssertModel(models[2],_testData[24], false);
                Guidv7uuidE0M.AssertModel(models[3],_testData[25], false);
                Guidv7uuidE0M.AssertModel(models[4],_testData[26], false);
                Guidv7uuidE0M.AssertModel(models[5],_testData[27], false);
                Guidv7uuidE0M.AssertModel(models[6],_testData[28], false);
                Guidv7uuidE0M.AssertModel(models[7],_testData[29], false);
                Guidv7uuidE0M.AssertModel(models[8],_testData[30], false);
                Guidv7uuidE0M.AssertModel(models[9],_testData[31], false);
                Guidv7uuidE0M.AssertModel(models[10],_testData[32], false);
                Guidv7uuidE0M.AssertModel(models[11],_testData[33], false);
                Guidv7uuidE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.guidv7uuide0m m
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-70d8-853f-8b3046b2249f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-78cb-b59e-ef6bc4462ef0"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7178-bb62-77f7cc1097bc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7b3d-94e2-14e10bf5fd46"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d0b-8b96-3606d54738d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7ca7-b1c5-2f1f641739c9"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75b2-92e0-3d3495579ac8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7495-914b-d07370fa984a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-721b-9620-c72a7ed24352"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-723f-94d7-48df1f0505b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7448-b6ea-5587723900da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-76c4-8951-5cd184e3de1d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-708f-acc4-9d456dda2aa1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7a6c-8fb4-d5988ef05786"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-778e-81f5-c9857c0d9248"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d92-9d19-0fa85bbad1f4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7b9b-a303-a53f5089412c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7fbc-a6df-ad71f8dc941e"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75f2-a4c4-997535ba11fd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7db3-b229-9f91473f2cf0"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-71d5-9e77-c74e373e2828"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7db8-8fb1-2e02df42b4fa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7ff4-bc15-8691888edb5e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7445-9a8b-c0d0b2ab6f06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7ea2-9cc8-befbcd1d67ab"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7069-a89c-eaf0b2a6c81c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e63-bbbe-d6c7581610ed"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7867-9b55-7f90aed13796"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7cc9-ab85-7ccdcacfa191"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-78a9-b6b3-d5279b6f2c29"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7add-a2f4-d16e54d9e9c0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7baf-933e-afa8db273b83"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7d85-8117-64040b55fd57"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7bce-94fc-4c610a5924d6"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-736b-b063-f8672128d9af"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7dbc-97f4-12b906e6ac76"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7701-9f42-ef1d2b7d7b7e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-798a-9f2e-fc900ff82622"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7acf-8739-56d4c3797cd1"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-74a9-a660-cdd94d111a1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7f4e-ae8c-e6d710794809"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-79bb-92f7-417ebe10f7a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-74cb-bbdd-1f26b028ad04"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-733d-93f8-5f2919f720fe"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-761b-b878-30fcf26b15ab"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-76dd-a560-aec055eb3d8b"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7809-a8fe-60b14198dc54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7119-bc17-1d4734b3942a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7e65-b211-843eaeb1d179"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7bb1-9c3a-f846b475c6c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7490-b253-00f89cfb3371"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7750-84ce-e29e178bc551"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7810-b7ef-76b7410f59dd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-705b-be69-ea4cf53238e0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7ce7-9f77-6322c8299e04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7c4c-8e4a-9f92b64355c2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-77bd-bd05-b52328c7b1f2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-795d-894a-fe26994a8c54"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-709d-8489-7e97fc4e1b23"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75ed-85e8-b27d409c9886"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7291-8446-652cd63df535"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e6e-aa02-2ccddb17598e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-77ab-8919-14c91dd2718f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7731-b39e-0933815435f1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-75f7-89be-d53ea665a58e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e6a-95b3-0270c5facb66"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7440-859a-11e40d53041e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7b0e-8b3c-473204751122"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d4f-a6d9-08edf8e51d8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7d74-8580-372db5a06300"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-764b-8107-55c092b86415"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7629-a1c8-b2ce3a719a5a"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7b6b-8df0-46b1da895bed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7df7-9f53-31a931b32ae3"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7b69-822d-9ac7862a6a05"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7363-968c-89126c919860"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7238-84b8-162ea8ec844c"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7051-ad66-d7902204a9bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7043-8929-5944c1f2790a"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d07-bf4b-d60d14bb522c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7559-86e8-463caaab3f24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-796a-9f67-af8af486a211"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-759a-856b-f9352e1046ca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7c1d-b0ea-db583e494d07"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-70d8-853f-8b3046b2249f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-78cb-b59e-ef6bc4462ef0"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7178-bb62-77f7cc1097bc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7b3d-94e2-14e10bf5fd46"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d0b-8b96-3606d54738d6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7ca7-b1c5-2f1f641739c9"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75b2-92e0-3d3495579ac8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7495-914b-d07370fa984a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-721b-9620-c72a7ed24352"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-723f-94d7-48df1f0505b7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7448-b6ea-5587723900da"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-76c4-8951-5cd184e3de1d"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-708f-acc4-9d456dda2aa1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7a6c-8fb4-d5988ef05786"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-778e-81f5-c9857c0d9248"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d92-9d19-0fa85bbad1f4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7b9b-a303-a53f5089412c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7fbc-a6df-ad71f8dc941e"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75f2-a4c4-997535ba11fd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7db3-b229-9f91473f2cf0"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-71d5-9e77-c74e373e2828"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7db8-8fb1-2e02df42b4fa"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7ff4-bc15-8691888edb5e"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7445-9a8b-c0d0b2ab6f06"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7ea2-9cc8-befbcd1d67ab"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7069-a89c-eaf0b2a6c81c"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e63-bbbe-d6c7581610ed"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7867-9b55-7f90aed13796"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7cc9-ab85-7ccdcacfa191"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-78a9-b6b3-d5279b6f2c29"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7add-a2f4-d16e54d9e9c0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7baf-933e-afa8db273b83"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7d85-8117-64040b55fd57"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7bce-94fc-4c610a5924d6"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-736b-b063-f8672128d9af"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7dbc-97f4-12b906e6ac76"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7701-9f42-ef1d2b7d7b7e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-798a-9f2e-fc900ff82622"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7acf-8739-56d4c3797cd1"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-74a9-a660-cdd94d111a1f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7f4e-ae8c-e6d710794809"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-79bb-92f7-417ebe10f7a7"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-74cb-bbdd-1f26b028ad04"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-733d-93f8-5f2919f720fe"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-761b-b878-30fcf26b15ab"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-76dd-a560-aec055eb3d8b"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7809-a8fe-60b14198dc54"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7119-bc17-1d4734b3942a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7e65-b211-843eaeb1d179"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7bb1-9c3a-f846b475c6c7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7490-b253-00f89cfb3371"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7750-84ce-e29e178bc551"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7810-b7ef-76b7410f59dd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-705b-be69-ea4cf53238e0"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7ce7-9f77-6322c8299e04"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7c4c-8e4a-9f92b64355c2"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-77bd-bd05-b52328c7b1f2"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-795d-894a-fe26994a8c54"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-709d-8489-7e97fc4e1b23"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-75ed-85e8-b27d409c9886"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7291-8446-652cd63df535"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e6e-aa02-2ccddb17598e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-77ab-8919-14c91dd2718f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7731-b39e-0933815435f1"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-75f7-89be-d53ea665a58e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-7e6a-95b3-0270c5facb66"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7440-859a-11e40d53041e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7b0e-8b3c-473204751122"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d4f-a6d9-08edf8e51d8b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7d74-8580-372db5a06300"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("019e1b45-9255-764b-8107-55c092b86415"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7629-a1c8-b2ce3a719a5a"))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7b6b-8df0-46b1da895bed"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7df7-9f53-31a931b32ae3"))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7b69-822d-9ac7862a6a05"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7363-968c-89126c919860"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7238-84b8-162ea8ec844c"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7051-ad66-d7902204a9bf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7043-8929-5944c1f2790a"))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-7d07-bf4b-d60d14bb522c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("019e1b45-9255-7559-86e8-463caaab3f24"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-796a-9f67-af8af486a211"))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("019e1b45-9255-759a-856b-f9352e1046ca"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("019e1b45-9255-7c1d-b0ea-db583e494d07"))));

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
COPY public.binary_guidv7uuide0m
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
            queryMapType: typeof(Guidv7uuidE0M),
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
FROM public.binary_guidv7uuide0m m
LEFT JOIN public.binary_guiduuide0mi mi ON mi.id = m.guiduuide0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                var importCollection = new List<Guidv7uuidE0M>();
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
                    Guidv7uuidE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guidv7uuidE0M>();
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
                    Guidv7uuidE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guidv7uuide0m
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
            queryMapTypes: [typeof(Guidv7uuidE0M)],
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
                    Guidv7uuidE0M.AssertModel(model, expectedModel, true);
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
                    Guidv7uuidE0M.AssertModel(model, expectedModel, true);
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

