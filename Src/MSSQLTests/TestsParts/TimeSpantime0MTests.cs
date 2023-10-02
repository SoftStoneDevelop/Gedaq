

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
    internal partial interface ITimeSpanSingleTypetime
    {
    }
    
    internal partial class TimeSpanSingleTypetime : ITimeSpanSingleTypetime
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0mi(
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
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(32)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(32)
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, 247242861, new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329), new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModelInner(connection, 1799643693, new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994), null);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, 2037532356, new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelInnerAsync(connection, 124018382, new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0mi(
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
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)17
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)17, 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModel(connection, 1535360089, new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79), null);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 843519822, new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 2086139663, new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1731976880, new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1661822138, new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388), new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 95613944, new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374), new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 894528784, new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 1515739069, new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 628868700, new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359), new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 64853121, new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839), new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertInnerModelAsync(connection, 827973867, new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0m(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(32)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(32),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, 355293540, new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456), new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).InsertModel(connection, 1889842808, new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209), new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380), 247242861);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, 146599288, new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).InsertModelAsync(connection, 383967244, new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804), null, 1799643693);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.timespantime0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeSpan), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)17),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)17,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timespantime0mi_id", 
                methodParametrName: "timespantime0mi_id", 
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

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, 1077213316, new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102), new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanSingleTypetime)this).DbConnectionInsertModel(connection, 449852163, new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219), new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227), 2037532356);
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

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 260557300, new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59), new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 392073113, new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566), 124018382);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 618259456, new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 91761867, new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706), new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85), 1535360089);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 139642099, new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775), new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1645722051, new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215), new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8), 843519822);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 835077774, new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 499948967, new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929), null, 2086139663);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1918831021, new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 935130483, new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981), new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942), 1731976880);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1551800438, new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395), new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 329958589, new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501), new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310), 1661822138);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 809876841, new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 797768777, new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153), null, 95613944);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 977730442, new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146), new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1998772097, new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83), new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861), 894528784);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1666739928, new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 385141720, new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823), null, 1515739069);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 802734752, new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1784740046, new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782), new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605), 628868700);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 542642443, new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1037496543, new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675), new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534), 64853121);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 1097187802, new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43), new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanSingleTypetime)this).DbConnectionInsertModelAsync(connection, 428276728, new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70), null, 827973867);
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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpantime0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanSingleTypetime)
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
                var models =  ((ITimeSpanSingleTypetime)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91761867));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535360089));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139642099));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146599288));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260557300));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329958589));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1661822138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355293540));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(383967244));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799643693));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385141720));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1515739069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(392073113));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(124018382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(428276728));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(827973867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449852163));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2037532356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(499948967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086139663));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542642443));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(91761867));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535360089));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139642099));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146599288));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260557300));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329958589));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1661822138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355293540));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(383967244));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799643693));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385141720));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1515739069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(392073113));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(124018382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(428276728));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(827973867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449852163));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2037532356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(499948967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086139663));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542642443));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                var models =  ((ITimeSpanSingleTypetime)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91761867));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535360089));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139642099));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146599288));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260557300));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329958589));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1661822138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355293540));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(383967244));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799643693));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385141720));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1515739069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(392073113));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(124018382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(428276728));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(827973867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449852163));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2037532356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(499948967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086139663));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542642443));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(91761867));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1535360089));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139642099));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146599288));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(260557300));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(329958589));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1661822138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(355293540));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(383967244));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799643693));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385141720));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1515739069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(392073113));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(124018382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(428276728));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(827973867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449852163));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2037532356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(499948967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086139663));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542642443));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 383967244);
                var models =  ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(385141720));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1515739069));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(392073113));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(124018382));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(428276728));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(827973867));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449852163));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2037532356));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(499948967));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2086139663));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542642443));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanSingleTypetime)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanSingleTypetime)this).SetDbConnectionSelectModelParametrs(cmd, 542642443);
                var models = await ((ITimeSpanSingleTypetime)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(618259456));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(797768777));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(95613944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(802734752));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(809876841));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(835077774));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935130483));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1731976880));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(977730442));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1037496543));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64853121));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1077213316));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097187802));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1551800438));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645722051));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(843519822));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1666739928));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784740046));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(628868700));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889842808));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(247242861));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918831021));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998772097));
                Assert.That(model.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(894528784));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513)));

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
FROM dbo.timespantime0m m
LEFT JOIN dbo.timespantime0mi mi ON mi.id = m.timespantime0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((91761867)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1535360089)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139642099)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146599288)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((260557300)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329958589)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1661822138)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((355293540)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((383967244)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1799643693)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((385141720)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1515739069)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((392073113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((124018382)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((428276728)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((827973867)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((449852163)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2037532356)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((499948967)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2086139663)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((542642443)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((618259456)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797768777)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95613944)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((802734752)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((809876841)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((835077774)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((935130483)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1731976880)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((977730442)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1037496543)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64853121)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1077213316)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1097187802)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1551800438)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1645722051)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((843519822)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1666739928)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1784740046)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((628868700)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889842808)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((247242861)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1918831021)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1998772097)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((894528784)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((91761867)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 51, milliseconds: 706))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1535360089)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 52, milliseconds: 79))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 18, milliseconds: 85))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139642099)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 55, milliseconds: 775))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 621))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146599288)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 33, milliseconds: 214))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((260557300)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 21, milliseconds: 59))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 6, milliseconds: 985))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((329958589)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 51, milliseconds: 501))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1661822138)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 52, milliseconds: 388))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 35, milliseconds: 953))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 54, milliseconds: 310))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((355293540)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 21, milliseconds: 456))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 8, milliseconds: 107))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((383967244)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 23, milliseconds: 804))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1799643693)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 54, milliseconds: 994))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((385141720)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 36, milliseconds: 823))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1515739069)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 56, milliseconds: 908))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((392073113)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 34, milliseconds: 323))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((124018382)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 55, milliseconds: 848))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 566))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((428276728)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 32, milliseconds: 70))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((827973867)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 318))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((449852163)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 31, milliseconds: 219))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2037532356)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 14, milliseconds: 386))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 18, milliseconds: 227))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((499948967)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 929))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2086139663)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 418))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((542642443)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 18, milliseconds: 238))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((618259456)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 55, milliseconds: 123))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((797768777)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 32, milliseconds: 153))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95613944)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 46, milliseconds: 374))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 33, milliseconds: 908))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((802734752)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 48, milliseconds: 464))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((809876841)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 25, milliseconds: 729))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((835077774)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 19, milliseconds: 598))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((935130483)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 1, milliseconds: 981))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1731976880)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 19, milliseconds: 361))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 22, milliseconds: 624))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 14, milliseconds: 942))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((977730442)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 28, milliseconds: 146))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 28, milliseconds: 742))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1037496543)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 16, milliseconds: 675))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64853121)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 9, milliseconds: 839))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 7, milliseconds: 809))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 15, milliseconds: 534))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1077213316)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 40, milliseconds: 102))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 19, milliseconds: 505))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1097187802)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 42, milliseconds: 43))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 26, milliseconds: 62))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1551800438)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 11, milliseconds: 646))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1645722051)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 33, milliseconds: 215))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((843519822)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 1, milliseconds: 357))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 18, milliseconds: 8))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1666739928)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 30, milliseconds: 628))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1784740046)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 24, milliseconds: 782))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((628868700)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 57, milliseconds: 359))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 23, milliseconds: 897))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 6, milliseconds: 605))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1889842808)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 0, milliseconds: 209))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((247242861)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 56, milliseconds: 329))));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[4], Is.EqualTo((new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 48, milliseconds: 431))));//InnerModel.NullableValue

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 31, milliseconds: 380))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1918831021)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 49, milliseconds: 441))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1998772097)));//Id
                Assert.That((System.TimeSpan)model[1], Is.EqualTo((new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 47, milliseconds: 83))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((894528784)));//InnerModel.Id
                Assert.That((System.TimeSpan)model[3], Is.EqualTo((new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 5, milliseconds: 513))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeSpan?)model[5], Is.EqualTo((new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 22, milliseconds: 861))));

            }
        }

        #endregion

    }
}

