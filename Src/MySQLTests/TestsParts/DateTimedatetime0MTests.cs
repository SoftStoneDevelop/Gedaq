

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
    internal partial interface IDateTimeSingleTypedatetime
    {
    }
    
    internal partial class DateTimeSingleTypedatetime : IDateTimeSingleTypedatetime
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(12)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(12)
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModelInner(connection, 1485567195, new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local), new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModelInner(connection, 6404027, new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local));
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelInnerAsync(connection, 602035729, new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelInnerAsync(connection, 200082579, new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(6)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6), 
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModel(connection, 1519348554, new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local));
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1335045197, new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local), new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 116570155, new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local), new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1271420012, new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1793840728, new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local), new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1400745957, new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local), new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1741933625, new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 1269409573, new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 863949291, new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 318673931, new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertInnerModelAsync(connection, 821398490, new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local), new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0m(
	id,
    value,
    nullablevalue,
    datetimedatetime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(12)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(12),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime0mi_id", 
                methodParametrName: "datetimedatetime0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModel(connection, 1359414060, new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).InsertModel(connection, 1317175517, new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local), new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local), 1485567195);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelAsync(connection, 185285962, new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).InsertModelAsync(connection, 101467649, new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local), null, 6404027);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.datetimedatetime0m(
	id,
    value,
    nullablevalue,
    datetimedatetime0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(6)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(6),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime0mi_id", 
                methodParametrName: "datetimedatetime0mi_id", 
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

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModel(connection, 1764161848, new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local), new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModel(connection, 1242530998, new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local), null, 602035729);
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

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 16581578, new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local), new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 682813248, new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local), new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local), 200082579);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1988446584, new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 290638214, new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local), null, 1519348554);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 525307951, new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local), new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1585531342, new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local), null, 1335045197);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1329658962, new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 550743285, new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local), null, 116570155);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 14008390, new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 99041821, new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local), null, 1271420012);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 257281907, new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 977919162, new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local), 1793840728);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 59022358, new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 576054925, new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local), new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local), 1400745957);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1697419463, new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local), new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1136499697, new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local), null, 1741933625);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 87318607, new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local), new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1953680167, new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local), new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local), 1269409573);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1915670039, new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local), new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 840446670, new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local), new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local), 863949291);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1296620615, new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local), new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 1374236862, new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local), new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local), 318673931);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 614847231, new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local), new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime)this).DbConnectionInsertModelAsync(connection, 28177880, new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local), null, 821398490);
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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimedatetime0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
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
                var models =  ((IDateTimeSingleTypedatetime)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14008390));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16581578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(28177880));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821398490));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59022358));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
                var models = await ((IDateTimeSingleTypedatetime)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14008390));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16581578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(28177880));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821398490));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59022358));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimedatetime0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
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
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14008390));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16581578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(28177880));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821398490));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59022358));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14008390));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16581578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(28177880));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821398490));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59022358));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
                 using var cmd =  ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 840446670);
                var models =  ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(14));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
                await using var cmd = await ((IDateTimeSingleTypedatetime)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypedatetime)this).SetDbConnectionSelectModelParametrs(cmd, 101467649);
                var models = await ((IDateTimeSingleTypedatetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
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
                 foreach(var batchResult in ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelBatch(connection, 1136499697, 1329658962))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
                await foreach(var batchResult in ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelBatchAsync(connection, 59022358, 28177880))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(59022358));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87318607));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(99041821));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1271420012));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(101467649));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(6404027));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185285962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(257281907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290638214));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1519348554));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(525307951));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(550743285));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(116570155));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576054925));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1400745957));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(614847231));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(682813248));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(200082579));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(840446670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(863949291));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977919162));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1793840728));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1136499697));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1741933625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1242530998));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(602035729));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1296620615));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317175517));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1485567195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1329658962));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1359414060));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1374236862));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(318673931));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1585531342));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1335045197));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local)));

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1697419463));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764161848));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915670039));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953680167));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1269409573));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1988446584));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local)));

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
FROM gedaqtests.datetimedatetime0m m
LEFT JOIN gedaqtests.datetimedatetime0mi mi ON mi.id = m.datetimedatetime0mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime)
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
                var models =  ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14008390)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16581578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28177880)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821398490)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59022358)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87318607)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99041821)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1271420012)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101467649)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6404027)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185285962)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((257281907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((290638214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1519348554)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((525307951)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((550743285)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((116570155)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((576054925)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1400745957)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((614847231)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((682813248)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((200082579)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((840446670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((863949291)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((977919162)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1793840728)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1136499697)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1741933625)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1242530998)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((602035729)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1296620615)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1317175517)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1485567195)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1329658962)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1359414060)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1374236862)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((318673931)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1585531342)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1335045197)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1697419463)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1764161848)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1915670039)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1953680167)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1269409573)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1988446584)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local))));//Value

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
                var models = await ((IDateTimeSingleTypedatetime)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14008390)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1986, month: 10, day: 12, hour: 21, minute: 31, second: 57, millisecond: 784, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 4, hour: 11, minute: 13, second: 56, millisecond: 868, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16581578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 17, hour: 16, minute: 50, second: 7, millisecond: 426, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 8, hour: 11, minute: 1, second: 26, millisecond: 549, kind: DateTimeKind.Local))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28177880)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1982, month: 10, day: 15, hour: 15, minute: 24, second: 5, millisecond: 664, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821398490)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1966, month: 10, day: 3, hour: 12, minute: 46, second: 18, millisecond: 442, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2006, month: 10, day: 5, hour: 11, minute: 44, second: 49, millisecond: 921, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59022358)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1918, month: 10, day: 1, hour: 3, minute: 7, second: 49, millisecond: 806, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87318607)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1980, month: 10, day: 7, hour: 19, minute: 31, second: 25, millisecond: 307, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1941, month: 10, day: 8, hour: 4, minute: 51, second: 38, millisecond: 849, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99041821)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 6, minute: 6, second: 23, millisecond: 902, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1271420012)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 12, hour: 8, minute: 33, second: 27, millisecond: 401, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101467649)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1942, month: 10, day: 12, hour: 14, minute: 10, second: 50, millisecond: 637, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6404027)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2008, month: 10, day: 3, hour: 8, minute: 49, second: 22, millisecond: 435, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 8, hour: 10, minute: 36, second: 5, millisecond: 722, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185285962)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 5, hour: 9, minute: 33, second: 32, millisecond: 824, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((257281907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 4, hour: 9, minute: 10, second: 12, millisecond: 446, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((290638214)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 10, hour: 13, minute: 1, second: 7, millisecond: 879, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1519348554)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2009, month: 10, day: 17, hour: 6, minute: 44, second: 27, millisecond: 930, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 15, hour: 2, minute: 2, second: 3, millisecond: 187, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((525307951)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 16, hour: 17, minute: 54, second: 46, millisecond: 274, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1945, month: 10, day: 3, hour: 6, minute: 30, second: 16, millisecond: 470, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((550743285)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 15, hour: 15, minute: 35, second: 15, millisecond: 985, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((116570155)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 5, hour: 11, minute: 50, second: 57, millisecond: 888, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 5, hour: 16, minute: 27, second: 58, millisecond: 348, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((576054925)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 12, hour: 4, minute: 51, second: 17, millisecond: 311, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1400745957)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 16, hour: 12, minute: 45, second: 17, millisecond: 416, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 11, hour: 8, minute: 49, second: 23, millisecond: 7, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 16, hour: 21, minute: 6, second: 57, millisecond: 85, kind: DateTimeKind.Local))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((614847231)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 8, hour: 21, minute: 14, second: 18, millisecond: 197, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 1, hour: 11, minute: 4, second: 41, millisecond: 718, kind: DateTimeKind.Local))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((682813248)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 14, hour: 21, minute: 15, second: 52, millisecond: 491, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((200082579)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 16, hour: 4, minute: 35, second: 10, millisecond: 193, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 16, hour: 22, minute: 25, second: 8, millisecond: 747, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 1, hour: 8, minute: 34, second: 6, millisecond: 483, kind: DateTimeKind.Local))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((840446670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 5, hour: 18, minute: 15, second: 12, millisecond: 100, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((863949291)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 10, hour: 14, minute: 52, second: 12, millisecond: 210, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1920, month: 10, day: 17, hour: 14, minute: 56, second: 14, millisecond: 508, kind: DateTimeKind.Local))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((977919162)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1954, month: 10, day: 10, hour: 8, minute: 24, second: 38, millisecond: 36, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1793840728)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 9, hour: 15, minute: 57, second: 47, millisecond: 696, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2003, month: 10, day: 3, hour: 11, minute: 43, second: 41, millisecond: 218, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 10, hour: 12, minute: 22, second: 34, millisecond: 273, kind: DateTimeKind.Local))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1136499697)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 11, hour: 12, minute: 57, second: 14, millisecond: 696, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1741933625)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1946, month: 10, day: 17, hour: 17, minute: 25, second: 36, millisecond: 163, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1242530998)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 12, hour: 5, minute: 23, second: 2, millisecond: 832, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((602035729)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 2, hour: 4, minute: 7, second: 20, millisecond: 291, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1296620615)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 3, hour: 15, minute: 38, second: 10, millisecond: 622, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 5, hour: 4, minute: 50, second: 43, millisecond: 841, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1317175517)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1972, month: 10, day: 6, hour: 8, minute: 22, second: 44, millisecond: 930, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1485567195)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 4, hour: 2, minute: 11, second: 40, millisecond: 961, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 12, hour: 13, minute: 43, second: 58, millisecond: 284, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 11, hour: 20, minute: 48, second: 40, millisecond: 227, kind: DateTimeKind.Local))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1329658962)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 17, hour: 21, minute: 21, second: 36, millisecond: 138, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1988, month: 10, day: 12, hour: 18, minute: 33, second: 37, millisecond: 547, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1359414060)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 18, hour: 22, minute: 28, second: 47, millisecond: 434, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1374236862)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 12, hour: 16, minute: 57, second: 11, millisecond: 636, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((318673931)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2000, month: 10, day: 7, hour: 5, minute: 10, second: 28, millisecond: 561, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1964, month: 10, day: 15, hour: 19, minute: 5, second: 53, millisecond: 733, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1585531342)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2018, month: 10, day: 5, hour: 11, minute: 39, second: 24, millisecond: 947, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1335045197)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1971, month: 10, day: 14, hour: 9, minute: 49, second: 57, millisecond: 910, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1983, month: 10, day: 15, hour: 8, minute: 40, second: 40, millisecond: 92, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1697419463)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1977, month: 10, day: 14, hour: 14, minute: 17, second: 10, millisecond: 483, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 2, hour: 8, minute: 31, second: 24, millisecond: 74, kind: DateTimeKind.Local))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1764161848)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 5, hour: 13, minute: 31, second: 39, millisecond: 167, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 13, hour: 2, minute: 31, second: 7, millisecond: 613, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1915670039)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1959, month: 10, day: 6, hour: 9, minute: 20, second: 38, millisecond: 667, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1958, month: 10, day: 3, hour: 9, minute: 40, second: 37, millisecond: 782, kind: DateTimeKind.Local))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1953680167)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2014, month: 10, day: 14, hour: 18, minute: 57, second: 11, millisecond: 875, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1269409573)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 12, hour: 17, minute: 50, second: 38, millisecond: 817, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 3, hour: 22, minute: 6, second: 31, millisecond: 301, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1988446584)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2007, month: 10, day: 14, hour: 21, minute: 57, second: 25, millisecond: 64, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

