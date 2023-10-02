

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
    internal partial interface IDateOnlySingleTypedate
    {
    }
    
    internal partial class DateOnlySingleTypedate : IDateOnlySingleTypedate
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0mi(
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
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(31)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(31)
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 802526186, new DateOnly(year: 1949, month: 10, day: 6), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, 1258435854, new DateOnly(year: 1948, month: 10, day: 19), null);
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 871178515, new DateOnly(year: 1945, month: 10, day: 2), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, 2079212983, new DateOnly(year: 1955, month: 10, day: 16), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0mi(
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
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)5
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)5, 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModel(connection, 989364384, new DateOnly(year: 1990, month: 10, day: 7), new DateOnly(year: 2013, month: 10, day: 2));
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 933959017, new DateOnly(year: 1950, month: 10, day: 10), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 956350187, new DateOnly(year: 1969, month: 10, day: 2), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1080446765, new DateOnly(year: 1973, month: 10, day: 1), new DateOnly(year: 1922, month: 10, day: 13));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 13572032, new DateOnly(year: 1970, month: 10, day: 3), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1414846143, new DateOnly(year: 1956, month: 10, day: 1), new DateOnly(year: 1968, month: 10, day: 10));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 1869774132, new DateOnly(year: 2000, month: 10, day: 11), new DateOnly(year: 1960, month: 10, day: 6));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 301406172, new DateOnly(year: 1954, month: 10, day: 7), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 340154484, new DateOnly(year: 1917, month: 10, day: 17), new DateOnly(year: 1923, month: 10, day: 1));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 431345727, new DateOnly(year: 1935, month: 10, day: 12), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, 144526884, new DateOnly(year: 1924, month: 10, day: 4), null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0m(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(31)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(31),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 323785178, new DateOnly(year: 1975, month: 10, day: 19), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, 1284979796, new DateOnly(year: 1988, month: 10, day: 8), new DateOnly(year: 1922, month: 10, day: 3), 802526186);
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

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 1008094809, new DateOnly(year: 1946, month: 10, day: 8), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, 297081047, new DateOnly(year: 1994, month: 10, day: 2), null, 1258435854);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)5),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)5,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 680620265, new DateOnly(year: 1919, month: 10, day: 5), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, 131664632, new DateOnly(year: 1978, month: 10, day: 6), new DateOnly(year: 1953, month: 10, day: 14), 871178515);
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

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 204521254, new DateOnly(year: 1926, month: 10, day: 19), new DateOnly(year: 2012, month: 10, day: 19), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 488808408, new DateOnly(year: 1990, month: 10, day: 16), null, 2079212983);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1274038721, new DateOnly(year: 2015, month: 10, day: 14), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 2089353286, new DateOnly(year: 2009, month: 10, day: 8), null, 989364384);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 850446587, new DateOnly(year: 2013, month: 10, day: 18), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 143809933, new DateOnly(year: 1948, month: 10, day: 2), new DateOnly(year: 1993, month: 10, day: 4), 933959017);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 330994905, new DateOnly(year: 1945, month: 10, day: 4), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 199405304, new DateOnly(year: 1970, month: 10, day: 11), null, 956350187);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1868540817, new DateOnly(year: 1976, month: 10, day: 13), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 798621516, new DateOnly(year: 1965, month: 10, day: 4), null, 1080446765);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1082967521, new DateOnly(year: 1969, month: 10, day: 6), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1789388239, new DateOnly(year: 1982, month: 10, day: 14), new DateOnly(year: 1944, month: 10, day: 4), 13572032);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 740639871, new DateOnly(year: 1926, month: 10, day: 16), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1246548913, new DateOnly(year: 2007, month: 10, day: 3), null, 1414846143);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 426123578, new DateOnly(year: 1944, month: 10, day: 9), new DateOnly(year: 1979, month: 10, day: 7), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1093982177, new DateOnly(year: 1962, month: 10, day: 14), null, 1869774132);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1737709554, new DateOnly(year: 1932, month: 10, day: 4), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1017197291, new DateOnly(year: 1966, month: 10, day: 15), new DateOnly(year: 1968, month: 10, day: 4), 301406172);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 885478007, new DateOnly(year: 1924, month: 10, day: 5), new DateOnly(year: 1936, month: 10, day: 10), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 419912751, new DateOnly(year: 1977, month: 10, day: 12), null, 340154484);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 80998941, new DateOnly(year: 1998, month: 10, day: 8), new DateOnly(year: 1933, month: 10, day: 19), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1803686080, new DateOnly(year: 2013, month: 10, day: 3), new DateOnly(year: 1954, month: 10, day: 13), 431345727);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1222041544, new DateOnly(year: 1965, month: 10, day: 6), new DateOnly(year: 1988, month: 10, day: 13), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, 1436799084, new DateOnly(year: 1942, month: 10, day: 11), new DateOnly(year: 1945, month: 10, day: 7), 144526884);
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
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateOnlydate0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
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
                var models =  ((IDateOnlySingleTypedate)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80998941));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131664632));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871178515));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143809933));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1993, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(933959017));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(199405304));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(956350187));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204521254));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297081047));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1994, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1258435854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 19)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323785178));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330994905));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419912751));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1977, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(340154484));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426123578));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(488808408));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079212983));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680620265));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740639871));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(798621516));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080446765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1973, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 13)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(850446587));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(885478007));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008094809));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1946, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017197291));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301406172));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082967521));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1093982177));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1869774132));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2000, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 6)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1222041544));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

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
                Assert.That(model.Id, Is.EqualTo(80998941));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131664632));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871178515));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143809933));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1993, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(933959017));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(199405304));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(956350187));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204521254));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297081047));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1994, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1258435854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 19)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323785178));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330994905));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419912751));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1977, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(340154484));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426123578));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(488808408));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079212983));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680620265));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740639871));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(798621516));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080446765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1973, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 13)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(850446587));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(885478007));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008094809));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1946, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017197291));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301406172));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082967521));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1093982177));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1869774132));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2000, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 6)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1222041544));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

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
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80998941));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131664632));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871178515));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143809933));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1993, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(933959017));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(199405304));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(956350187));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204521254));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297081047));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1994, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1258435854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 19)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323785178));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330994905));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419912751));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1977, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(340154484));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426123578));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(488808408));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079212983));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680620265));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740639871));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(798621516));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080446765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1973, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 13)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(850446587));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(885478007));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008094809));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1946, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017197291));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301406172));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082967521));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1093982177));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1869774132));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2000, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 6)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1222041544));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

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
                Assert.That(model.Id, Is.EqualTo(80998941));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1998, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1933, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(131664632));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1978, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1953, month: 10, day: 14)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871178515));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143809933));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1993, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(933959017));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1950, month: 10, day: 10)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(199405304));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(956350187));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 2)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(204521254));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 2012, month: 10, day: 19)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(297081047));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1994, month: 10, day: 2)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1258435854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1948, month: 10, day: 19)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323785178));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1975, month: 10, day: 19)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(330994905));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419912751));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1977, month: 10, day: 12)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(340154484));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1917, month: 10, day: 17)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1923, month: 10, day: 1)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426123578));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(488808408));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079212983));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680620265));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740639871));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(798621516));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080446765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1973, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 13)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(850446587));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(885478007));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008094809));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1946, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017197291));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301406172));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082967521));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1093982177));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1869774132));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2000, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 6)));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1222041544));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 1222041544);
                var models =  ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(9));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 419912751);
                var models = await ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(21));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426123578));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 9)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1979, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(488808408));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2079212983));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1955, month: 10, day: 16)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(680620265));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1919, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(740639871));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1926, month: 10, day: 16)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(798621516));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080446765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1973, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 13)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(850446587));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 18)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(885478007));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 5)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1936, month: 10, day: 10)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1008094809));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1946, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1017197291));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1966, month: 10, day: 15)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301406172));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082967521));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1969, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1093982177));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1962, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1869774132));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 2000, month: 10, day: 11)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1960, month: 10, day: 6)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1222041544));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1965, month: 10, day: 6)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1246548913));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2007, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1414846143));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1956, month: 10, day: 1)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 1968, month: 10, day: 10)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1274038721));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2015, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1284979796));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1988, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1922, month: 10, day: 3)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802526186));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1949, month: 10, day: 6)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1436799084));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1942, month: 10, day: 11)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1945, month: 10, day: 7)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(144526884));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1924, month: 10, day: 4)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737709554));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1932, month: 10, day: 4)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1789388239));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1982, month: 10, day: 14)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1944, month: 10, day: 4)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(13572032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1970, month: 10, day: 3)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803686080));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 3)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new DateOnly(year: 1954, month: 10, day: 13)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(431345727));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1935, month: 10, day: 12)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1868540817));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 1976, month: 10, day: 13)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2089353286));
                Assert.That(model.Value, Is.EqualTo(new DateOnly(year: 2009, month: 10, day: 8)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(989364384));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new DateOnly(year: 1990, month: 10, day: 7)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new DateOnly(year: 2013, month: 10, day: 2)));

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
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((80998941)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131664632)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((871178515)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143809933)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((933959017)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1993, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199405304)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((956350187)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1969, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204521254)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((297081047)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1258435854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((323785178)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((330994905)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((419912751)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1977, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((340154484)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((426123578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((488808408)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1990, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2079212983)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((680620265)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((740639871)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((798621516)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1965, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1080446765)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((850446587)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((885478007)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1008094809)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1017197291)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((301406172)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1082967521)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1969, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1093982177)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1869774132)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2000, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1222041544)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1965, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1246548913)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1414846143)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1274038721)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1284979796)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802526186)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436799084)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1942, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((144526884)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1737709554)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1932, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1789388239)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13572032)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1803686080)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((431345727)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1935, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1868540817)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2089353286)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2009, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((989364384)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1990, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((80998941)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131664632)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1978, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((871178515)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143809933)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((933959017)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1993, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199405304)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((956350187)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1969, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204521254)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((297081047)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1258435854)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((323785178)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1975, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((330994905)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((419912751)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1977, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((340154484)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((426123578)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((488808408)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1990, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2079212983)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((680620265)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((740639871)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((798621516)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1965, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1080446765)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((850446587)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((885478007)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1008094809)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1017197291)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((301406172)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1082967521)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1969, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1093982177)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1869774132)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2000, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1222041544)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1965, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1246548913)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2007, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1414846143)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1274038721)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1284979796)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802526186)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1436799084)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1942, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((144526884)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1737709554)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1932, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1789388239)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 14)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13572032)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1803686080)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((431345727)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1935, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1954, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1868540817)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2089353286)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2009, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((989364384)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1990, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

