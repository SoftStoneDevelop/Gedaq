

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
    internal partial interface IDateOnlySingleTypedate
    {
    }
    
    internal partial class DateOnlySingleTypedate : IDateOnlySingleTypedate
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.dateonlydate0mi(
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(10)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(10)
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 194047691, new DateOnly(year: 1949, month: 10, day: 10), new DateOnly(year: 1966, month: 10, day: 7));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 1960425370, new DateOnly(year: 2001, month: 10, day: 5), null);
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 837924458, new DateOnly(year: 1964, month: 10, day: 15), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 317168452, new DateOnly(year: 1978, month: 10, day: 9), new DateOnly(year: 1998, month: 10, day: 3));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.dateonlydate0mi(
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(5)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5), 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModel(connection, 298346541, new DateOnly(year: 1958, month: 10, day: 11), null);
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1955295316, new DateOnly(year: 2018, month: 10, day: 7), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1006404820, new DateOnly(year: 1940, month: 10, day: 12), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1663501894, new DateOnly(year: 1984, month: 10, day: 7), new DateOnly(year: 1947, month: 10, day: 2));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 2144930877, new DateOnly(year: 1954, month: 10, day: 15), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1290803951, new DateOnly(year: 1991, month: 10, day: 12), new DateOnly(year: 1922, month: 10, day: 16));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1181423598, new DateOnly(year: 1988, month: 10, day: 6), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1236525164, new DateOnly(year: 1976, month: 10, day: 5), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 138245662, new DateOnly(year: 1954, month: 10, day: 12), new DateOnly(year: 1985, month: 10, day: 6));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 250676195, new DateOnly(year: 2005, month: 10, day: 14), new DateOnly(year: 1956, month: 10, day: 18));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1243716084, new DateOnly(year: 1925, month: 10, day: 14), new DateOnly(year: 1943, month: 10, day: 5));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @dateonlydate0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(10)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(10),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 1493024973, new DateOnly(year: 1980, month: 10, day: 10), new DateOnly(year: 1952, month: 10, day: 1), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 2107399049, new DateOnly(year: 1979, month: 10, day: 8), null, 194047691);
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 317926907, new DateOnly(year: 1974, month: 10, day: 6), new DateOnly(year: 1958, month: 10, day: 1), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 1207284745, new DateOnly(year: 1948, month: 10, day: 2), new DateOnly(year: 1968, month: 10, day: 12), 1960425370);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @dateonlydate0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(5)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 780222557, new DateOnly(year: 1961, month: 10, day: 15), new DateOnly(year: 1984, month: 10, day: 2), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 1715555649, new DateOnly(year: 1945, month: 10, day: 2), null, 837924458);
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1154342670, new DateOnly(year: 1949, month: 10, day: 1), new DateOnly(year: 1936, month: 10, day: 15), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 632832858, new DateOnly(year: 1926, month: 10, day: 13), null, 317168452);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 529794054, new DateOnly(year: 2002, month: 10, day: 1), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 624912488, new DateOnly(year: 1997, month: 10, day: 17), new DateOnly(year: 2019, month: 10, day: 16), 298346541);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1089099664, new DateOnly(year: 2018, month: 10, day: 15), new DateOnly(year: 1918, month: 10, day: 19), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1964086541, new DateOnly(year: 1928, month: 10, day: 12), null, 1955295316);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 813811959, new DateOnly(year: 1932, month: 10, day: 5), new DateOnly(year: 1936, month: 10, day: 9), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 449502716, new DateOnly(year: 1986, month: 10, day: 3), null, 1006404820);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 733141527, new DateOnly(year: 1995, month: 10, day: 12), new DateOnly(year: 1918, month: 10, day: 14), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1070203232, new DateOnly(year: 1960, month: 10, day: 18), new DateOnly(year: 2017, month: 10, day: 17), 1663501894);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1625467884, new DateOnly(year: 2005, month: 10, day: 3), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1970168680, new DateOnly(year: 2004, month: 10, day: 6), null, 2144930877);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1901990249, new DateOnly(year: 1925, month: 10, day: 18), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1500741239, new DateOnly(year: 2016, month: 10, day: 13), null, 1290803951);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 253234711, new DateOnly(year: 1931, month: 10, day: 3), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 643719010, new DateOnly(year: 1966, month: 10, day: 6), new DateOnly(year: 2015, month: 10, day: 1), 1181423598);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2086535782, new DateOnly(year: 1947, month: 10, day: 19), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 673773131, new DateOnly(year: 1920, month: 10, day: 14), new DateOnly(year: 1959, month: 10, day: 4), 1236525164);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1751516556, new DateOnly(year: 1971, month: 10, day: 13), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1149719513, new DateOnly(year: 2019, month: 10, day: 14), null, 138245662);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1631477307, new DateOnly(year: 1983, month: 10, day: 4), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2020861513, new DateOnly(year: 1971, month: 10, day: 4), null, 250676195);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1137535369, new DateOnly(year: 1980, month: 10, day: 13), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1330459475, new DateOnly(year: 1987, month: 10, day: 7), null, 1243716084);
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
FROM gedaqtests.dateonlydate0m m
LEFT JOIN gedaqtests.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253234711));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317926907));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1974, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449502716));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1006404820));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(529794054));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2002, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624912488));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1997, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 16)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298346541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632832858));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(317168452));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 3)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(643719010));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181423598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(673773131));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1236525164));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(733141527));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(780222557));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1961, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 2)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813811959));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070203232));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2017, month: 10, day: 17)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1663501894));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 2)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253234711));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317926907));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1974, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449502716));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1006404820));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(529794054));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2002, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624912488));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1997, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 16)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298346541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632832858));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(317168452));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 3)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(643719010));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181423598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(673773131));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1236525164));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(733141527));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(780222557));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1961, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 2)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813811959));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070203232));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2017, month: 10, day: 17)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1663501894));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 2)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

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
FROM gedaqtests.dateonlydate0m m
LEFT JOIN gedaqtests.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253234711));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317926907));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1974, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449502716));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1006404820));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(529794054));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2002, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624912488));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1997, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 16)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298346541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632832858));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(317168452));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 3)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(643719010));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181423598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(673773131));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1236525164));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(733141527));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(780222557));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1961, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 2)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813811959));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070203232));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2017, month: 10, day: 17)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1663501894));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 2)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(253234711));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1931, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317926907));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1974, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449502716));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1986, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1006404820));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1940, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(529794054));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2002, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(624912488));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1997, month: 10, day: 17)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 16)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(298346541));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1958, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632832858));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(317168452));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 9)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 3)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(643719010));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1181423598));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(673773131));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1920, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1959, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1236525164));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(733141527));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1995, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(780222557));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1961, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 2)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813811959));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 9)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070203232));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2017, month: 10, day: 17)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1663501894));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 2)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 1715555649);
                var models =  ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(7));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 1149719513);
                var models = await ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(15));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                 foreach(var batchResult in ((IDateOnlySingleTypedate)this).DbConnectionSelectModelBatch(connection, 1149719513, 1070203232))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

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
                await foreach(var batchResult in ((IDateOnlySingleTypedate)this).DbConnectionSelectModelBatchAsync(connection, 813811959, 1154342670))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070203232));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2017, month: 10, day: 17)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1663501894));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1984, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 2)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1089099664));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1918, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1137535369));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1149719513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2019, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(138245662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1985, month: 10, day: 6)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154342670));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 1)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 15)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207284745));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 12)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960425370));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2001, month: 10, day: 5)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1330459475));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1987, month: 10, day: 7)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1243716084));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1943, month: 10, day: 5)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1493024973));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1980, month: 10, day: 10)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1952, month: 10, day: 1)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1500741239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2016, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1290803951));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1991, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 16)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1625467884));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631477307));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1983, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1715555649));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(837924458));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1964, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751516556));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1901990249));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1925, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1964086541));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1928, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1955295316));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2018, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970168680));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2004, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2144930877));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 15)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2020861513));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1971, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(250676195));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2005, month: 10, day: 14)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 18)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086535782));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1947, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2107399049));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(194047691));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 7)));

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
FROM gedaqtests.dateonlydate0m m
LEFT JOIN gedaqtests.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((253234711)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((317926907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1974, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((449502716)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1006404820)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((529794054)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2002, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((624912488)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((298346541)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((632832858)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((317168452)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((643719010)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1181423598)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((673773131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1236525164)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1959, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((733141527)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1995, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((780222557)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1961, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1984, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((813811959)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1932, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1070203232)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1663501894)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1984, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2017, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1089099664)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1137535369)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1149719513)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((138245662)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154342670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1207284745)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1960425370)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1330459475)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1243716084)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1943, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1493024973)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1500741239)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2016, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1290803951)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1625467884)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1631477307)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1715555649)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((837924458)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751516556)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1901990249)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1964086541)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1928, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1955295316)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1970168680)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2004, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2144930877)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2020861513)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((250676195)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2086535782)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2107399049)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((194047691)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((253234711)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((317926907)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1974, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((449502716)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1006404820)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((529794054)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2002, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((624912488)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((298346541)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((632832858)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((317168452)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((643719010)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1181423598)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((673773131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1236525164)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1959, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((733141527)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1995, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((780222557)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1961, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1984, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((813811959)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1932, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1070203232)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1663501894)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1984, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2017, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1089099664)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1137535369)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1149719513)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((138245662)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154342670)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1207284745)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1960425370)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1330459475)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1243716084)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1943, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1493024973)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1500741239)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2016, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1290803951)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1625467884)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1631477307)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1715555649)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((837924458)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751516556)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1901990249)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1964086541)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1928, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1955295316)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1970168680)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2004, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2144930877)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2020861513)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1971, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((250676195)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2005, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2086535782)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2107399049)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((194047691)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

