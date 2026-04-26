

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
    Id = 3,
    Value = Guid.Parse("9bfb24b0-196d-4667-aa09-a574dcaf4f14"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 5,
    Value = Guid.Parse("ff62ebc4-0018-43a3-8bcc-3fbe08235040"),
    ModelInner = new Guiduuid0MI
{
    Id = 4,
    Value = Guid.Parse("586a652e-627b-4680-9e30-c2ae69aff8c9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("6db826a4-efdc-4622-896b-be551ff24f48"),
},
            new Guiduuid0M
{
    Id = 10,
    Value = Guid.Parse("b596cab0-6039-471b-8fd9-e657778a1373"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 16,
    Value = Guid.Parse("2eefa0e1-de95-4107-b5e3-80712ef051f9"),
    ModelInner = new Guiduuid0MI
{
    Id = 6,
    Value = Guid.Parse("4828143f-ff85-449a-aaf5-45d2189cb5d3"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 20,
    Value = Guid.Parse("8fc28b44-22fd-4e2e-afaf-bbbaf4f5b616"),
    ModelInner = null,
    NullableValue = Guid.Parse("8ce9b413-1639-4833-ac77-5081c9cbdda4"),
},
            new Guiduuid0M
{
    Id = 29,
    Value = Guid.Parse("4f39eab9-0b5e-4a6e-a209-db504dddbd50"),
    ModelInner = new Guiduuid0MI
{
    Id = 13,
    Value = Guid.Parse("8ef0b0d9-757f-402a-829c-03c263d3d36b"),
    NullableValue = Guid.Parse("b9a92918-a7e6-4c85-901e-8629f8cb47a0"),
},
    NullableValue = Guid.Parse("c6a8b1e5-43ea-4919-8b05-c6dc3d661708"),
},
            new Guiduuid0M
{
    Id = 31,
    Value = Guid.Parse("ebcb7a41-3854-4b6a-97fa-708a7e57bf16"),
    ModelInner = null,
    NullableValue = Guid.Parse("56dbaade-0d31-4d40-85e1-68d6cab632b7"),
},
            new Guiduuid0M
{
    Id = 33,
    Value = Guid.Parse("a6d48111-f9a9-445d-93b2-546cbb8c8ae0"),
    ModelInner = new Guiduuid0MI
{
    Id = 22,
    Value = Guid.Parse("9c221972-8f9f-4f55-bb1b-43e2a4bc73b6"),
    NullableValue = Guid.Parse("66dcfa6d-5620-4f19-9581-95a4ef8522ad"),
},
    NullableValue = Guid.Parse("c5d21746-d93d-4ed5-8404-f4aecdf3a265"),
},
            new Guiduuid0M
{
    Id = 35,
    Value = Guid.Parse("dd4c54df-dac4-4b9d-bce1-349713f8ed2b"),
    ModelInner = null,
    NullableValue = Guid.Parse("3cf314d1-2499-4ce3-b91a-a297cc7dcadc"),
},
            new Guiduuid0M
{
    Id = 38,
    Value = Guid.Parse("8a6b1741-891f-40eb-b534-478686ac931d"),
    ModelInner = new Guiduuid0MI
{
    Id = 26,
    Value = Guid.Parse("4e40d3ac-d4dc-4eaa-aac8-bb3880bfd6a1"),
    NullableValue = Guid.Parse("09aaa629-481e-49c2-8a92-e42a83ef29dd"),
},
    NullableValue = Guid.Parse("7b6bd801-a18e-4c15-8098-f09d0e78286b"),
},
            new Guiduuid0M
{
    Id = 42,
    Value = Guid.Parse("2d96db96-ffb2-4a82-bd0e-3597c521ae31"),
    ModelInner = null,
    NullableValue = Guid.Parse("9f3cff68-0e4e-46e1-bd95-bc06cca14e3c"),
},
            new Guiduuid0M
{
    Id = 48,
    Value = Guid.Parse("7f107c85-87d1-4e04-abca-3b8d1e1bf8f5"),
    ModelInner = new Guiduuid0MI
{
    Id = 35,
    Value = Guid.Parse("8f43959d-8dfe-49a5-bdcb-a689942ce353"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 56,
    Value = Guid.Parse("b74c3633-a22f-4bb9-94dc-e308dfc32cbd"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 60,
    Value = Guid.Parse("265072fb-6059-4751-b4e6-b9e5c47f68df"),
    ModelInner = new Guiduuid0MI
{
    Id = 37,
    Value = Guid.Parse("2aea7748-f362-4564-baaa-f5f107262e8c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("14a1f42c-d637-4cd6-aceb-2e0a6102ad9b"),
},
            new Guiduuid0M
{
    Id = 69,
    Value = Guid.Parse("2f590656-caa3-4b9c-9b5e-62e06eaa5cb6"),
    ModelInner = null,
    NullableValue = Guid.Parse("e3d6277a-c85c-442d-b879-0529bc40c83e"),
},
            new Guiduuid0M
{
    Id = 70,
    Value = Guid.Parse("d9b2da62-1352-4f8b-bd6b-4103d7b2a93f"),
    ModelInner = new Guiduuid0MI
{
    Id = 40,
    Value = Guid.Parse("23c4afd5-321c-4fcf-a483-7d47a907b774"),
    NullableValue = Guid.Parse("553bf90e-f31b-429e-a3c7-ac760fcd7467"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 77,
    Value = Guid.Parse("39b5613e-ff16-4791-a748-c8d7f1a43850"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 80,
    Value = Guid.Parse("ccbddc2e-3563-4dce-b877-77aa75d83244"),
    ModelInner = new Guiduuid0MI
{
    Id = 41,
    Value = Guid.Parse("97819b0a-60b9-4f3d-95eb-d623e973b7c3"),
    NullableValue = Guid.Parse("2917779c-24f2-488a-a169-2788bbe18e5d"),
},
    NullableValue = Guid.Parse("c96357c7-168b-47c2-8008-b628b74f98d8"),
},
            new Guiduuid0M
{
    Id = 84,
    Value = Guid.Parse("cd21d04a-41c9-481e-837d-849de661964b"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 85,
    Value = Guid.Parse("6b4715d4-a130-4920-bddd-917b2bf9e75f"),
    ModelInner = new Guiduuid0MI
{
    Id = 46,
    Value = Guid.Parse("22d0d789-5dd1-40b7-8047-b270238c069a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 89,
    Value = Guid.Parse("2fa083b8-bbdc-43bd-bf44-d9da8606a314"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 95,
    Value = Guid.Parse("33fb83d2-7e0c-4edf-8fb5-6099288e4704"),
    ModelInner = new Guiduuid0MI
{
    Id = 53,
    Value = Guid.Parse("d58c0fbf-9528-46ac-974e-ae0bbf596a2c"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("83add30f-892d-4d05-9753-76ba93d72766"),
},
            new Guiduuid0M
{
    Id = 98,
    Value = Guid.Parse("3d93a7cf-1395-4858-b5ba-1ab3be29fe99"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 104,
    Value = Guid.Parse("4c7b701d-da64-49ff-b92a-0d65a680f68d"),
    ModelInner = new Guiduuid0MI
{
    Id = 54,
    Value = Guid.Parse("d0ccc4e6-7c3a-41ee-9e6a-be138bb61a67"),
    NullableValue = Guid.Parse("82adb129-4271-422b-8535-81fc6c4ca521"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 106,
    Value = Guid.Parse("3fde7beb-ad43-4315-9118-1b6381907f66"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 111,
    Value = Guid.Parse("2a52e374-5e92-4383-8fb2-582464579cda"),
    ModelInner = new Guiduuid0MI
{
    Id = 58,
    Value = Guid.Parse("5697a876-5b6d-47bc-8dbd-2afc761a4449"),
    NullableValue = Guid.Parse("b462b812-9bd2-431f-afb5-2751d028f287"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 116,
    Value = Guid.Parse("ae90191b-eacc-448e-98c7-32f7365f563c"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 125,
    Value = Guid.Parse("2a870e71-a52d-4d16-a330-ab9012d02a14"),
    ModelInner = new Guiduuid0MI
{
    Id = 62,
    Value = Guid.Parse("b96f2912-9e95-4880-b6da-6b766a226074"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("63f70446-a3f7-4108-af48-870aa64cea94"),
},
            new Guiduuid0M
{
    Id = 131,
    Value = Guid.Parse("4bff94bc-1498-4ccd-afdb-d266b518fcc4"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 138,
    Value = Guid.Parse("dcfbb4c3-1c9b-4a6b-a921-eedd7f75eed4"),
    ModelInner = new Guiduuid0MI
{
    Id = 65,
    Value = Guid.Parse("f33bb624-944c-4c1d-8030-01a67b4d6c2f"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("e456bb56-e62e-49bd-8912-53fbbe8a5a1a"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("8ce9b413-1639-4833-ac77-5081c9cbdda4")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c6a8b1e5-43ea-4919-8b05-c6dc3d661708")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("56dbaade-0d31-4d40-85e1-68d6cab632b7")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("c5d21746-d93d-4ed5-8404-f4aecdf3a265")));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("3cf314d1-2499-4ce3-b91a-a297cc7dcadc")));
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("7b6bd801-a18e-4c15-8098-f09d0e78286b")));
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
                Assert.That(nullable, Is.EqualTo(Guid.Parse("9f3cff68-0e4e-46e1-bd95-bc06cca14e3c")));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[30], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
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
                parametr1.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Guiduuid0M.AssertModel(models[0],_testData[25], false);
                        Guiduuid0M.AssertModel(models[1],_testData[26], false);
                        Guiduuid0M.AssertModel(models[2],_testData[27], false);
                        Guiduuid0M.AssertModel(models[3],_testData[28], false);
                        Guiduuid0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Guiduuid0M.AssertModel(models[0],_testData[23], false);
                        Guiduuid0M.AssertModel(models[1],_testData[24], false);
                        Guiduuid0M.AssertModel(models[2],_testData[25], false);
                        Guiduuid0M.AssertModel(models[3],_testData[26], false);
                        Guiduuid0M.AssertModel(models[4],_testData[27], false);
                        Guiduuid0M.AssertModel(models[5],_testData[28], false);
                        Guiduuid0M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        Guiduuid0M.AssertModel(models[0],_testData[24], false);
                        Guiduuid0M.AssertModel(models[1],_testData[25], false);
                        Guiduuid0M.AssertModel(models[2],_testData[26], false);
                        Guiduuid0M.AssertModel(models[3],_testData[27], false);
                        Guiduuid0M.AssertModel(models[4],_testData[28], false);
                        Guiduuid0M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[30], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[27],_testData[30], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[29], false);
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
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 69, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[29], false);
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
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[24],_testData[30], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 33))
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guiduuid0M.AssertModel(models[0],_testData[8], false);
                        Guiduuid0M.AssertModel(models[1],_testData[9], false);
                        Guiduuid0M.AssertModel(models[2],_testData[10], false);
                        Guiduuid0M.AssertModel(models[3],_testData[11], false);
                        Guiduuid0M.AssertModel(models[4],_testData[12], false);
                        Guiduuid0M.AssertModel(models[5],_testData[13], false);
                        Guiduuid0M.AssertModel(models[6],_testData[14], false);
                        Guiduuid0M.AssertModel(models[7],_testData[15], false);
                        Guiduuid0M.AssertModel(models[8],_testData[16], false);
                        Guiduuid0M.AssertModel(models[9],_testData[17], false);
                        Guiduuid0M.AssertModel(models[10],_testData[18], false);
                        Guiduuid0M.AssertModel(models[11],_testData[19], false);
                        Guiduuid0M.AssertModel(models[12],_testData[20], false);
                        Guiduuid0M.AssertModel(models[13],_testData[21], false);
                        Guiduuid0M.AssertModel(models[14],_testData[22], false);
                        Guiduuid0M.AssertModel(models[15],_testData[23], false);
                        Guiduuid0M.AssertModel(models[16],_testData[24], false);
                        Guiduuid0M.AssertModel(models[17],_testData[25], false);
                        Guiduuid0M.AssertModel(models[18],_testData[26], false);
                        Guiduuid0M.AssertModel(models[19],_testData[27], false);
                        Guiduuid0M.AssertModel(models[20],_testData[28], false);
                        Guiduuid0M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 116, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduuid0M.AssertModel(models[0],_testData[27], false);
                        Guiduuid0M.AssertModel(models[1],_testData[28], false);
                        Guiduuid0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Guiduuid0M.AssertModel(models[0],_testData[17], false);Guiduuid0M.AssertModel(models[1],_testData[18], false);Guiduuid0M.AssertModel(models[2],_testData[19], false);Guiduuid0M.AssertModel(models[3],_testData[20], false);Guiduuid0M.AssertModel(models[4],_testData[21], false);Guiduuid0M.AssertModel(models[5],_testData[22], false);Guiduuid0M.AssertModel(models[6],_testData[23], false);Guiduuid0M.AssertModel(models[7],_testData[24], false);Guiduuid0M.AssertModel(models[8],_testData[25], false);Guiduuid0M.AssertModel(models[9],_testData[26], false);Guiduuid0M.AssertModel(models[10],_testData[27], false);Guiduuid0M.AssertModel(models[11],_testData[28], false);Guiduuid0M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Guiduuid0M.AssertModel(models[0],_testData[28], false);Guiduuid0M.AssertModel(models[1],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bfb24b0-196d-4667-aa09-a574dcaf4f14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff62ebc4-0018-43a3-8bcc-3fbe08235040"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("586a652e-627b-4680-9e30-c2ae69aff8c9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6db826a4-efdc-4622-896b-be551ff24f48"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b596cab0-6039-471b-8fd9-e657778a1373"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2eefa0e1-de95-4107-b5e3-80712ef051f9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4828143f-ff85-449a-aaf5-45d2189cb5d3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fc28b44-22fd-4e2e-afaf-bbbaf4f5b616"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8ce9b413-1639-4833-ac77-5081c9cbdda4"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f39eab9-0b5e-4a6e-a209-db504dddbd50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8ef0b0d9-757f-402a-829c-03c263d3d36b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b9a92918-a7e6-4c85-901e-8629f8cb47a0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c6a8b1e5-43ea-4919-8b05-c6dc3d661708"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebcb7a41-3854-4b6a-97fa-708a7e57bf16"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("56dbaade-0d31-4d40-85e1-68d6cab632b7"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6d48111-f9a9-445d-93b2-546cbb8c8ae0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9c221972-8f9f-4f55-bb1b-43e2a4bc73b6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("66dcfa6d-5620-4f19-9581-95a4ef8522ad"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c5d21746-d93d-4ed5-8404-f4aecdf3a265"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dd4c54df-dac4-4b9d-bce1-349713f8ed2b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3cf314d1-2499-4ce3-b91a-a297cc7dcadc"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a6b1741-891f-40eb-b534-478686ac931d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4e40d3ac-d4dc-4eaa-aac8-bb3880bfd6a1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("09aaa629-481e-49c2-8a92-e42a83ef29dd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7b6bd801-a18e-4c15-8098-f09d0e78286b"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d96db96-ffb2-4a82-bd0e-3597c521ae31"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f3cff68-0e4e-46e1-bd95-bc06cca14e3c"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f107c85-87d1-4e04-abca-3b8d1e1bf8f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8f43959d-8dfe-49a5-bdcb-a689942ce353"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b74c3633-a22f-4bb9-94dc-e308dfc32cbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("265072fb-6059-4751-b4e6-b9e5c47f68df"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2aea7748-f362-4564-baaa-f5f107262e8c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("14a1f42c-d637-4cd6-aceb-2e0a6102ad9b"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f590656-caa3-4b9c-9b5e-62e06eaa5cb6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e3d6277a-c85c-442d-b879-0529bc40c83e"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d9b2da62-1352-4f8b-bd6b-4103d7b2a93f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23c4afd5-321c-4fcf-a483-7d47a907b774"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("553bf90e-f31b-429e-a3c7-ac760fcd7467"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39b5613e-ff16-4791-a748-c8d7f1a43850"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccbddc2e-3563-4dce-b877-77aa75d83244"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("97819b0a-60b9-4f3d-95eb-d623e973b7c3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2917779c-24f2-488a-a169-2788bbe18e5d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c96357c7-168b-47c2-8008-b628b74f98d8"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd21d04a-41c9-481e-837d-849de661964b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b4715d4-a130-4920-bddd-917b2bf9e75f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22d0d789-5dd1-40b7-8047-b270238c069a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2fa083b8-bbdc-43bd-bf44-d9da8606a314"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("33fb83d2-7e0c-4edf-8fb5-6099288e4704"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d58c0fbf-9528-46ac-974e-ae0bbf596a2c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("83add30f-892d-4d05-9753-76ba93d72766"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3d93a7cf-1395-4858-b5ba-1ab3be29fe99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c7b701d-da64-49ff-b92a-0d65a680f68d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0ccc4e6-7c3a-41ee-9e6a-be138bb61a67"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("82adb129-4271-422b-8535-81fc6c4ca521"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3fde7beb-ad43-4315-9118-1b6381907f66"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a52e374-5e92-4383-8fb2-582464579cda"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5697a876-5b6d-47bc-8dbd-2afc761a4449"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b462b812-9bd2-431f-afb5-2751d028f287"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae90191b-eacc-448e-98c7-32f7365f563c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a870e71-a52d-4d16-a330-ab9012d02a14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b96f2912-9e95-4880-b6da-6b766a226074"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("63f70446-a3f7-4108-af48-870aa64cea94"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bff94bc-1498-4ccd-afdb-d266b518fcc4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dcfbb4c3-1c9b-4a6b-a921-eedd7f75eed4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f33bb624-944c-4c1d-8030-01a67b4d6c2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e456bb56-e62e-49bd-8912-53fbbe8a5a1a"))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9bfb24b0-196d-4667-aa09-a574dcaf4f14"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ff62ebc4-0018-43a3-8bcc-3fbe08235040"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("586a652e-627b-4680-9e30-c2ae69aff8c9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("6db826a4-efdc-4622-896b-be551ff24f48"))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b596cab0-6039-471b-8fd9-e657778a1373"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2eefa0e1-de95-4107-b5e3-80712ef051f9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4828143f-ff85-449a-aaf5-45d2189cb5d3"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8fc28b44-22fd-4e2e-afaf-bbbaf4f5b616"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8ce9b413-1639-4833-ac77-5081c9cbdda4"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4f39eab9-0b5e-4a6e-a209-db504dddbd50"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8ef0b0d9-757f-402a-829c-03c263d3d36b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b9a92918-a7e6-4c85-901e-8629f8cb47a0"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c6a8b1e5-43ea-4919-8b05-c6dc3d661708"))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ebcb7a41-3854-4b6a-97fa-708a7e57bf16"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("56dbaade-0d31-4d40-85e1-68d6cab632b7"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a6d48111-f9a9-445d-93b2-546cbb8c8ae0"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("9c221972-8f9f-4f55-bb1b-43e2a4bc73b6"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("66dcfa6d-5620-4f19-9581-95a4ef8522ad"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c5d21746-d93d-4ed5-8404-f4aecdf3a265"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dd4c54df-dac4-4b9d-bce1-349713f8ed2b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3cf314d1-2499-4ce3-b91a-a297cc7dcadc"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8a6b1741-891f-40eb-b534-478686ac931d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("4e40d3ac-d4dc-4eaa-aac8-bb3880bfd6a1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("09aaa629-481e-49c2-8a92-e42a83ef29dd"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("7b6bd801-a18e-4c15-8098-f09d0e78286b"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2d96db96-ffb2-4a82-bd0e-3597c521ae31"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f3cff68-0e4e-46e1-bd95-bc06cca14e3c"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7f107c85-87d1-4e04-abca-3b8d1e1bf8f5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8f43959d-8dfe-49a5-bdcb-a689942ce353"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b74c3633-a22f-4bb9-94dc-e308dfc32cbd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("265072fb-6059-4751-b4e6-b9e5c47f68df"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2aea7748-f362-4564-baaa-f5f107262e8c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("14a1f42c-d637-4cd6-aceb-2e0a6102ad9b"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f590656-caa3-4b9c-9b5e-62e06eaa5cb6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e3d6277a-c85c-442d-b879-0529bc40c83e"))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d9b2da62-1352-4f8b-bd6b-4103d7b2a93f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("23c4afd5-321c-4fcf-a483-7d47a907b774"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("553bf90e-f31b-429e-a3c7-ac760fcd7467"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39b5613e-ff16-4791-a748-c8d7f1a43850"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ccbddc2e-3563-4dce-b877-77aa75d83244"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("97819b0a-60b9-4f3d-95eb-d623e973b7c3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("2917779c-24f2-488a-a169-2788bbe18e5d"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c96357c7-168b-47c2-8008-b628b74f98d8"))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cd21d04a-41c9-481e-837d-849de661964b"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b4715d4-a130-4920-bddd-917b2bf9e75f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("22d0d789-5dd1-40b7-8047-b270238c069a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2fa083b8-bbdc-43bd-bf44-d9da8606a314"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("33fb83d2-7e0c-4edf-8fb5-6099288e4704"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d58c0fbf-9528-46ac-974e-ae0bbf596a2c"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("83add30f-892d-4d05-9753-76ba93d72766"))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3d93a7cf-1395-4858-b5ba-1ab3be29fe99"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4c7b701d-da64-49ff-b92a-0d65a680f68d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d0ccc4e6-7c3a-41ee-9e6a-be138bb61a67"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("82adb129-4271-422b-8535-81fc6c4ca521"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("3fde7beb-ad43-4315-9118-1b6381907f66"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a52e374-5e92-4383-8fb2-582464579cda"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("5697a876-5b6d-47bc-8dbd-2afc761a4449"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("b462b812-9bd2-431f-afb5-2751d028f287"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("ae90191b-eacc-448e-98c7-32f7365f563c"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a870e71-a52d-4d16-a330-ab9012d02a14"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b96f2912-9e95-4880-b6da-6b766a226074"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("63f70446-a3f7-4108-af48-870aa64cea94"))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("4bff94bc-1498-4ccd-afdb-d266b518fcc4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dcfbb4c3-1c9b-4a6b-a921-eedd7f75eed4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("f33bb624-944c-4c1d-8030-01a67b4d6c2f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("e456bb56-e62e-49bd-8912-53fbbe8a5a1a"))));

            }
        }

#endregion

#region BinaryImportModelInner

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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
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

