

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
    Id = 8,
    Value = Guid.Parse("cecc05cc-3393-444e-ae84-685398a831a0"),
    ModelInner = null,
    NullableValue = Guid.Parse("dc9b2cc5-f001-4710-9a8d-82a49265daea"),
},
            new Guiduuid0M
{
    Id = 12,
    Value = Guid.Parse("e7a17890-f812-4221-bcf1-839f5a05c8c9"),
    ModelInner = new Guiduuid0MI
{
    Id = 6,
    Value = Guid.Parse("6dbdbd3d-0af4-434a-82f4-a0ba3a17194d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 18,
    Value = Guid.Parse("ef52e1a2-1ecb-4b26-a8dc-ae8026f93541"),
    ModelInner = null,
    NullableValue = Guid.Parse("b7940a1c-193b-48a1-8b2a-18ab35a65a30"),
},
            new Guiduuid0M
{
    Id = 24,
    Value = Guid.Parse("d057baa1-0254-47e5-9e32-57f82f483e28"),
    ModelInner = new Guiduuid0MI
{
    Id = 12,
    Value = Guid.Parse("b9e989c8-d2e0-46b8-a9b4-638beefea57c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("c229148a-783d-46ca-8090-d9f676e0a0a8"),
},
            new Guiduuid0M
{
    Id = 30,
    Value = Guid.Parse("1320da2a-7843-4d35-a31b-21c6b94a3211"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 31,
    Value = Guid.Parse("f123c003-8dcd-42f6-9b26-ef0b617afec5"),
    ModelInner = new Guiduuid0MI
{
    Id = 21,
    Value = Guid.Parse("266f5e75-eeb5-4657-9d8d-d7721f5a8fb4"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 38,
    Value = Guid.Parse("61f27116-623b-4215-8c70-bf823397fa8f"),
    ModelInner = null,
    NullableValue = Guid.Parse("a9e1f61e-e627-4ff8-a9e2-7c3c0d3ea0b5"),
},
            new Guiduuid0M
{
    Id = 40,
    Value = Guid.Parse("c9a4de6c-e350-4292-bc89-ab9589e7c505"),
    ModelInner = new Guiduuid0MI
{
    Id = 22,
    Value = Guid.Parse("35759234-1894-4df5-a625-8cc6ddacc9af"),
    NullableValue = Guid.Parse("02d37130-dc77-4450-b780-4b781335f5a6"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 49,
    Value = Guid.Parse("a79fb813-8896-4d0d-9483-a1b983175045"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 52,
    Value = Guid.Parse("6b0062a3-1037-43a3-b261-4b70bcadcc17"),
    ModelInner = new Guiduuid0MI
{
    Id = 24,
    Value = Guid.Parse("c7150072-d5b9-4b70-95f0-64a99c1cd6e5"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 58,
    Value = Guid.Parse("f2f58837-d461-4827-9347-1bee27fbcb6b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 67,
    Value = Guid.Parse("30f49b3f-4048-4e37-b73a-3a74db106cb0"),
    ModelInner = new Guiduuid0MI
{
    Id = 26,
    Value = Guid.Parse("992ad7a2-048f-4841-a9ce-597486245335"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("9afa86b1-619f-4d23-99ff-6920fadb5a42"),
},
            new Guiduuid0M
{
    Id = 71,
    Value = Guid.Parse("9d866370-dc6b-4b20-8a1f-c580e8775241"),
    ModelInner = null,
    NullableValue = Guid.Parse("92a14941-3899-4654-9763-de92cd1e7bd1"),
},
            new Guiduuid0M
{
    Id = 79,
    Value = Guid.Parse("70a04469-7aac-4241-b874-2556dda98294"),
    ModelInner = new Guiduuid0MI
{
    Id = 33,
    Value = Guid.Parse("8412e20b-e931-4847-b4da-c244f15c9fa0"),
    NullableValue = Guid.Parse("b5d4e8e9-a22e-4f36-928b-ed7251a1337c"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 87,
    Value = Guid.Parse("92bf602f-3e1e-403d-aada-51cac44a5568"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 89,
    Value = Guid.Parse("d0df6191-0899-48d2-8559-fc2ffc12697e"),
    ModelInner = new Guiduuid0MI
{
    Id = 34,
    Value = Guid.Parse("05a45c55-7dfd-4055-9259-996a66bf9f5d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 94,
    Value = Guid.Parse("5af5c5b5-103b-4002-97ad-19604aae132f"),
    ModelInner = null,
    NullableValue = Guid.Parse("ea94ddb7-ce47-4965-80eb-63d513754b24"),
},
            new Guiduuid0M
{
    Id = 100,
    Value = Guid.Parse("b5b2ffab-cf34-4584-ab73-c1bb861570fb"),
    ModelInner = new Guiduuid0MI
{
    Id = 41,
    Value = Guid.Parse("6a825526-4e3f-4faf-b647-8a4be16541c7"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 102,
    Value = Guid.Parse("ac1e201f-a5fb-4b6a-96d0-9286ca45e1fe"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 111,
    Value = Guid.Parse("d0d45f87-ef27-44de-a534-8abbf642b4d9"),
    ModelInner = new Guiduuid0MI
{
    Id = 48,
    Value = Guid.Parse("59bcec03-e0fe-4b51-a75e-1ddbac2222ab"),
    NullableValue = Guid.Parse("7b7c5a2f-36bf-48a4-8428-c2da96057ace"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 117,
    Value = Guid.Parse("f70b21a7-492f-42d7-89f0-8812f07d7d6e"),
    ModelInner = null,
    NullableValue = Guid.Parse("409ff062-8a09-49b7-9cfd-91ce319859cb"),
},
            new Guiduuid0M
{
    Id = 124,
    Value = Guid.Parse("fea958b0-ddcc-4329-8a14-cab54fe7ad41"),
    ModelInner = new Guiduuid0MI
{
    Id = 49,
    Value = Guid.Parse("745a3390-dd52-449c-9819-f06ad2f2230b"),
    NullableValue = Guid.Parse("7822f9e9-4846-4ad6-872b-2b50ab4f8d51"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 126,
    Value = Guid.Parse("c34b7ca7-2c6e-4528-b778-1890e999859a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 128,
    Value = Guid.Parse("46fb4d89-9a92-4f1b-b2f9-f92623d126de"),
    ModelInner = new Guiduuid0MI
{
    Id = 51,
    Value = Guid.Parse("62966b99-3773-4f5c-9041-c703470e1c9f"),
    NullableValue = Guid.Parse("61ec19f6-b9c0-4a83-aee4-3f2f50d1f002"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 133,
    Value = Guid.Parse("f2689c3e-b3b6-4b2d-a2df-0ec395b1f1c6"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 139,
    Value = Guid.Parse("73f51678-bc11-4b8e-b7e6-0b32ad7acf28"),
    ModelInner = new Guiduuid0MI
{
    Id = 58,
    Value = Guid.Parse("a69ca400-03af-42ca-ba28-477b59a403eb"),
    NullableValue = Guid.Parse("ef60b52e-1db9-4a8d-8084-9fdd688114d1"),
},
    NullableValue = Guid.Parse("b4dff1b2-d25a-4398-9d31-0769704d8649"),
},
            new Guiduuid0M
{
    Id = 140,
    Value = Guid.Parse("02310609-2ee0-4c2e-b911-729c192b6e62"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 143,
    Value = Guid.Parse("40772fb7-edc0-4a61-a947-b4910147231b"),
    ModelInner = new Guiduuid0MI
{
    Id = 59,
    Value = Guid.Parse("135c6cf0-ad54-414b-9837-698060578f69"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 144,
    Value = Guid.Parse("c1f02efd-7e2c-4fca-9222-902680d6bf3a"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 153,
    Value = Guid.Parse("f6ece5c6-243f-48a2-aa4f-9d93b5b58065"),
    ModelInner = new Guiduuid0MI
{
    Id = 68,
    Value = Guid.Parse("d3c00bba-dbd6-46d8-89f9-0063e3a2b323"),
    NullableValue = Guid.Parse("31406e4d-a487-4fd8-a1fb-1f1c1d6e1e3e"),
},
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("a9e1f61e-e627-4ff8-a9e2-7c3c0d3ea0b5")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("9afa86b1-619f-4d23-99ff-6920fadb5a42")));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 128;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Guiduuid0M.AssertModel(models[0],_testData[17], false);
                        Guiduuid0M.AssertModel(models[1],_testData[18], false);
                        Guiduuid0M.AssertModel(models[2],_testData[19], false);
                        Guiduuid0M.AssertModel(models[3],_testData[20], false);
                        Guiduuid0M.AssertModel(models[4],_testData[21], false);
                        Guiduuid0M.AssertModel(models[5],_testData[22], false);
                        Guiduuid0M.AssertModel(models[6],_testData[23], false);
                        Guiduuid0M.AssertModel(models[7],_testData[24], false);
                        Guiduuid0M.AssertModel(models[8],_testData[25], false);
                        Guiduuid0M.AssertModel(models[9],_testData[26], false);
                        Guiduuid0M.AssertModel(models[10],_testData[27], false);
                        Guiduuid0M.AssertModel(models[11],_testData[28], false);
                        Guiduuid0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Guiduuid0M.AssertModel(models[0],_testData[13], false);
                        Guiduuid0M.AssertModel(models[1],_testData[14], false);
                        Guiduuid0M.AssertModel(models[2],_testData[15], false);
                        Guiduuid0M.AssertModel(models[3],_testData[16], false);
                        Guiduuid0M.AssertModel(models[4],_testData[17], false);
                        Guiduuid0M.AssertModel(models[5],_testData[18], false);
                        Guiduuid0M.AssertModel(models[6],_testData[19], false);
                        Guiduuid0M.AssertModel(models[7],_testData[20], false);
                        Guiduuid0M.AssertModel(models[8],_testData[21], false);
                        Guiduuid0M.AssertModel(models[9],_testData[22], false);
                        Guiduuid0M.AssertModel(models[10],_testData[23], false);
                        Guiduuid0M.AssertModel(models[11],_testData[24], false);
                        Guiduuid0M.AssertModel(models[12],_testData[25], false);
                        Guiduuid0M.AssertModel(models[13],_testData[26], false);
                        Guiduuid0M.AssertModel(models[14],_testData[27], false);
                        Guiduuid0M.AssertModel(models[15],_testData[28], false);
                        Guiduuid0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Guiduuid0M.AssertModel(models[0],_testData[14], false);
                        Guiduuid0M.AssertModel(models[1],_testData[15], false);
                        Guiduuid0M.AssertModel(models[2],_testData[16], false);
                        Guiduuid0M.AssertModel(models[3],_testData[17], false);
                        Guiduuid0M.AssertModel(models[4],_testData[18], false);
                        Guiduuid0M.AssertModel(models[5],_testData[19], false);
                        Guiduuid0M.AssertModel(models[6],_testData[20], false);
                        Guiduuid0M.AssertModel(models[7],_testData[21], false);
                        Guiduuid0M.AssertModel(models[8],_testData[22], false);
                        Guiduuid0M.AssertModel(models[9],_testData[23], false);
                        Guiduuid0M.AssertModel(models[10],_testData[24], false);
                        Guiduuid0M.AssertModel(models[11],_testData[25], false);
                        Guiduuid0M.AssertModel(models[12],_testData[26], false);
                        Guiduuid0M.AssertModel(models[13],_testData[27], false);
                        Guiduuid0M.AssertModel(models[14],_testData[28], false);
                        Guiduuid0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[29], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 102, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 133, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 117, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 124, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduuid0M.AssertModel(models[0],_testData[22], false);
                        Guiduuid0M.AssertModel(models[1],_testData[23], false);
                        Guiduuid0M.AssertModel(models[2],_testData[24], false);
                        Guiduuid0M.AssertModel(models[3],_testData[25], false);
                        Guiduuid0M.AssertModel(models[4],_testData[26], false);
                        Guiduuid0M.AssertModel(models[5],_testData[27], false);
                        Guiduuid0M.AssertModel(models[6],_testData[28], false);
                        Guiduuid0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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

                Assert.That(models, Has.Count.EqualTo(25));
Guiduuid0M.AssertModel(models[0],_testData[5], false);Guiduuid0M.AssertModel(models[1],_testData[6], false);Guiduuid0M.AssertModel(models[2],_testData[7], false);Guiduuid0M.AssertModel(models[3],_testData[8], false);Guiduuid0M.AssertModel(models[4],_testData[9], false);Guiduuid0M.AssertModel(models[5],_testData[10], false);Guiduuid0M.AssertModel(models[6],_testData[11], false);Guiduuid0M.AssertModel(models[7],_testData[12], false);Guiduuid0M.AssertModel(models[8],_testData[13], false);Guiduuid0M.AssertModel(models[9],_testData[14], false);Guiduuid0M.AssertModel(models[10],_testData[15], false);Guiduuid0M.AssertModel(models[11],_testData[16], false);Guiduuid0M.AssertModel(models[12],_testData[17], false);Guiduuid0M.AssertModel(models[13],_testData[18], false);Guiduuid0M.AssertModel(models[14],_testData[19], false);Guiduuid0M.AssertModel(models[15],_testData[20], false);Guiduuid0M.AssertModel(models[16],_testData[21], false);Guiduuid0M.AssertModel(models[17],_testData[22], false);Guiduuid0M.AssertModel(models[18],_testData[23], false);Guiduuid0M.AssertModel(models[19],_testData[24], false);Guiduuid0M.AssertModel(models[20],_testData[25], false);Guiduuid0M.AssertModel(models[21],_testData[26], false);Guiduuid0M.AssertModel(models[22],_testData[27], false);Guiduuid0M.AssertModel(models[23],_testData[28], false);Guiduuid0M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Guiduuid0M.AssertModel(models[0],_testData[21], false);Guiduuid0M.AssertModel(models[1],_testData[22], false);Guiduuid0M.AssertModel(models[2],_testData[23], false);Guiduuid0M.AssertModel(models[3],_testData[24], false);Guiduuid0M.AssertModel(models[4],_testData[25], false);Guiduuid0M.AssertModel(models[5],_testData[26], false);Guiduuid0M.AssertModel(models[6],_testData[27], false);Guiduuid0M.AssertModel(models[7],_testData[28], false);Guiduuid0M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cecc05cc-3393-444e-ae84-685398a831a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dc9b2cc5-f001-4710-9a8d-82a49265daea"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7a17890-f812-4221-bcf1-839f5a05c8c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6dbdbd3d-0af4-434a-82f4-a0ba3a17194d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef52e1a2-1ecb-4b26-a8dc-ae8026f93541"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7940a1c-193b-48a1-8b2a-18ab35a65a30"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d057baa1-0254-47e5-9e32-57f82f483e28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9e989c8-d2e0-46b8-a9b4-638beefea57c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c229148a-783d-46ca-8090-d9f676e0a0a8"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1320da2a-7843-4d35-a31b-21c6b94a3211"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f123c003-8dcd-42f6-9b26-ef0b617afec5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("266f5e75-eeb5-4657-9d8d-d7721f5a8fb4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61f27116-623b-4215-8c70-bf823397fa8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a9e1f61e-e627-4ff8-a9e2-7c3c0d3ea0b5"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a4de6c-e350-4292-bc89-ab9589e7c505"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35759234-1894-4df5-a625-8cc6ddacc9af"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("02d37130-dc77-4450-b780-4b781335f5a6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a79fb813-8896-4d0d-9483-a1b983175045"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b0062a3-1037-43a3-b261-4b70bcadcc17"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c7150072-d5b9-4b70-95f0-64a99c1cd6e5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2f58837-d461-4827-9347-1bee27fbcb6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("30f49b3f-4048-4e37-b73a-3a74db106cb0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("992ad7a2-048f-4841-a9ce-597486245335"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9afa86b1-619f-4d23-99ff-6920fadb5a42"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d866370-dc6b-4b20-8a1f-c580e8775241"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("92a14941-3899-4654-9763-de92cd1e7bd1"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70a04469-7aac-4241-b874-2556dda98294"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8412e20b-e931-4847-b4da-c244f15c9fa0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b5d4e8e9-a22e-4f36-928b-ed7251a1337c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92bf602f-3e1e-403d-aada-51cac44a5568"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0df6191-0899-48d2-8559-fc2ffc12697e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("05a45c55-7dfd-4055-9259-996a66bf9f5d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5af5c5b5-103b-4002-97ad-19604aae132f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea94ddb7-ce47-4965-80eb-63d513754b24"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5b2ffab-cf34-4584-ab73-c1bb861570fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a825526-4e3f-4faf-b647-8a4be16541c7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac1e201f-a5fb-4b6a-96d0-9286ca45e1fe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0d45f87-ef27-44de-a534-8abbf642b4d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("59bcec03-e0fe-4b51-a75e-1ddbac2222ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7b7c5a2f-36bf-48a4-8428-c2da96057ace"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f70b21a7-492f-42d7-89f0-8812f07d7d6e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("409ff062-8a09-49b7-9cfd-91ce319859cb"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fea958b0-ddcc-4329-8a14-cab54fe7ad41"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("745a3390-dd52-449c-9819-f06ad2f2230b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7822f9e9-4846-4ad6-872b-2b50ab4f8d51"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c34b7ca7-2c6e-4528-b778-1890e999859a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("46fb4d89-9a92-4f1b-b2f9-f92623d126de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("62966b99-3773-4f5c-9041-c703470e1c9f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("61ec19f6-b9c0-4a83-aee4-3f2f50d1f002"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2689c3e-b3b6-4b2d-a2df-0ec395b1f1c6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73f51678-bc11-4b8e-b7e6-0b32ad7acf28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a69ca400-03af-42ca-ba28-477b59a403eb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef60b52e-1db9-4a8d-8084-9fdd688114d1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b4dff1b2-d25a-4398-9d31-0769704d8649"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02310609-2ee0-4c2e-b911-729c192b6e62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40772fb7-edc0-4a61-a947-b4910147231b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("135c6cf0-ad54-414b-9837-698060578f69"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1f02efd-7e2c-4fca-9222-902680d6bf3a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6ece5c6-243f-48a2-aa4f-9d93b5b58065"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3c00bba-dbd6-46d8-89f9-0063e3a2b323"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31406e4d-a487-4fd8-a1fb-1f1c1d6e1e3e"))));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cecc05cc-3393-444e-ae84-685398a831a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dc9b2cc5-f001-4710-9a8d-82a49265daea"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e7a17890-f812-4221-bcf1-839f5a05c8c9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6dbdbd3d-0af4-434a-82f4-a0ba3a17194d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ef52e1a2-1ecb-4b26-a8dc-ae8026f93541"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7940a1c-193b-48a1-8b2a-18ab35a65a30"))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d057baa1-0254-47e5-9e32-57f82f483e28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b9e989c8-d2e0-46b8-a9b4-638beefea57c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c229148a-783d-46ca-8090-d9f676e0a0a8"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("1320da2a-7843-4d35-a31b-21c6b94a3211"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f123c003-8dcd-42f6-9b26-ef0b617afec5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("266f5e75-eeb5-4657-9d8d-d7721f5a8fb4"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("61f27116-623b-4215-8c70-bf823397fa8f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a9e1f61e-e627-4ff8-a9e2-7c3c0d3ea0b5"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c9a4de6c-e350-4292-bc89-ab9589e7c505"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("35759234-1894-4df5-a625-8cc6ddacc9af"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("02d37130-dc77-4450-b780-4b781335f5a6"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a79fb813-8896-4d0d-9483-a1b983175045"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b0062a3-1037-43a3-b261-4b70bcadcc17"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c7150072-d5b9-4b70-95f0-64a99c1cd6e5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2f58837-d461-4827-9347-1bee27fbcb6b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("30f49b3f-4048-4e37-b73a-3a74db106cb0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("992ad7a2-048f-4841-a9ce-597486245335"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9afa86b1-619f-4d23-99ff-6920fadb5a42"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9d866370-dc6b-4b20-8a1f-c580e8775241"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("92a14941-3899-4654-9763-de92cd1e7bd1"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("70a04469-7aac-4241-b874-2556dda98294"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8412e20b-e931-4847-b4da-c244f15c9fa0"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b5d4e8e9-a22e-4f36-928b-ed7251a1337c"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("92bf602f-3e1e-403d-aada-51cac44a5568"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0df6191-0899-48d2-8559-fc2ffc12697e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("05a45c55-7dfd-4055-9259-996a66bf9f5d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5af5c5b5-103b-4002-97ad-19604aae132f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("ea94ddb7-ce47-4965-80eb-63d513754b24"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b5b2ffab-cf34-4584-ab73-c1bb861570fb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a825526-4e3f-4faf-b647-8a4be16541c7"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ac1e201f-a5fb-4b6a-96d0-9286ca45e1fe"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d0d45f87-ef27-44de-a534-8abbf642b4d9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("59bcec03-e0fe-4b51-a75e-1ddbac2222ab"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7b7c5a2f-36bf-48a4-8428-c2da96057ace"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f70b21a7-492f-42d7-89f0-8812f07d7d6e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("409ff062-8a09-49b7-9cfd-91ce319859cb"))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fea958b0-ddcc-4329-8a14-cab54fe7ad41"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("745a3390-dd52-449c-9819-f06ad2f2230b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("7822f9e9-4846-4ad6-872b-2b50ab4f8d51"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c34b7ca7-2c6e-4528-b778-1890e999859a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("46fb4d89-9a92-4f1b-b2f9-f92623d126de"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("62966b99-3773-4f5c-9041-c703470e1c9f"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("61ec19f6-b9c0-4a83-aee4-3f2f50d1f002"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f2689c3e-b3b6-4b2d-a2df-0ec395b1f1c6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("73f51678-bc11-4b8e-b7e6-0b32ad7acf28"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("a69ca400-03af-42ca-ba28-477b59a403eb"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("ef60b52e-1db9-4a8d-8084-9fdd688114d1"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b4dff1b2-d25a-4398-9d31-0769704d8649"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("02310609-2ee0-4c2e-b911-729c192b6e62"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40772fb7-edc0-4a61-a947-b4910147231b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("135c6cf0-ad54-414b-9837-698060578f69"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c1f02efd-7e2c-4fca-9222-902680d6bf3a"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f6ece5c6-243f-48a2-aa4f-9d93b5b58065"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d3c00bba-dbd6-46d8-89f9-0063e3a2b323"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("31406e4d-a487-4fd8-a1fb-1f1c1d6e1e3e"))));//InnerModel.NullableValue

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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Guiduuid0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Guiduuid0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Guiduuid0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Guiduuid0M.AssertModel(models[0],_testData[0], false);
                Guiduuid0M.AssertModel(models[1],_testData[1], false);
                Guiduuid0M.AssertModel(models[2],_testData[2], false);
                Guiduuid0M.AssertModel(models[3],_testData[3], false);
                Guiduuid0M.AssertModel(models[4],_testData[4], false);
                Guiduuid0M.AssertModel(models[5],_testData[5], false);
                Guiduuid0M.AssertModel(models[6],_testData[6], false);
                Guiduuid0M.AssertModel(models[7],_testData[7], false);
                Guiduuid0M.AssertModel(models[8],_testData[8], false);
                Guiduuid0M.AssertModel(models[9],_testData[9], false);
                Guiduuid0M.AssertModel(models[10],_testData[10], false);
                Guiduuid0M.AssertModel(models[11],_testData[11], false);
                Guiduuid0M.AssertModel(models[12],_testData[12], false);
                Guiduuid0M.AssertModel(models[13],_testData[13], false);
                Guiduuid0M.AssertModel(models[14],_testData[14], false);
                Guiduuid0M.AssertModel(models[15],_testData[15], false);
                Guiduuid0M.AssertModel(models[16],_testData[16], false);
                Guiduuid0M.AssertModel(models[17],_testData[17], false);
                Guiduuid0M.AssertModel(models[18],_testData[18], false);
                Guiduuid0M.AssertModel(models[19],_testData[19], false);
                Guiduuid0M.AssertModel(models[20],_testData[20], false);
                Guiduuid0M.AssertModel(models[21],_testData[21], false);
                Guiduuid0M.AssertModel(models[22],_testData[22], false);
                Guiduuid0M.AssertModel(models[23],_testData[23], false);
                Guiduuid0M.AssertModel(models[24],_testData[24], false);
                Guiduuid0M.AssertModel(models[25],_testData[25], false);
                Guiduuid0M.AssertModel(models[26],_testData[26], false);
                Guiduuid0M.AssertModel(models[27],_testData[27], false);
                Guiduuid0M.AssertModel(models[28],_testData[28], false);
                Guiduuid0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

