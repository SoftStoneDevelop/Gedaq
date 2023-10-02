

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface ITimeSpanSingleTypetime
    {
    }
    
    internal partial class TimeSpanSingleTypetime : ITimeSpanSingleTypetime
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0mi(
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
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(11)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(11)
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, 1321007435, new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, 230885780, new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667), null);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, 583213376, new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528), new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, 478453699, new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13), new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(17)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17), 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModel(connection, 1234010192, new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761), new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615));
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1281648282, new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606), new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1911220167, new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326), new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 483733228, new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763), new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1164071379, new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33), new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 721889760, new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1712359872, new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1114995800, new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 11390740, new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967), new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1052021282, new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915), new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1504404624, new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24), new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0m(
	id,
    value,
    nullablevalue,
    timespantime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantime0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(11)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(11),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, 1318827296, new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465), new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, 869039596, new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889), new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397), 1321007435);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, 1781967843, new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585), new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, 78329764, new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114), new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440), 230885780);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.timespantime0m(
	id,
    value,
    nullablevalue,
    timespantime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timespantime0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
                dbType: (System.Data.DbType)(11),
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, 386252802, new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684), new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, 1236616326, new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515), null, 583213376);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 2101658414, new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1063968407, new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637), null, 478453699);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 797953016, new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 35807999, new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330), new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300), 1234010192);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1226006831, new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 67084724, new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195), new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834), 1281648282);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 482131935, new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344), new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1456625653, new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185), new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426), 1911220167);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 208178538, new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687), new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 581081171, new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623), new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200), 483733228);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 721616584, new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1312957160, new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674), new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215), 1164071379);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1346269256, new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 868490826, new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908), new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966), 721889760);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 37694858, new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214), new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1885612865, new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122), new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44), 1712359872);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 30219183, new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844), new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 836282608, new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324), null, 1114995800);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1589607076, new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 560002967, new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108), new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458), 11390740);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1529188441, new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1938291963, new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893), null, 1052021282);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1162998393, new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97), new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1274779362, new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380), null, 1504404624);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpantime0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3)
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
                var models =  ((ITimeSpanSingleTypetime)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30219183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(35807999));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1234010192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37694858));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67084724));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1281648282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

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
                var models = await ((ITimeSpanSingleTypetime)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30219183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(35807999));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1234010192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37694858));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67084724));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1281648282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpantime0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30219183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(35807999));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1234010192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37694858));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67084724));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1281648282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

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
                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30219183));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(35807999));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1234010192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37694858));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67084724));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1281648282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

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
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 67084724);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

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
                await using var cmd = await ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 30219183);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(35807999));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1234010192));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(37694858));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(67084724));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1281648282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78329764));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(230885780));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(208178538));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatch(connection, 1063968407, 208178538))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(386252802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(482131935));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(560002967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(11390740));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(581081171));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(483733228));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(721616584));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797953016));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(836282608));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1114995800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(868490826));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(721889760));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(869039596));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1321007435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1063968407));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(478453699));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162998393));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1226006831));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                await foreach(var batchResult in ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelBatchAsync(connection, 1346269256, 1226006831))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1236616326));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(583213376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274779362));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1504404624));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1312957160));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1164071379));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1318827296));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346269256));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1456625653));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1911220167));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1529188441));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589607076));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781967843));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1885612865));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1712359872));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1938291963));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052021282));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735)));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2101658414));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
                }
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
FROM gedaqtests.timespantime0m m
LEFT JOIN gedaqtests.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)
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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30219183)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35807999)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1234010192)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37694858)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67084724)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1281648282)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78329764)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((230885780)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((208178538)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((386252802)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((482131935)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((560002967)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11390740)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581081171)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((483733228)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((721616584)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797953016)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((836282608)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114995800)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868490826)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((721889760)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((869039596)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1321007435)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1063968407)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((478453699)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1162998393)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1226006831)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1236616326)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((583213376)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1274779362)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1504404624)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312957160)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1164071379)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1318827296)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1346269256)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1456625653)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1911220167)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1529188441)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1589607076)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781967843)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1885612865)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1712359872)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1938291963)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1052021282)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2101658414)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702))));//Value

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
                var models = await ((ITimeSpanSingleTypetime)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30219183)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 33, milliseconds: 844))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 943))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35807999)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 0, milliseconds: 330))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1234010192)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 25, milliseconds: 761))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 21, milliseconds: 615))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 300))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37694858)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 3, milliseconds: 214))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 21, milliseconds: 626))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67084724)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 195))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1281648282)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 7, milliseconds: 606))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 47, milliseconds: 465))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 19, milliseconds: 834))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78329764)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 14, milliseconds: 114))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((230885780)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 57, milliseconds: 667))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 54, milliseconds: 440))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((208178538)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 0, milliseconds: 687))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 566))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((386252802)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 39, milliseconds: 684))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 1, milliseconds: 263))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((482131935)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 12, milliseconds: 344))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 11, milliseconds: 397))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((560002967)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 36, milliseconds: 108))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11390740)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 16, milliseconds: 967))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 921))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 54, milliseconds: 458))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((581081171)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 39, milliseconds: 623))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((483733228)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 23, milliseconds: 763))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 35, milliseconds: 519))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 57, milliseconds: 200))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((721616584)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 28, milliseconds: 47))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797953016)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 35, milliseconds: 392))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((836282608)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 36, milliseconds: 324))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1114995800)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 1, milliseconds: 513))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((868490826)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 52, milliseconds: 908))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((721889760)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 49, milliseconds: 375))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 50, milliseconds: 966))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((869039596)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 1, milliseconds: 889))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1321007435)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 49, milliseconds: 514))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 397))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1063968407)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 6, milliseconds: 637))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((478453699)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 56, milliseconds: 13))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 37, milliseconds: 283))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1162998393)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 21, milliseconds: 97))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 7, milliseconds: 566))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1226006831)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 54, milliseconds: 121))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1236616326)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 11, milliseconds: 515))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((583213376)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 23, milliseconds: 528))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 25, milliseconds: 936))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1274779362)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 41, milliseconds: 380))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1504404624)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 21, milliseconds: 24))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 5, milliseconds: 656))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1312957160)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 18, milliseconds: 674))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1164071379)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 6, milliseconds: 33))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 291))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 45, milliseconds: 215))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1318827296)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 6, milliseconds: 465))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 25, milliseconds: 627))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1346269256)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 8, milliseconds: 903))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1456625653)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 51, milliseconds: 185))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1911220167)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 326))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 51, milliseconds: 936))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 25, milliseconds: 426))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1529188441)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 380))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 496))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1589607076)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 51, milliseconds: 759))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781967843)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 12, milliseconds: 585))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 24, milliseconds: 41))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1885612865)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 122))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1712359872)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 44, milliseconds: 792))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 44))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1938291963)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 12, milliseconds: 893))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1052021282)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 12, milliseconds: 915))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 42, milliseconds: 735))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2101658414)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 57, milliseconds: 702))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

