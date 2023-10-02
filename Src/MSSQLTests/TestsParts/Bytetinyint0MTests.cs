

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
    internal partial interface IByteSingleTypetinyint
    {
    }
    
    internal partial class ByteSingleTypetinyint : IByteSingleTypetinyint
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(20)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(20)
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, 1767218413, 195, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, 1930765596, 179, null);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, 1177624840, 62, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, 1932017338, 142, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)2
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2, 
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModel(connection, 1181060279, 165, 169);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 207731547, 168, 153);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 1848491562, 84, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 799192944, 27, 103);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 2061373957, 206, 212);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 1643271427, 13, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 652768394, 100, 213);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 737403114, 80, 7);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 1850558041, 248, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 194417004, 160, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, 1588176753, 236, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0m(
	id,
    value,
    nullablevalue,
    bytetinyint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint0mi_id
)
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(20)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(20),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint0mi_id", 
                methodParametrName: "bytetinyint0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, 167656393, 38, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, 1984579411, 85, 200, 1767218413);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, 1752530088, 201, 123, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, 1895236335, 194, null, 1930765596);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0m(
	id,
    value,
    nullablevalue,
    bytetinyint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)2),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint0mi_id", 
                methodParametrName: "bytetinyint0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, 684955573, 218, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, 2133084598, 146, 84, 1177624840);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 785588420, 40, 183, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1587239988, 94, null, 1932017338);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1963144091, 11, 102, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1905076630, 5, null, 1181060279);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 695397439, 63, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 571469373, 2, 229, 207731547);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1413821271, 181, 121, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 886477645, 231, null, 1848491562);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1999586698, 97, 57, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 27797745, 233, null, 799192944);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 978154268, 85, 134, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1308971899, 185, null, 2061373957);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 335157295, 194, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 824937790, 25, 75, 1643271427);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 330183549, 188, 234, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1223830916, 110, null, 652768394);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1415373103, 247, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 276434983, 91, null, 737403114);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 341324600, 14, 114, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1909498398, 74, null, 1850558041);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 813020979, 160, 93, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 1628745603, 14, 8, 194417004);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 956708727, 171, 95, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, 755138379, 12, null, 1588176753);
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Bytetinyint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
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
                var models =  ((IByteSingleTypetinyint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(27797745));
                Assert.That(model.Value, Is.EqualTo(233));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(799192944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(103));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(167656393));
                Assert.That(model.Value, Is.EqualTo(38));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(276434983));
                Assert.That(model.Value, Is.EqualTo(91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(737403114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330183549));
                Assert.That(model.Value, Is.EqualTo(188));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(234));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(335157295));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341324600));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(114));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571469373));
                Assert.That(model.Value, Is.EqualTo(2));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(207731547));

                Assert.That(model.ModelInner.Value, Is.EqualTo(168));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(153));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(684955573));
                Assert.That(model.Value, Is.EqualTo(218));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(695397439));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755138379));
                Assert.That(model.Value, Is.EqualTo(12));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588176753));

                Assert.That(model.ModelInner.Value, Is.EqualTo(236));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785588420));
                Assert.That(model.Value, Is.EqualTo(40));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(183));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813020979));
                Assert.That(model.Value, Is.EqualTo(160));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(93));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824937790));
                Assert.That(model.Value, Is.EqualTo(25));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(75));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1643271427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(13));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886477645));
                Assert.That(model.Value, Is.EqualTo(231));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1848491562));

                Assert.That(model.ModelInner.Value, Is.EqualTo(84));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956708727));
                Assert.That(model.Value, Is.EqualTo(171));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(95));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978154268));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(134));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1223830916));
                Assert.That(model.Value, Is.EqualTo(110));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(652768394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(213));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308971899));
                Assert.That(model.Value, Is.EqualTo(185));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2061373957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(206));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(212));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413821271));
                Assert.That(model.Value, Is.EqualTo(181));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(121));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1415373103));
                Assert.That(model.Value, Is.EqualTo(247));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587239988));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932017338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1628745603));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194417004));

                Assert.That(model.ModelInner.Value, Is.EqualTo(160));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752530088));
                Assert.That(model.Value, Is.EqualTo(201));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(123));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1895236335));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1930765596));

                Assert.That(model.ModelInner.Value, Is.EqualTo(179));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905076630));
                Assert.That(model.Value, Is.EqualTo(5));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181060279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(165));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(169));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(27797745));
                Assert.That(model.Value, Is.EqualTo(233));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(799192944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(103));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(167656393));
                Assert.That(model.Value, Is.EqualTo(38));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(276434983));
                Assert.That(model.Value, Is.EqualTo(91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(737403114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330183549));
                Assert.That(model.Value, Is.EqualTo(188));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(234));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(335157295));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341324600));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(114));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571469373));
                Assert.That(model.Value, Is.EqualTo(2));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(207731547));

                Assert.That(model.ModelInner.Value, Is.EqualTo(168));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(153));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(684955573));
                Assert.That(model.Value, Is.EqualTo(218));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(695397439));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755138379));
                Assert.That(model.Value, Is.EqualTo(12));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588176753));

                Assert.That(model.ModelInner.Value, Is.EqualTo(236));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785588420));
                Assert.That(model.Value, Is.EqualTo(40));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(183));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813020979));
                Assert.That(model.Value, Is.EqualTo(160));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(93));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824937790));
                Assert.That(model.Value, Is.EqualTo(25));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(75));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1643271427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(13));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886477645));
                Assert.That(model.Value, Is.EqualTo(231));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1848491562));

                Assert.That(model.ModelInner.Value, Is.EqualTo(84));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956708727));
                Assert.That(model.Value, Is.EqualTo(171));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(95));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978154268));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(134));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1223830916));
                Assert.That(model.Value, Is.EqualTo(110));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(652768394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(213));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308971899));
                Assert.That(model.Value, Is.EqualTo(185));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2061373957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(206));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(212));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413821271));
                Assert.That(model.Value, Is.EqualTo(181));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(121));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1415373103));
                Assert.That(model.Value, Is.EqualTo(247));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587239988));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932017338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1628745603));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194417004));

                Assert.That(model.ModelInner.Value, Is.EqualTo(160));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752530088));
                Assert.That(model.Value, Is.EqualTo(201));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(123));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1895236335));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1930765596));

                Assert.That(model.ModelInner.Value, Is.EqualTo(179));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905076630));
                Assert.That(model.Value, Is.EqualTo(5));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181060279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(165));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(169));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Bytetinyint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
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
                var models =  ((IByteSingleTypetinyint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(27797745));
                Assert.That(model.Value, Is.EqualTo(233));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(799192944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(103));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(167656393));
                Assert.That(model.Value, Is.EqualTo(38));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(276434983));
                Assert.That(model.Value, Is.EqualTo(91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(737403114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330183549));
                Assert.That(model.Value, Is.EqualTo(188));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(234));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(335157295));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341324600));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(114));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571469373));
                Assert.That(model.Value, Is.EqualTo(2));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(207731547));

                Assert.That(model.ModelInner.Value, Is.EqualTo(168));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(153));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(684955573));
                Assert.That(model.Value, Is.EqualTo(218));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(695397439));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755138379));
                Assert.That(model.Value, Is.EqualTo(12));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588176753));

                Assert.That(model.ModelInner.Value, Is.EqualTo(236));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785588420));
                Assert.That(model.Value, Is.EqualTo(40));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(183));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813020979));
                Assert.That(model.Value, Is.EqualTo(160));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(93));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824937790));
                Assert.That(model.Value, Is.EqualTo(25));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(75));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1643271427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(13));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886477645));
                Assert.That(model.Value, Is.EqualTo(231));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1848491562));

                Assert.That(model.ModelInner.Value, Is.EqualTo(84));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956708727));
                Assert.That(model.Value, Is.EqualTo(171));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(95));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978154268));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(134));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1223830916));
                Assert.That(model.Value, Is.EqualTo(110));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(652768394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(213));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308971899));
                Assert.That(model.Value, Is.EqualTo(185));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2061373957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(206));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(212));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413821271));
                Assert.That(model.Value, Is.EqualTo(181));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(121));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1415373103));
                Assert.That(model.Value, Is.EqualTo(247));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587239988));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932017338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1628745603));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194417004));

                Assert.That(model.ModelInner.Value, Is.EqualTo(160));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752530088));
                Assert.That(model.Value, Is.EqualTo(201));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(123));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1895236335));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1930765596));

                Assert.That(model.ModelInner.Value, Is.EqualTo(179));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905076630));
                Assert.That(model.Value, Is.EqualTo(5));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181060279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(165));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(169));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(27797745));
                Assert.That(model.Value, Is.EqualTo(233));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(799192944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(27));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(103));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(167656393));
                Assert.That(model.Value, Is.EqualTo(38));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(276434983));
                Assert.That(model.Value, Is.EqualTo(91));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(737403114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(7));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330183549));
                Assert.That(model.Value, Is.EqualTo(188));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(234));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(335157295));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341324600));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(114));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(571469373));
                Assert.That(model.Value, Is.EqualTo(2));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(207731547));

                Assert.That(model.ModelInner.Value, Is.EqualTo(168));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(153));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(684955573));
                Assert.That(model.Value, Is.EqualTo(218));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(695397439));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755138379));
                Assert.That(model.Value, Is.EqualTo(12));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588176753));

                Assert.That(model.ModelInner.Value, Is.EqualTo(236));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785588420));
                Assert.That(model.Value, Is.EqualTo(40));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(183));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813020979));
                Assert.That(model.Value, Is.EqualTo(160));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(93));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824937790));
                Assert.That(model.Value, Is.EqualTo(25));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(75));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1643271427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(13));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886477645));
                Assert.That(model.Value, Is.EqualTo(231));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1848491562));

                Assert.That(model.ModelInner.Value, Is.EqualTo(84));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956708727));
                Assert.That(model.Value, Is.EqualTo(171));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(95));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978154268));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(134));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1223830916));
                Assert.That(model.Value, Is.EqualTo(110));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(652768394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(213));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308971899));
                Assert.That(model.Value, Is.EqualTo(185));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2061373957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(206));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(212));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413821271));
                Assert.That(model.Value, Is.EqualTo(181));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(121));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1415373103));
                Assert.That(model.Value, Is.EqualTo(247));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587239988));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932017338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1628745603));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194417004));

                Assert.That(model.ModelInner.Value, Is.EqualTo(160));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752530088));
                Assert.That(model.Value, Is.EqualTo(201));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(123));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1895236335));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1930765596));

                Assert.That(model.ModelInner.Value, Is.EqualTo(179));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905076630));
                Assert.That(model.Value, Is.EqualTo(5));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181060279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(165));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(169));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 1905076630);
                var models =  ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(5));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 684955573);
                var models = await ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(22));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(695397439));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755138379));
                Assert.That(model.Value, Is.EqualTo(12));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588176753));

                Assert.That(model.ModelInner.Value, Is.EqualTo(236));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785588420));
                Assert.That(model.Value, Is.EqualTo(40));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(183));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813020979));
                Assert.That(model.Value, Is.EqualTo(160));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(93));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824937790));
                Assert.That(model.Value, Is.EqualTo(25));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(75));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1643271427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(13));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(886477645));
                Assert.That(model.Value, Is.EqualTo(231));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1848491562));

                Assert.That(model.ModelInner.Value, Is.EqualTo(84));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(956708727));
                Assert.That(model.Value, Is.EqualTo(171));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(95));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978154268));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(134));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1223830916));
                Assert.That(model.Value, Is.EqualTo(110));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(652768394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(213));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308971899));
                Assert.That(model.Value, Is.EqualTo(185));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2061373957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(206));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(212));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1413821271));
                Assert.That(model.Value, Is.EqualTo(181));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(121));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1415373103));
                Assert.That(model.Value, Is.EqualTo(247));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587239988));
                Assert.That(model.Value, Is.EqualTo(94));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932017338));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1628745603));
                Assert.That(model.Value, Is.EqualTo(14));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194417004));

                Assert.That(model.ModelInner.Value, Is.EqualTo(160));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1752530088));
                Assert.That(model.Value, Is.EqualTo(201));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(123));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1895236335));
                Assert.That(model.Value, Is.EqualTo(194));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1930765596));

                Assert.That(model.ModelInner.Value, Is.EqualTo(179));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1905076630));
                Assert.That(model.Value, Is.EqualTo(5));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181060279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(165));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(169));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1909498398));
                Assert.That(model.Value, Is.EqualTo(74));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1850558041));

                Assert.That(model.ModelInner.Value, Is.EqualTo(248));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1963144091));
                Assert.That(model.Value, Is.EqualTo(11));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984579411));
                Assert.That(model.Value, Is.EqualTo(85));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(200));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1767218413));

                Assert.That(model.ModelInner.Value, Is.EqualTo(195));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1999586698));
                Assert.That(model.Value, Is.EqualTo(97));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(57));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2133084598));
                Assert.That(model.Value, Is.EqualTo(146));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(84));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177624840));

                Assert.That(model.ModelInner.Value, Is.EqualTo(62));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
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
            asPartInterface: typeof(IByteSingleTypetinyint)
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
                var models =  ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27797745)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((799192944)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((27)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((103)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167656393)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((38)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((276434983)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((737403114)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((7)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((330183549)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((188)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((234)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((335157295)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((194)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((341324600)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((114)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((571469373)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((2)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((207731547)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((168)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((153)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((229)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((684955573)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((695397439)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((755138379)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((12)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1588176753)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((236)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((785588420)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((183)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((813020979)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((160)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((93)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((824937790)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((25)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1643271427)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((13)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((75)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((886477645)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((231)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1848491562)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((84)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((956708727)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((95)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((978154268)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((85)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((134)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1223830916)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((652768394)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((100)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((213)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1308971899)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2061373957)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((206)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((212)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1413821271)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((181)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((121)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1415373103)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((247)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1587239988)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1932017338)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((142)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1628745603)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((14)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((194417004)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((160)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((8)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1752530088)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((201)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((123)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1895236335)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((194)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1930765596)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((179)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1905076630)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((5)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1181060279)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((165)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((169)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1909498398)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((74)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1850558041)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((248)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1963144091)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((11)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1984579411)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((85)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767218413)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((195)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((200)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1999586698)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((97)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((57)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2133084598)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((146)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1177624840)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((62)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((84)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27797745)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((799192944)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((27)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((103)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167656393)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((38)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((276434983)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((737403114)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((7)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((330183549)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((188)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((234)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((335157295)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((194)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((341324600)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((114)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((571469373)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((2)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((207731547)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((168)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((153)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((229)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((684955573)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((695397439)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((755138379)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((12)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1588176753)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((236)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((785588420)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((183)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((813020979)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((160)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((93)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((824937790)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((25)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1643271427)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((13)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((75)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((886477645)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((231)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1848491562)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((84)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((956708727)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((95)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((978154268)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((85)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((134)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1223830916)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((652768394)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((100)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((213)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1308971899)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2061373957)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((206)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((212)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1413821271)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((181)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((121)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1415373103)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((247)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1587239988)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1932017338)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((142)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1628745603)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((14)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((194417004)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((160)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((8)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1752530088)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((201)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((123)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1895236335)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((194)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1930765596)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((179)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1905076630)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((5)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1181060279)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((165)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((169)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1909498398)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((74)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1850558041)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((248)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1963144091)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((11)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1984579411)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((85)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1767218413)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((195)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((200)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1999586698)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((97)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((57)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2133084598)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((146)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1177624840)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((62)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((84)));

            }
        }

        #endregion

    }
}

