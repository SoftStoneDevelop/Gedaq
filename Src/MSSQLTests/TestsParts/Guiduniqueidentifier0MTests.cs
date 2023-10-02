

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(14)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(14)
                )
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, 369821506, Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a"), Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModelInner(connection, 1610276054, Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b"), Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b"));
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, 2125285002, Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelInnerAsync(connection, 1966139706, Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93"), null);
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)9
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)9, 
                nullable: true
                )
            ]
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModel(connection, 8535345, Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e"), Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151"));
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 663630636, Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 243723570, Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386"), Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 1752202542, Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9"), Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 1955179811, Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03"), Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 243335234, Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 1540694831, Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 1462682966, Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8"), Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 258435499, Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290"), Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 1944970461, Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810"), Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f"));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertInnerModelAsync(connection, 38788382, Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e"), Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5"));
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(14)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(14),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
                nullable: true
            )
            ]
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, 349447005, Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).InsertModel(connection, 1937441018, Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48"), null, 369821506);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, 431099653, Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf"), Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).InsertModelAsync(connection, 1225466700, Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5"), Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687"), 1610276054);
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
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduniqueidentifier0mi_id", 
                methodParametrName: "guiduniqueidentifier0mi_id", 
                dbType: (System.Data.DbType)11,
                nullable: true
            )
            ]
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

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, 1634174117, Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModel(connection, 1941427437, Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655"), null, 2125285002);
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

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 2121277930, Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1354224654, Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a"), null, 1966139706);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1945258602, Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223"), Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 775621915, Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e"), Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d"), 8535345);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 264541386, Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 155730736, Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95"), null, 663630636);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 452744573, Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960"), Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 2045648440, Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9"), null, 243723570);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 130020038, Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 2026538560, Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40"), null, 1752202542);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 119233665, Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1"), Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1448844811, Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215"), null, 1955179811);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 160979806, Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5"), Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 2075352533, Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395"), Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232"), 243335234);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 757896689, Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e"), Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1944248232, Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20"), null, 1540694831);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1831921161, Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92"), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 656677072, Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee"), null, 1462682966);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 720219086, Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1"), Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 932966907, Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d"), null, 258435499);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 743940768, Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8"), Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1343898946, Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580"), null, 1944970461);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 761034379, Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418"), Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b"), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionInsertModelAsync(connection, 1831637122, Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d"), null, 38788382);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

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
            queryMapType: typeof(Guiduniqueidentifier0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8)
            )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuniqueidentifier)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(119233665));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(130020038));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155730736));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(663630636));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160979806));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264541386));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349447005));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431099653));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452744573));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656677072));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1462682966));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7")));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720219086));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(743940768));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757896689));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(761034379));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775621915));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8535345));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(119233665));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(130020038));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155730736));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(663630636));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160979806));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264541386));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349447005));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431099653));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452744573));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656677072));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1462682966));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7")));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720219086));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(743940768));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757896689));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(761034379));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775621915));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8535345));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

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
            queryMapType: typeof(Guiduniqueidentifier0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(119233665));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(130020038));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155730736));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(663630636));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160979806));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264541386));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349447005));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431099653));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452744573));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656677072));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1462682966));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7")));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720219086));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(743940768));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757896689));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(761034379));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775621915));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8535345));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(119233665));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(130020038));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(155730736));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(663630636));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160979806));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264541386));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349447005));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431099653));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452744573));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656677072));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1462682966));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7")));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720219086));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(743940768));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757896689));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(761034379));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775621915));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8535345));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 775621915);
                var models =  ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidSingleTypeuniqueidentifier)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuniqueidentifier)this).SetDbConnectionSelectModelParametrs(cmd, 155730736);
                var models = await ((IGuidSingleTypeuniqueidentifier)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(27));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(160979806));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(264541386));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349447005));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431099653));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(452744573));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656677072));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1462682966));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7")));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(720219086));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(743940768));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757896689));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(761034379));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(775621915));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8535345));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151")));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932966907));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(258435499));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24")));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225466700));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610276054));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b")));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343898946));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1944970461));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f")));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354224654));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1966139706));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1448844811));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955179811));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5")));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634174117));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831637122));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38788382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5")));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1831921161));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937441018));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(369821506));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb")));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1941427437));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2125285002));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944248232));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1540694831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1945258602));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b")));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2026538560));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1752202542));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48")));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2045648440));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243723570));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386")));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba")));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075352533));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395")));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232")));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(243335234));

                Assert.That(model.ModelInner.Value, Is.EqualTo(Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f")));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2121277930));
                Assert.That(model.Value, Is.EqualTo(Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f")));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

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
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuniqueidentifier)
            )
            ]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119233665)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130020038)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155730736)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((663630636)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160979806)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((264541386)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((349447005)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((431099653)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((452744573)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((656677072)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1462682966)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((720219086)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((743940768)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((757896689)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((761034379)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((775621915)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8535345)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((932966907)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258435499)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1225466700)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1610276054)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1343898946)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1944970461)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1354224654)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1966139706)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1448844811)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1955179811)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634174117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1831637122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38788382)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1831921161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1937441018)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((369821506)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1941427437)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2125285002)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1944248232)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1540694831)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1945258602)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2026538560)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1752202542)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2045648440)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243723570)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2075352533)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243335234)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2121277930)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuniqueidentifier)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119233665)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d7e4584d-4bd7-4c8e-a3c8-dcc55d34f9c1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("de38b29e-70e4-4fd2-88e4-6af78dadcbca"))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130020038)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d4041a74-a391-42a6-856f-0e84d81a6032"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155730736)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee13842-bcff-464a-b058-8367587ece95"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((663630636)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("2630c9eb-d679-47fd-ae3b-892d74413b64"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160979806)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("39fe385b-7766-4dfe-86a4-a8e94da68df5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0a4d2616-30e9-4458-afad-feb2234fc1fa"))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((264541386)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("75e5a547-594e-4810-ac7d-a3d811bc45b3"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((349447005)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a70bdfd-97c4-497e-932b-e0e54052a1e6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((431099653)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c71c4b18-00ea-454d-ac7e-eea374f8b3cf"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("af1c2d85-5543-49d7-9714-61c5d6304ee5"))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((452744573)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8ee6e6bf-b0c8-450c-a9d9-4cd2c8f5f960"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("5eec279e-813c-4ed6-aafc-5cd11cc27943"))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((656677072)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b71a59f-81c2-413f-a883-51756723a1ee"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1462682966)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("da5fde9a-98b9-44c6-a85c-846d3faa9ec8"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e1c7745a-15d2-41cc-8a57-1b6593001bd7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((720219086)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2f0da550-678e-4b7e-a007-f82976e70ca1"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("9f7ca4e4-9757-492e-bf00-064cb843e6bb"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((743940768)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("40a855df-8aec-41aa-a44e-4e08e261b2c8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("091e9625-d2ab-481e-856d-bc771efa05c8"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((757896689)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("24f9923c-bdad-418b-aebb-8528267f8f8e"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("c9f1cb77-8ba7-4149-8bb3-16c3453574e1"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((761034379)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("b253f171-581d-4f41-b9ce-232edf4a9418"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("a69dd974-9a46-4c7a-a2ad-9fac892d9e5b"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((775621915)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("aec46e2b-0ed0-46fa-a7ad-36cf3d859b3e"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8535345)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e73e5e24-bb07-4729-8523-735f7f768b8e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f2ac0966-d4e5-4252-97ce-f44d2795e151"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("74fcd8a2-0d67-4e9e-9364-3c13f12f910d"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((932966907)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d1c0ff4d-36a5-48e4-97fb-c1733067449d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((258435499)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("6a0ce40c-b4d9-4126-9877-78d379fe4290"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("13848288-d628-43d0-b53d-dc1560518d24"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1225466700)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6dddf4f2-b2e0-4c90-a5e0-4058b48346c5"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1610276054)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c9c54f4d-bd18-4285-9df7-cab647b7317b"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("f3eadf88-8c8f-45aa-b65e-edb63831de4b"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b7abeaaf-9f39-464b-83a7-6a4991fe3687"))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1343898946)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("57500038-bdac-46df-a2bf-2c329f93c580"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1944970461)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("85b63317-6d7d-4b75-96bf-9d805a5b6810"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("cb814bae-1e80-4ff9-a77a-cb19b9b05f3f"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1354224654)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("214c6140-385e-446c-8e2d-8079ec6ae06a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1966139706)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("33b6077a-9e6b-4fb5-a83c-53161cedcc93"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1448844811)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("db5748bc-e70a-49e9-89f0-34d8eb937215"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1955179811)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("311556f6-c440-4816-9267-da0baa61eb03"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("46343576-6e30-4c53-babb-0e0be0402ad5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1634174117)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fe6b2551-346a-4f1f-9ef4-f6a46d856145"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1831637122)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("62030785-6e73-4ad2-92c4-fe651df7886d"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38788382)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d65fd970-4538-4c8e-931c-8c3dd73f610e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fab4eea2-5368-48cb-b7a9-359cfdd753c5"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1831921161)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d703c118-981c-4bb2-aae6-4ca4e0adfe92"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1937441018)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6b5f40e7-22bd-4633-a74c-12245dab7e48"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((369821506)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("77687ca4-15bb-4c81-8672-2ce288a67b3a"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("38a093a6-cd87-43eb-b72f-0a97e6f52bfb"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1941427437)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("374679c4-5778-4e5c-96ea-8fd1d8143655"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2125285002)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3306a8fd-f49c-473e-b518-0c54756a5252"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1944248232)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bc254bb4-268b-4438-9c30-279fae2b0e20"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1540694831)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("d504325b-6d8e-40d8-83b2-40c6fb064989"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1945258602)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f263a703-e7c4-4a0e-b894-f0f901dae223"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0ce68e4b-5239-4e47-a2e5-273c2aeae29b"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2026538560)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("6fce408b-f485-461d-b2be-8108dbeece40"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1752202542)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e44cc639-276b-46ab-b075-809e87a891c9"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e2068044-3621-4bae-b66e-f672d307df48"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2045648440)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dbb6c356-3b2e-40ea-b902-6cbb28cbaaa9"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243723570)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b6562c5d-ea94-4123-9eac-64210fabf386"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("74e4f477-8e31-4c64-83c5-33cb5fab41ba"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2075352533)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("9c0ca84b-13d2-4c0b-9bd2-c847c6ece395"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((243335234)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("52c990eb-af90-431e-b908-42182ceb3b3f"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("25f73c4d-04c7-474b-8599-3bd3bdf0c232"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2121277930)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("d75a1e8d-c595-4603-9b30-e5e5df40d43f"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

