

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
    internal partial interface IDateTimeSingleTypedatetime2
    {
    }
    
    internal partial class DateTimeSingleTypedatetime2 : IDateTimeSingleTypedatetime2
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(33)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(33)
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModelInner(connection, 2001495436, new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModelInner(connection, 815896908, new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local), null);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelInnerAsync(connection, 1829705451, new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local), new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelInnerAsync(connection, 1521087200, new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local), new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20mi(
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)26
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)26, 
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModel(connection, 1317553472, new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local), new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local));
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 1183879159, new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local), new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 895152871, new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 874976152, new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local), new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 1043084698, new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 2075317242, new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 1558395758, new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 1041522464, new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local), new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 741956553, new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local), new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 1091968110, new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertInnerModelAsync(connection, 8048437, new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20m(
	id,
    value,
    nullablevalue,
    datetimedatetime20mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime20mi_id
)
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(33)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(33),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime20mi_id", 
                methodParametrName: "datetimedatetime20mi_id", 
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModel(connection, 480497236, new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local), new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).InsertModel(connection, 48448993, new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local), new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local), 2001495436);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelAsync(connection, 1678025918, new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).InsertModelAsync(connection, 1166338349, new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local), 815896908);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.datetimedatetime20m(
	id,
    value,
    nullablevalue,
    datetimedatetime20mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @datetimedatetime20mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateTime), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)26),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateTime?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)26,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "datetimedatetime20mi_id", 
                methodParametrName: "datetimedatetime20mi_id", 
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

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModel(connection, 1875368671, new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModel(connection, 2000252295, new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local), null, 1829705451);
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

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1414367964, new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local), new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 174465575, new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local), null, 1521087200);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 312557537, new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 3199083, new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local), new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local), 1317553472);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 980282243, new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 523351830, new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local), null, 1183879159);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 127493440, new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local), new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 39740850, new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local), new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local), 895152871);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1494305811, new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local), new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 692781314, new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local), null, 874976152);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1513525571, new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 53116670, new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local), new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local), 1043084698);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1961750578, new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local), new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 747505665, new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local), null, 2075317242);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 978119314, new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 261909573, new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local), null, 1558395758);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1092266810, new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local), new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 933834095, new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local), null, 1041522464);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1813954939, new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local), new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1418392989, new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local), new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local), 741956553);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1167849907, new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local), new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 38076985, new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local), null, 1091968110);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 389221264, new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local), new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateTimeSingleTypedatetime2)this).DbConnectionInsertModelAsync(connection, 1246535587, new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local), null, 8048437);
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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateTimedatetime20M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
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
                var models =  ((IDateTimeSingleTypedatetime2)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3199083));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1317553472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38076985));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1091968110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3199083));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1317553472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38076985));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1091968110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateTimedatetime20M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
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
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3199083));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1317553472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38076985));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1091968110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(3199083));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1317553472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38076985));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1091968110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 38076985);
                var models =  ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(28));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateTimeSingleTypedatetime2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateTimeSingleTypedatetime2)this).SetDbConnectionSelectModelParametrs(cmd, 38076985);
                var models = await ((IDateTimeSingleTypedatetime2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(28));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(39740850));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(895152871));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(48448993));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001495436));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(53116670));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1043084698));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(127493440));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(174465575));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1521087200));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(261909573));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1558395758));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(312557537));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(389221264));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(480497236));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523351830));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1183879159));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(692781314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(874976152));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747505665));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2075317242));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(933834095));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1041522464));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(978119314));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(980282243));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092266810));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1166338349));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(815896908));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1167849907));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246535587));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(8048437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1414367964));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1418392989));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(741956553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1494305811));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1513525571));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1678025918));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813954939));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1875368671));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961750578));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2000252295));
                Assert.That(model.Value, Is.EqualTo(new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1829705451));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local)));

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
FROM dbo.datetimedatetime20m m
LEFT JOIN dbo.datetimedatetime20mi mi ON mi.id = m.datetimedatetime20mi_id
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
            asPartInterface: typeof(IDateTimeSingleTypedatetime2)
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
                var models =  ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3199083)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1317553472)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38076985)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1091968110)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39740850)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((895152871)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48448993)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2001495436)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53116670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1043084698)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127493440)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174465575)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1521087200)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((261909573)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1558395758)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((312557537)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((389221264)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((480497236)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((523351830)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1183879159)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((692781314)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((874976152)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((747505665)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2075317242)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((933834095)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1041522464)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((978119314)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((980282243)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1092266810)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1166338349)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((815896908)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1167849907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1246535587)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8048437)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1414367964)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1418392989)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((741956553)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1494305811)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1513525571)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1678025918)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1813954939)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1875368671)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1961750578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000252295)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1829705451)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateTimeSingleTypedatetime2)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3199083)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 6, hour: 3, minute: 11, second: 46, millisecond: 841, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1317553472)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2019, month: 10, day: 7, hour: 11, minute: 47, second: 57, millisecond: 761, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 17, hour: 13, minute: 37, second: 34, millisecond: 524, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 10, hour: 16, minute: 54, second: 39, millisecond: 212, kind: DateTimeKind.Local))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38076985)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1987, month: 10, day: 16, hour: 9, minute: 40, second: 3, millisecond: 761, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1091968110)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 13, hour: 11, minute: 46, second: 1, millisecond: 371, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 9, hour: 14, minute: 35, second: 23, millisecond: 641, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39740850)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1960, month: 10, day: 19, hour: 18, minute: 30, second: 49, millisecond: 98, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((895152871)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1924, month: 10, day: 10, hour: 3, minute: 43, second: 10, millisecond: 571, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1950, month: 10, day: 18, hour: 22, minute: 46, second: 46, millisecond: 891, kind: DateTimeKind.Local))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48448993)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1975, month: 10, day: 16, hour: 7, minute: 37, second: 37, millisecond: 553, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2001495436)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 5, hour: 11, minute: 3, second: 20, millisecond: 69, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1935, month: 10, day: 4, hour: 12, minute: 56, second: 42, millisecond: 741, kind: DateTimeKind.Local))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53116670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1995, month: 10, day: 18, hour: 3, minute: 7, second: 4, millisecond: 468, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1043084698)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1930, month: 10, day: 9, hour: 10, minute: 30, second: 55, millisecond: 128, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1985, month: 10, day: 6, hour: 13, minute: 33, second: 10, millisecond: 481, kind: DateTimeKind.Local))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127493440)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1929, month: 10, day: 9, hour: 5, minute: 2, second: 20, millisecond: 404, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1974, month: 10, day: 8, hour: 13, minute: 2, second: 30, millisecond: 515, kind: DateTimeKind.Local))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174465575)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 3, hour: 5, minute: 1, second: 16, millisecond: 260, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1521087200)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1981, month: 10, day: 10, hour: 20, minute: 49, second: 24, millisecond: 857, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1979, month: 10, day: 2, hour: 5, minute: 36, second: 33, millisecond: 606, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((261909573)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 16, hour: 9, minute: 31, second: 27, millisecond: 755, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1558395758)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1976, month: 10, day: 11, hour: 20, minute: 32, second: 43, millisecond: 776, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 4, hour: 21, minute: 58, second: 47, millisecond: 761, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((312557537)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1944, month: 10, day: 18, hour: 10, minute: 21, second: 43, millisecond: 187, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((389221264)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1953, month: 10, day: 9, hour: 6, minute: 52, second: 4, millisecond: 762, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1932, month: 10, day: 11, hour: 12, minute: 51, second: 58, millisecond: 995, kind: DateTimeKind.Local))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((480497236)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1969, month: 10, day: 17, hour: 15, minute: 57, second: 45, millisecond: 715, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1998, month: 10, day: 11, hour: 5, minute: 17, second: 27, millisecond: 426, kind: DateTimeKind.Local))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((523351830)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1991, month: 10, day: 5, hour: 3, minute: 54, second: 10, millisecond: 309, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1183879159)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1996, month: 10, day: 12, hour: 21, minute: 50, second: 9, millisecond: 349, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 2011, month: 10, day: 5, hour: 15, minute: 46, second: 49, millisecond: 758, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((692781314)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 6, hour: 13, minute: 51, second: 10, millisecond: 326, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((874976152)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2010, month: 10, day: 15, hour: 22, minute: 4, second: 38, millisecond: 92, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1919, month: 10, day: 5, hour: 19, minute: 37, second: 38, millisecond: 821, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((747505665)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2002, month: 10, day: 5, hour: 9, minute: 28, second: 44, millisecond: 213, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2075317242)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1922, month: 10, day: 2, hour: 8, minute: 27, second: 53, millisecond: 876, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((933834095)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1926, month: 10, day: 9, hour: 8, minute: 6, second: 27, millisecond: 740, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1041522464)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1937, month: 10, day: 9, hour: 19, minute: 53, second: 11, millisecond: 940, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1962, month: 10, day: 18, hour: 8, minute: 55, second: 23, millisecond: 308, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((978119314)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 17, hour: 4, minute: 32, second: 30, millisecond: 688, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((980282243)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1961, month: 10, day: 13, hour: 6, minute: 57, second: 41, millisecond: 772, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1092266810)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1931, month: 10, day: 14, hour: 18, minute: 42, second: 58, millisecond: 746, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1940, month: 10, day: 11, hour: 4, minute: 49, second: 31, millisecond: 150, kind: DateTimeKind.Local))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1166338349)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1923, month: 10, day: 6, hour: 4, minute: 6, second: 34, millisecond: 840, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((815896908)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1927, month: 10, day: 18, hour: 22, minute: 44, second: 2, millisecond: 843, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 1, hour: 2, minute: 12, second: 11, millisecond: 445, kind: DateTimeKind.Local))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1167849907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 7, hour: 6, minute: 48, second: 9, millisecond: 269, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1990, month: 10, day: 15, hour: 12, minute: 8, second: 25, millisecond: 518, kind: DateTimeKind.Local))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1246535587)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1989, month: 10, day: 5, hour: 21, minute: 37, second: 18, millisecond: 538, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8048437)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 1956, month: 10, day: 12, hour: 3, minute: 18, second: 23, millisecond: 77, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1414367964)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1993, month: 10, day: 10, hour: 20, minute: 1, second: 13, millisecond: 779, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1957, month: 10, day: 13, hour: 19, minute: 24, second: 39, millisecond: 110, kind: DateTimeKind.Local))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1418392989)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 15, hour: 19, minute: 44, second: 1, millisecond: 322, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((741956553)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2005, month: 10, day: 2, hour: 3, minute: 50, second: 35, millisecond: 490, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1934, month: 10, day: 3, hour: 11, minute: 32, second: 46, millisecond: 983, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 3, hour: 5, minute: 58, second: 9, millisecond: 540, kind: DateTimeKind.Local))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1494305811)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1999, month: 10, day: 15, hour: 2, minute: 2, second: 55, millisecond: 860, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2015, month: 10, day: 8, hour: 14, minute: 51, second: 13, millisecond: 143, kind: DateTimeKind.Local))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1513525571)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 16, hour: 1, minute: 1, second: 48, millisecond: 284, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1678025918)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 2016, month: 10, day: 6, hour: 7, minute: 37, second: 16, millisecond: 770, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1813954939)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1967, month: 10, day: 4, hour: 10, minute: 30, second: 39, millisecond: 816, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 1965, month: 10, day: 4, hour: 14, minute: 29, second: 10, millisecond: 221, kind: DateTimeKind.Local))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1875368671)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1939, month: 10, day: 15, hour: 17, minute: 53, second: 2, millisecond: 183, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1961750578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1992, month: 10, day: 16, hour: 1, minute: 16, second: 40, millisecond: 736, kind: DateTimeKind.Local))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateTime(year: 2001, month: 10, day: 13, hour: 18, minute: 47, second: 41, millisecond: 301, kind: DateTimeKind.Local))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2000252295)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateTime(year: 1994, month: 10, day: 8, hour: 21, minute: 2, second: 6, millisecond: 739, kind: DateTimeKind.Local))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1829705451)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateTime(year: 2004, month: 10, day: 11, hour: 1, minute: 25, second: 34, millisecond: 304, kind: DateTimeKind.Local))));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateTime(year: 1928, month: 10, day: 16, hour: 1, minute: 14, second: 38, millisecond: 63, kind: DateTimeKind.Local))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

